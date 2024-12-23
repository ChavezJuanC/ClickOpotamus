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
            this.MainTableLayout.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
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
            this.BottomTabelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTabelLayout.Location = new System.Drawing.Point(3, 233);
            this.BottomTabelLayout.Name = "BottomTabelLayout";
            this.BottomTabelLayout.RowCount = 1;
            this.BottomTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.BottomTabelLayout.Size = new System.Drawing.Size(528, 225);
            this.BottomTabelLayout.TabIndex = 1;
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
    }
}

