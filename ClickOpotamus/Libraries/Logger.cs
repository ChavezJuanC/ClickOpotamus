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
            public string StartTime { get; set; }
            public int Total { get; set; }
            public int LeftClicks { get; set; }
            public int RightClicks { get; set; }
            public float MinAverage { get; set; }
            public float HourAverage { get; set; }
            public string EndTime { get; set; }
        }

        //read-only file path for security
        public readonly string _fileName = Path.Combine("logs", "clickslog.json");
        public string existingData;
        public List<ClickLog> dataList;


        //Check for file if it doesnt exist / Create it
        private void EnsureFileExists()
        {
            if (!File.Exists(_fileName))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_fileName));
                File.WriteAllText(_fileName, "[]"); // Initialize with an empty JSON array
            }
        }

        public void AppendToFile(ClickLog log)
        {
            EnsureFileExists();

            try
            {
                // Read existing data
                UpdateLogList();
                dataList.Add(log);

                // Serialize and overwrite the file
                string jsonData = JsonSerializer.Serialize(dataList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_fileName, jsonData);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error during deserialization: {ex.Message}");
            }
        }

        public void UpdateLogList()
        {
            existingData = File.ReadAllText(_fileName);
            dataList = JsonSerializer.Deserialize<List<ClickLog>>(existingData) ?? new List<ClickLog>();
        }

        public void ClearLog()
        {
            try
            {
                existingData = "[]";
                dataList = JsonSerializer.Deserialize<List<ClickLog>>(existingData) ?? new List<ClickLog>();
                string jsonData = JsonSerializer.Serialize(dataList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_fileName, jsonData);
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error Clearing Log: {e}");
            }
        }
    }
}