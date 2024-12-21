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

        //Dynamic GUI
        private bool _isFullSize = false;

        //ClickLog Stuct
        private struct ClickLog
        {
            private int Total;
            private int LeftClicks;
            private int RightClicks;
            private float MinAverage;
            private float HourAverage;
            private string StartTime;
            private string EndTime;//This should be of a better type!
            private float SessionDuration; //in seconds
        }

        // Init //
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Subscribe();
            ResetWindow();
        }

        // Mouse Tracking //
        private void Subscribe()
        {
            _globalHook = Hook.GlobalEvents();
            ListenForMouseEvents();
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
    }
}

/*
 
Next steps

-Implement GUI counter
-Implement Button enable/diable relations
-Implement Save Log into console (Total: Average: L: R: TimeStamp: ) // use struct!!

-implement Bottom Section GUI Layout
-Feed Labels on STOP
-If saved, feed log to Log File.

-Implement LogFile display section with mock Data
-On Load -- Read from file and upate GUI
-On Save -- Also read from file to update.. (async??)

 */