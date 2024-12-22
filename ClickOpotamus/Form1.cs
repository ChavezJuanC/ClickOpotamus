using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
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

        //Dynamic GUI
        private bool _isFullSize = false;

        //Timming 
        private DateTime _startTime = new DateTime();
        private DateTime _endTime = new DateTime();


        //ClickLog Stuct
        private struct ClickLog
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
                Console.WriteLine($"Right: {_rightClickCount}");
            }
            else if (e.Button.ToString() == "Left")
            {
                _leftClickCount++;
                Console.WriteLine($"Left: {_leftClickCount}");
            }
            else
            {
                _otherClicksCount++;
                Console.WriteLine($"Other: {_otherClicksCount}");
            }

            SetNewCountText(_rightClickCount, _leftClickCount, _otherClicksCount);
        }

        private void SetNewCountText(int r, int l, int o)
        {
            ClickCounterLabel.Text = $"{AddMouseEvents(r, l, o).ToString()} Clicks";
        }

        private int AddMouseEvents(int r, int l, int o)
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
            this.MinimumSize = minSize;
            this.Size = minSize;
            this.MaximumSize = new System.Drawing.Size(660, 320);
            _isFullSize = false;
            RefactorLayout();
        }

        private void ExpandWindow()
        {
            Size minSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = minSize;
            this.Size = minSize;
            this.MaximumSize = new System.Drawing.Size(660, 600);
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

            ClickLog log = FormatClickLog();
            Console.WriteLine($"Total: {log.Total}");
            Console.WriteLine($"RightClicks: {log.RightClicks}");
            Console.WriteLine($"LeftClicks: {log.LeftClicks}");
        }
        private ClickLog FormatClickLog()
        {
            ClickLog log = new ClickLog
            {
                Total = _totalMouseEvents,
                LeftClicks = _leftClickCount,
                RightClicks = _rightClickCount,
                MinAverage = _totalMouseEvents / 60f,
                HourAverage = _totalMouseEvents / 3600f,
                StartTime = _startTime.ToString("MM/dd/yy HH:mm:ss"),
                EndTime = _endTime.ToString("MM/dd/yy HH:mm:ss"),
                SessionDuration = _totalMouseEvents
            };
            return log;
        }
    }
}

/*
 
Next steps

-Implement Save Log into console (Total: Average: L: R: TimeStamp: ) // use struct!!

-implement Bottom Section GUI Layout
-Feed Labels on STOP
-If saved, feed log to Log File.

-Implement LogFile display section with mock Data
-On Load -- Read from file and upate GUI
-On Save -- Also read from file to update.. (async??)

 */