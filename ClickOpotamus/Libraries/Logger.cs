using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ClickOpotamus.Libraries
{
    public class Logger
    {
        public struct ClickLog
        {
            public int Total;
            public int LeftClicks;
            public int RightClicks;
            public float MinAverage;
            public float HourAverage;
            public string StartTime;
            public string EndTime;
            public float SessionDuration;
        }

        //read-only file path for security
        private readonly string _fileName = Path.Combine("logs", "clickslog.json");

        //Check for file if it doesnt exist / Create it
        private void EnsureFileExists()
        {
            if (!File.Exists(_fileName))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_fileName));
                File.WriteAllText(_fileName, "[]"); // Initialize with an empty JSON array
                Console.WriteLine("File created.");
            }
        }

        public void AppendToFile(ClickLog log)
        {
            EnsureFileExists();

            List<ClickLog> dataList;

            // Read existing data
            string existingData = File.ReadAllText(_fileName);
            dataList = JsonSerializer.Deserialize<List<ClickLog>>(existingData) ?? new List<ClickLog>();

            // Add the new entry //This is a mock entry but you would send your struct here.. maybe pass it as a param...
            dataList.Add(log);

            // Serialize and overwrite the file
            string jsonData = JsonSerializer.Serialize(dataList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_fileName, jsonData);

            Console.WriteLine("Logged!");
        }
    }
}