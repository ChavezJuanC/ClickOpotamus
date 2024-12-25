namespace ClickOpotamus
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ShowLogLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClickCounterLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BottomTabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LogCardLayout = new System.Windows.Forms.TableLayoutPanel();
            this.HourAvgCountLbl = new System.Windows.Forms.Label();
            this.MinAvgCountLbl = new System.Windows.Forms.Label();
            this.RightCountLbl = new System.Windows.Forms.Label();
            this.LeftCountLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.HourAverageLbl = new System.Windows.Forms.Label();
            this.MinAverageLbl = new System.Windows.Forms.Label();
            this.LeftClicksLbl = new System.Windows.Forms.Label();
            this.RightClicksLbl = new System.Windows.Forms.Label();
            this.TotalCountLbl = new System.Windows.Forms.Label();
            this.LogsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OpenLogLbl = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.BottomTabelLayout.SuspendLayout();
            this.LogCardLayout.SuspendLayout();
            this.LogsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.TopTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.BottomTabelLayout, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(534, 461);
            this.MainTableLayout.TabIndex = 0;
            // 
            // TopTableLayout
            // 
            this.TopTableLayout.ColumnCount = 5;
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.Controls.Add(this.ShowLogLabel, 0, 3);
            this.TopTableLayout.Controls.Add(this.TitleLabel, 0, 0);
            this.TopTableLayout.Controls.Add(this.ClickCounterLabel, 0, 1);
            this.TopTableLayout.Controls.Add(this.StartButton, 1, 2);
            this.TopTableLayout.Controls.Add(this.StopButton, 2, 2);
            this.TopTableLayout.Controls.Add(this.SaveButton, 3, 2);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(3, 3);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 4;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.Size = new System.Drawing.Size(528, 224);
            this.TopTableLayout.TabIndex = 0;
            // 
            // ShowLogLabel
            // 
            this.ShowLogLabel.AutoSize = true;
            this.ShowLogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(206)))));
            this.TopTableLayout.SetColumnSpan(this.ShowLogLabel, 5);
            this.ShowLogLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowLogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ShowLogLabel.Location = new System.Drawing.Point(3, 168);
            this.ShowLogLabel.Name = "ShowLogLabel";
            this.ShowLogLabel.Size = new System.Drawing.Size(522, 56);
            this.ShowLogLabel.TabIndex = 0;
            this.ShowLogLabel.Text = "Show Log";
            this.ShowLogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowLogLabel.Click += new System.EventHandler(this.ShowLogLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TopTableLayout.SetColumnSpan(this.TitleLabel, 5);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TitleLabel.Size = new System.Drawing.Size(522, 56);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Click O\' Potamus Mouse Tracker";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickCounterLabel
            // 
            this.ClickCounterLabel.AutoSize = true;
            this.ClickCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(206)))));
            this.TopTableLayout.SetColumnSpan(this.ClickCounterLabel, 5);
            this.ClickCounterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClickCounterLabel.Font = new System.Drawing.Font("Noto Kufi Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickCounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClickCounterLabel.Location = new System.Drawing.Point(3, 56);
            this.ClickCounterLabel.Name = "ClickCounterLabel";
            this.ClickCounterLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ClickCounterLabel.Size = new System.Drawing.Size(522, 56);
            this.ClickCounterLabel.TabIndex = 1;
            this.ClickCounterLabel.Text = "X Clicks";
            this.ClickCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartButton.Location = new System.Drawing.Point(108, 127);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 30);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopButton.Location = new System.Drawing.Point(225, 127);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 30);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(342, 127);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BottomTabelLayout
            // 
            this.BottomTabelLayout.ColumnCount = 2;
            this.BottomTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.BottomTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.BottomTabelLayout.Controls.Add(this.LogCardLayout, 0, 0);
            this.BottomTabelLayout.Controls.Add(this.LogsLayout, 1, 0);
            this.BottomTabelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTabelLayout.Location = new System.Drawing.Point(3, 233);
            this.BottomTabelLayout.Name = "BottomTabelLayout";
            this.BottomTabelLayout.RowCount = 1;
            this.BottomTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.BottomTabelLayout.Size = new System.Drawing.Size(528, 225);
            this.BottomTabelLayout.TabIndex = 1;
            // 
            // LogCardLayout
            // 
            this.LogCardLayout.ColumnCount = 2;
            this.LogCardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogCardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogCardLayout.Controls.Add(this.HourAvgCountLbl, 1, 4);
            this.LogCardLayout.Controls.Add(this.MinAvgCountLbl, 1, 3);
            this.LogCardLayout.Controls.Add(this.RightCountLbl, 1, 2);
            this.LogCardLayout.Controls.Add(this.LeftCountLbl, 1, 1);
            this.LogCardLayout.Controls.Add(this.TotalLbl, 0, 0);
            this.LogCardLayout.Controls.Add(this.HourAverageLbl, 0, 4);
            this.LogCardLayout.Controls.Add(this.MinAverageLbl, 0, 3);
            this.LogCardLayout.Controls.Add(this.LeftClicksLbl, 0, 1);
            this.LogCardLayout.Controls.Add(this.RightClicksLbl, 0, 2);
            this.LogCardLayout.Controls.Add(this.TotalCountLbl, 1, 0);
            this.LogCardLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogCardLayout.Location = new System.Drawing.Point(3, 3);
            this.LogCardLayout.Name = "LogCardLayout";
            this.LogCardLayout.RowCount = 5;
            this.LogCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogCardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogCardLayout.Size = new System.Drawing.Size(152, 219);
            this.LogCardLayout.TabIndex = 0;
            // 
            // HourAvgCountLbl
            // 
            this.HourAvgCountLbl.AutoSize = true;
            this.HourAvgCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourAvgCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourAvgCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.HourAvgCountLbl.Location = new System.Drawing.Point(79, 172);
            this.HourAvgCountLbl.Name = "HourAvgCountLbl";
            this.HourAvgCountLbl.Size = new System.Drawing.Size(70, 47);
            this.HourAvgCountLbl.TabIndex = 9;
            this.HourAvgCountLbl.Text = "000";
            this.HourAvgCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinAvgCountLbl
            // 
            this.MinAvgCountLbl.AutoSize = true;
            this.MinAvgCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinAvgCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinAvgCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MinAvgCountLbl.Location = new System.Drawing.Point(79, 129);
            this.MinAvgCountLbl.Name = "MinAvgCountLbl";
            this.MinAvgCountLbl.Size = new System.Drawing.Size(70, 43);
            this.MinAvgCountLbl.TabIndex = 8;
            this.MinAvgCountLbl.Text = "000";
            this.MinAvgCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightCountLbl
            // 
            this.RightCountLbl.AutoSize = true;
            this.RightCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.RightCountLbl.Location = new System.Drawing.Point(79, 86);
            this.RightCountLbl.Name = "RightCountLbl";
            this.RightCountLbl.Size = new System.Drawing.Size(70, 43);
            this.RightCountLbl.TabIndex = 7;
            this.RightCountLbl.Text = "000";
            this.RightCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftCountLbl
            // 
            this.LeftCountLbl.AutoSize = true;
            this.LeftCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LeftCountLbl.Location = new System.Drawing.Point(79, 43);
            this.LeftCountLbl.Name = "LeftCountLbl";
            this.LeftCountLbl.Size = new System.Drawing.Size(70, 43);
            this.LeftCountLbl.TabIndex = 6;
            this.LeftCountLbl.Text = "000";
            this.LeftCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.TotalLbl.Location = new System.Drawing.Point(3, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(70, 43);
            this.TotalLbl.TabIndex = 0;
            this.TotalLbl.Text = "Total";
            this.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourAverageLbl
            // 
            this.HourAverageLbl.AutoSize = true;
            this.HourAverageLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourAverageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourAverageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.HourAverageLbl.Location = new System.Drawing.Point(3, 172);
            this.HourAverageLbl.Name = "HourAverageLbl";
            this.HourAverageLbl.Size = new System.Drawing.Size(70, 47);
            this.HourAverageLbl.TabIndex = 4;
            this.HourAverageLbl.Text = "AVG/hour";
            this.HourAverageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinAverageLbl
            // 
            this.MinAverageLbl.AutoSize = true;
            this.MinAverageLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinAverageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinAverageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MinAverageLbl.Location = new System.Drawing.Point(3, 129);
            this.MinAverageLbl.Name = "MinAverageLbl";
            this.MinAverageLbl.Size = new System.Drawing.Size(70, 43);
            this.MinAverageLbl.TabIndex = 3;
            this.MinAverageLbl.Text = "AVG/min";
            this.MinAverageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftClicksLbl
            // 
            this.LeftClicksLbl.AutoSize = true;
            this.LeftClicksLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftClicksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftClicksLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LeftClicksLbl.Location = new System.Drawing.Point(3, 43);
            this.LeftClicksLbl.Name = "LeftClicksLbl";
            this.LeftClicksLbl.Size = new System.Drawing.Size(70, 43);
            this.LeftClicksLbl.TabIndex = 1;
            this.LeftClicksLbl.Text = "Left";
            this.LeftClicksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightClicksLbl
            // 
            this.RightClicksLbl.AutoSize = true;
            this.RightClicksLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightClicksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightClicksLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.RightClicksLbl.Location = new System.Drawing.Point(3, 86);
            this.RightClicksLbl.Name = "RightClicksLbl";
            this.RightClicksLbl.Size = new System.Drawing.Size(70, 43);
            this.RightClicksLbl.TabIndex = 2;
            this.RightClicksLbl.Text = "Right";
            this.RightClicksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCountLbl
            // 
            this.TotalCountLbl.AutoSize = true;
            this.TotalCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.TotalCountLbl.Location = new System.Drawing.Point(79, 0);
            this.TotalCountLbl.Name = "TotalCountLbl";
            this.TotalCountLbl.Size = new System.Drawing.Size(70, 43);
            this.TotalCountLbl.TabIndex = 5;
            this.TotalCountLbl.Text = "000";
            this.TotalCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogsLayout
            // 
            this.LogsLayout.ColumnCount = 1;
            this.LogsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogsLayout.Controls.Add(this.OpenLogLbl, 0, 1);
            this.LogsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsLayout.Location = new System.Drawing.Point(161, 3);
            this.LogsLayout.Name = "LogsLayout";
            this.LogsLayout.RowCount = 2;
            this.LogsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LogsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LogsLayout.Size = new System.Drawing.Size(364, 219);
            this.LogsLayout.TabIndex = 1;
            // 
            // OpenLogLbl
            // 
            this.OpenLogLbl.AutoSize = true;
            this.OpenLogLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenLogLbl.Location = new System.Drawing.Point(3, 197);
            this.OpenLogLbl.Name = "OpenLogLbl";
            this.OpenLogLbl.Size = new System.Drawing.Size(358, 22);
            this.OpenLogLbl.TabIndex = 0;
            this.OpenLogLbl.Text = "Open Log";
            this.OpenLogLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.MainTableLayout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "ClickOpotamus";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.TopTableLayout.ResumeLayout(false);
            this.TopTableLayout.PerformLayout();
            this.BottomTabelLayout.ResumeLayout(false);
            this.LogCardLayout.ResumeLayout(false);
            this.LogCardLayout.PerformLayout();
            this.LogsLayout.ResumeLayout(false);
            this.LogsLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.TableLayoutPanel BottomTabelLayout;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ShowLogLabel;
        private System.Windows.Forms.Label ClickCounterLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TableLayoutPanel LogCardLayout;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label HourAverageLbl;
        private System.Windows.Forms.Label MinAverageLbl;
        private System.Windows.Forms.Label LeftClicksLbl;
        private System.Windows.Forms.Label RightClicksLbl;
        private System.Windows.Forms.TableLayoutPanel LogsLayout;
        private System.Windows.Forms.Label HourAvgCountLbl;
        private System.Windows.Forms.Label MinAvgCountLbl;
        private System.Windows.Forms.Label RightCountLbl;
        private System.Windows.Forms.Label LeftCountLbl;
        private System.Windows.Forms.Label TotalCountLbl;
        private System.Windows.Forms.Label OpenLogLbl;
    }
}

