namespace OpenTimer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.HourText = new System.Windows.Forms.Label();
            this.MinutesText = new System.Windows.Forms.Label();
            this.SecondsText = new System.Windows.Forms.Label();
            this.HoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(6, 141);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(139, 65);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PauseButton.Location = new System.Drawing.Point(151, 141);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(153, 65);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopButton.Location = new System.Drawing.Point(310, 141);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(139, 65);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // HourText
            // 
            this.HourText.AutoSize = true;
            this.HourText.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HourText.Location = new System.Drawing.Point(12, 9);
            this.HourText.Name = "HourText";
            this.HourText.Size = new System.Drawing.Size(138, 59);
            this.HourText.TabIndex = 6;
            this.HourText.Text = "Hours";
            // 
            // MinutesText
            // 
            this.MinutesText.AutoSize = true;
            this.MinutesText.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinutesText.Location = new System.Drawing.Point(139, 9);
            this.MinutesText.Name = "MinutesText";
            this.MinutesText.Size = new System.Drawing.Size(177, 59);
            this.MinutesText.TabIndex = 7;
            this.MinutesText.Text = "Minutes";
            // 
            // SecondsText
            // 
            this.SecondsText.AutoSize = true;
            this.SecondsText.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondsText.Location = new System.Drawing.Point(298, 9);
            this.SecondsText.Name = "SecondsText";
            this.SecondsText.Size = new System.Drawing.Size(182, 59);
            this.SecondsText.TabIndex = 8;
            this.SecondsText.Text = "Seconds";
            // 
            // HoursUpDown
            // 
            this.HoursUpDown.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoursUpDown.Location = new System.Drawing.Point(13, 71);
            this.HoursUpDown.Name = "HoursUpDown";
            this.HoursUpDown.Size = new System.Drawing.Size(120, 64);
            this.HoursUpDown.TabIndex = 9;
            // 
            // MinutesUpDown
            // 
            this.MinutesUpDown.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinutesUpDown.Location = new System.Drawing.Point(172, 71);
            this.MinutesUpDown.Name = "MinutesUpDown";
            this.MinutesUpDown.Size = new System.Drawing.Size(120, 64);
            this.MinutesUpDown.TabIndex = 10;
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondsUpDown.Location = new System.Drawing.Point(319, 71);
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(120, 64);
            this.SecondsUpDown.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 239);
            this.Controls.Add(this.SecondsUpDown);
            this.Controls.Add(this.MinutesUpDown);
            this.Controls.Add(this.HoursUpDown);
            this.Controls.Add(this.SecondsText);
            this.Controls.Add(this.MinutesText);
            this.Controls.Add(this.HourText);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainWindow";
            this.Text = "OpenTimer";
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private Button PauseButton;
        private Button StopButton;
        private Label HourText;
        private Label MinutesText;
        private Label SecondsText;
        private NumericUpDown HoursUpDown;
        private NumericUpDown MinutesUpDown;
        private NumericUpDown SecondsUpDown;
    }
}