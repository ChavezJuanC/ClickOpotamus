﻿using ClickOpotamus.Libraries;
using Gma.System.MouseKeyHook;
using System;
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
            Size minSize = new System.Drawing.Size(550, 250);
            Size maxSize = new System.Drawing.Size(660, 320);
            this.MinimumSize = minSize;
            this.MaximumSize = maxSize;
            this.Size = minSize;
            _isFullSize = false;
            RefactorLayout();
        }

        private void ExpandWindow()
        {
            Size minSize = new System.Drawing.Size(550, 500);
            Size maxSize = new System.Drawing.Size(660, 600);
            this.MinimumSize = minSize;
            this.MaximumSize = maxSize;
            this.Size = minSize;
            _isFullSize = true;
            RefactorLayout();
        }

        private void ResizeApp()
        {
            if (_isFullSize)
            {
                ResetWindow();
            }
            else
            {
                ExpandWindow();
            }
        }

        private void ShowLogLabel_Click(object sender, EventArgs e)
        {
            ResizeApp();
        }

        // Saving to Log //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            StopButton.Enabled = false;
            StartButton.Enabled = true;

            var log = FormatClickLog();
            Task.Run(() =>
            {
                _fileLogger.AppendToFile(new Logger.ClickLog
                {
                    Total = log.Total,
                    LeftClicks = log.LeftClicks,
                    RightClicks = log.RightClicks,
                    MinAverage = log.MinAverage,
                    HourAverage = log.HourAverage,
                    StartTime = log.StartTime,
                    EndTime = log.EndTime,
                });
            });
        }
        private Logger.ClickLog FormatClickLog()
        {
            var log = new Logger.ClickLog
            {
                Total = _totalMouseEvents,
                LeftClicks = _leftClickCount,
                RightClicks = _rightClickCount,
                MinAverage = _totalMouseEvents / 60f,
                HourAverage = _totalMouseEvents / 3600f,
                StartTime = _startTime.ToString("MM/dd/yy HH:mm:ss"),
                EndTime = _endTime.ToString("MM/dd/yy HH:mm:ss"),
            };
            return log;
        }
    }
}

/*
 
Next steps

Style

-Draw out bottom section design
-implement Bottom Section GUI Layout
-allow opening of log file or atleast link to location
-Feed Labels on STOP (right side)
-If saved, feed log to Log File. (left side)


-Implement LogFile display section with mock Data
-On Load -- Read from file and upate GUI
-On Save -- Also read from file to update.. (async??)


 */

