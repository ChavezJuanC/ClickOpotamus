using ClickOpotamus.Libraries;
using Gma.System.MouseKeyHook;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickOpotamus
{
    public partial class MainWindow : Form
    {
        //Counter Vars
        private IKeyboardMouseEvents _globalHook;
        private int _rightClickCount = 0;
        private int _leftClickCount = 0;
        private int _otherClicksCount = 0;
        private int _totalMouseEvents = 0;
        private Logger _fileLogger = new Logger();

        //Dynamic GUI
        private bool _isFullSize = false;

        //Timming 
        private DateTime _startTime = new DateTime();
        private DateTime _endTime = new DateTime();

        //
        private Logger.ClickLog _clickLog = new Logger.ClickLog();

        // Init //
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ResetWindow();

            //Disable stop and save
            StopButton.Enabled = false;
            SaveButton.Enabled = false;
            ResetCounts();
            ResetLogCard();
            _fileLogger.UpdateLogList();
            UpdateLogListGUI();
        }

        // Mouse Tracking //
        private void Subscribe()
        {
            _globalHook = Hook.GlobalEvents();
        }

        private void UnSubscribe()
        {
            _globalHook.Dispose();
        }

        private void ListenForMouseEvents()
        {
            _globalHook.MouseDownExt += HandleMouseEvent;

        }

        private void HandleMouseEvent(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                _rightClickCount++;
            }
            else if (e.Button.ToString() == "Left")
            {
                _leftClickCount++;
            }
            else
            {
                _otherClicksCount++;
            }

            SetNewCountText();
        }

        private void SetNewCountText()
        {
            ClickCounterLabel.Text = $"{AddMouseEvents()} Clicks";
        }

        private int AddMouseEvents()
        {
            _totalMouseEvents = _rightClickCount + _leftClickCount + _otherClicksCount;
            return _totalMouseEvents;
        }

        private void ResetCounts()
        {
            ClickCounterLabel.Text = "0 Clicks";
            _totalMouseEvents = 0;
            _rightClickCount = 0;
            _leftClickCount = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetLogCard();
            _startTime = DateTime.Now;
            Subscribe();
            ResetCounts();
            ListenForMouseEvents();
            StartButton.Enabled = false;
            SaveButton.Enabled = false;
            StopButton.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _endTime = DateTime.Now;
            UnSubscribe();
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            SaveButton.Enabled = true;
            FeedLogCard();
        }

        private void FeedLogCard()
        {
            _clickLog = FormatClickLog();
            Console.WriteLine("Ready to GUI");

            TotalCountLbl.Text = _clickLog.Total.ToString();
            LeftCountLbl.Text = _clickLog.LeftClicks.ToString();
            RightCountLbl.Text = _clickLog.RightClicks.ToString();
            MinAvgCountLbl.Text = _clickLog.MinAverage.ToString();
            HourAvgCountLbl.Text = _clickLog.HourAverage.ToString();
        }

        private void ResetLogCard()
        {
            Label[] Label = {
            TotalCountLbl,
            LeftCountLbl,
            RightCountLbl,
            MinAvgCountLbl,
            HourAvgCountLbl};

            for (int i = 0; i < Label.Length; i++)
            {
                Label[i].Text = "00";
            }
        }

        private void OpenLogLbl_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Process.Start(_fileLogger._fileName);
            });
        }

        // Window Resizing //
        private void RefactorLayout()
        {
            if (_isFullSize)
            {
                MainTableLayout.RowCount = 2;
                BottomTabelLayout.Show();
            }
            else
            {
                MainTableLayout.RowCount = 1;
                BottomTabelLayout.Hide();
            }
        }

        private void ResetWindow()
        {
            Size minSize = new Size(550, 250);
            Size maxSize = new Size(660, 320);
            this.MinimumSize = minSize;
            this.MaximumSize = maxSize;
            this.Height = 250;
            _isFullSize = false;
            RefactorLayout();
        }

        private void ExpandWindow()
        {
            Size minSize = new Size(550, 500);
            Size maxSize = new Size(660, 500);
            this.MinimumSize = minSize;
            this.MaximumSize = maxSize;
            this.Height = 500;
            _isFullSize = true;
            RefactorLayout();
        }

        private void ResizeApp()
        {
            if (_isFullSize)
            {
                ResetWindow();
                ShowLogLabel.Text = "Show Log";
            }
            else
            {
                ExpandWindow();
                ShowLogLabel.Text = "Hide Log";
            }
        }

        private void ShowLogLabel_Click(object sender, EventArgs e)
        {
            ResizeApp();
        }
        private void ClearLogsLbl_Click(object sender, EventArgs e)
        {
            _fileLogger.ClearLog();
            UpdateLogListGUI();
        }

        // Saving to Log //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            StopButton.Enabled = false;
            StartButton.Enabled = true;

            Console.WriteLine("Save Log Here..");
            PopulateLogGUI();

        }

        private void AppendToGui()
        {
            try
            {
                // Append data to the log file
                _fileLogger.AppendToFile(new Logger.ClickLog
                {
                    Total = _clickLog.Total,
                    LeftClicks = _clickLog.LeftClicks,
                    RightClicks = _clickLog.RightClicks,
                    MinAverage = _clickLog.MinAverage,
                    HourAverage = _clickLog.HourAverage,
                    StartTime = _clickLog.StartTime,
                    EndTime = _clickLog.EndTime,
                });
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur while writing the file
                Console.WriteLine($"Error logging data: {ex.Message}");
            }
        }

        private void PopulateLogGUI()
        {
            // Start the background task to log the data
            Task.Run(() =>
            {
                AppendToGui();
            })
            .ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    Console.WriteLine("Task failed: " + t.Exception?.Message);
                }
                else
                {
                    this.Invoke((Action)(() =>
                    {
                        UpdateLogListGUI();
                    }));
                }
            }, TaskScheduler.FromCurrentSynchronizationContext()
            );
        }

        private void UpdateLogListGUI()
        {
            LogDataGrid.DataSource = _fileLogger.dataList;

        }

        private Logger.ClickLog FormatClickLog()
        {
            var log = new Logger.ClickLog
            {
                Total = _totalMouseEvents,
                LeftClicks = _leftClickCount,
                RightClicks = _rightClickCount,
                MinAverage = (float)Math.Round(_totalMouseEvents / 60f, 3),
                HourAverage = (float)Math.Round(_totalMouseEvents / 3600f, 3),
                StartTime = _startTime.ToString("MM/dd/yy HH:mm:ss"),
                EndTime = _endTime.ToString("MM/dd/yy HH:mm:ss"),
            };
            return log;
        }
    }
}

/*
 
Next steps

-Avoid weird resize by keeping the width the same on expand / reset
-should still keep min and max 

 */

