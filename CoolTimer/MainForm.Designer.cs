namespace CoolTimer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.years = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.days = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.hours = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.minutes = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.seconds = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lbYears = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbMonths = new System.Windows.Forms.Label();
            this.months = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // years
            // 
            this.years.animated = false;
            this.years.animationIterval = 5;
            this.years.animationSpeed = 300;
            this.years.BackColor = System.Drawing.Color.White;
            this.years.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("years.BackgroundImage")));
            this.years.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.years.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.years.LabelVisible = false;
            this.years.LineProgressThickness = 8;
            this.years.LineThickness = 5;
            this.years.Location = new System.Drawing.Point(19, 18);
            this.years.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.years.MaxValue = 100;
            this.years.Name = "years";
            this.years.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.years.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.years.Size = new System.Drawing.Size(201, 201);
            this.years.TabIndex = 0;
            this.years.Value = 0;
            // 
            // days
            // 
            this.days.animated = false;
            this.days.animationIterval = 5;
            this.days.animationSpeed = 300;
            this.days.BackColor = System.Drawing.Color.White;
            this.days.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("days.BackgroundImage")));
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.days.LabelVisible = false;
            this.days.LineProgressThickness = 8;
            this.days.LineThickness = 5;
            this.days.Location = new System.Drawing.Point(461, 18);
            this.days.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.days.MaxValue = 31;
            this.days.Name = "days";
            this.days.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.days.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.days.Size = new System.Drawing.Size(201, 201);
            this.days.TabIndex = 1;
            this.days.Value = 0;
            // 
            // hours
            // 
            this.hours.animated = false;
            this.hours.animationIterval = 5;
            this.hours.animationSpeed = 300;
            this.hours.BackColor = System.Drawing.Color.White;
            this.hours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hours.BackgroundImage")));
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hours.LabelVisible = false;
            this.hours.LineProgressThickness = 8;
            this.hours.LineThickness = 5;
            this.hours.Location = new System.Drawing.Point(19, 237);
            this.hours.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hours.MaxValue = 24;
            this.hours.Name = "hours";
            this.hours.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.hours.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hours.Size = new System.Drawing.Size(201, 201);
            this.hours.TabIndex = 2;
            this.hours.Value = 0;
            // 
            // minutes
            // 
            this.minutes.animated = false;
            this.minutes.animationIterval = 5;
            this.minutes.animationSpeed = 300;
            this.minutes.BackColor = System.Drawing.Color.White;
            this.minutes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minutes.BackgroundImage")));
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minutes.LabelVisible = false;
            this.minutes.LineProgressThickness = 8;
            this.minutes.LineThickness = 5;
            this.minutes.Location = new System.Drawing.Point(240, 234);
            this.minutes.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.minutes.MaxValue = 60;
            this.minutes.Name = "minutes";
            this.minutes.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.minutes.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minutes.Size = new System.Drawing.Size(201, 201);
            this.minutes.TabIndex = 3;
            this.minutes.Value = 0;
            // 
            // seconds
            // 
            this.seconds.animated = false;
            this.seconds.animationIterval = 5;
            this.seconds.animationSpeed = 300;
            this.seconds.BackColor = System.Drawing.Color.White;
            this.seconds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seconds.BackgroundImage")));
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seconds.LabelVisible = false;
            this.seconds.LineProgressThickness = 8;
            this.seconds.LineThickness = 5;
            this.seconds.Location = new System.Drawing.Point(461, 234);
            this.seconds.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.seconds.MaxValue = 60;
            this.seconds.Name = "seconds";
            this.seconds.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.seconds.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seconds.Size = new System.Drawing.Size(201, 201);
            this.seconds.TabIndex = 4;
            this.seconds.Value = 0;
            // 
            // lbYears
            // 
            this.lbYears.AutoSize = true;
            this.lbYears.BackColor = System.Drawing.Color.White;
            this.lbYears.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYears.Location = new System.Drawing.Point(77, 97);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(17, 24);
            this.lbYears.TabIndex = 5;
            this.lbYears.Text = "-";
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.White;
            this.lbDays.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDays.Location = new System.Drawing.Point(522, 97);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(17, 24);
            this.lbDays.TabIndex = 6;
            this.lbDays.Text = "-";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.Color.White;
            this.lbHours.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHours.Location = new System.Drawing.Point(71, 316);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(17, 24);
            this.lbHours.TabIndex = 7;
            this.lbHours.Text = "-";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.BackColor = System.Drawing.Color.White;
            this.lbMinutes.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinutes.Location = new System.Drawing.Point(284, 316);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(17, 24);
            this.lbMinutes.TabIndex = 8;
            this.lbMinutes.Text = "-";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BackColor = System.Drawing.Color.White;
            this.lbSeconds.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSeconds.Location = new System.Drawing.Point(504, 316);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(17, 24);
            this.lbSeconds.TabIndex = 9;
            this.lbSeconds.Text = "-";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbMonths
            // 
            this.lbMonths.AutoSize = true;
            this.lbMonths.BackColor = System.Drawing.Color.White;
            this.lbMonths.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMonths.Location = new System.Drawing.Point(284, 97);
            this.lbMonths.Name = "lbMonths";
            this.lbMonths.Size = new System.Drawing.Size(17, 24);
            this.lbMonths.TabIndex = 11;
            this.lbMonths.Text = "-";
            // 
            // months
            // 
            this.months.animated = false;
            this.months.animationIterval = 5;
            this.months.animationSpeed = 300;
            this.months.BackColor = System.Drawing.Color.White;
            this.months.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("months.BackgroundImage")));
            this.months.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.months.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.months.LabelVisible = false;
            this.months.LineProgressThickness = 8;
            this.months.LineThickness = 5;
            this.months.Location = new System.Drawing.Point(240, 18);
            this.months.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.months.MaxValue = 12;
            this.months.Name = "months";
            this.months.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.months.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.months.Size = new System.Drawing.Size(201, 201);
            this.months.TabIndex = 10;
            this.months.Value = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 449);
            this.Controls.Add(this.lbMonths);
            this.Controls.Add(this.months);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.lbYears);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.days);
            this.Controls.Add(this.years);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Your life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar years;
        private Bunifu.Framework.UI.BunifuCircleProgressbar days;
        private Bunifu.Framework.UI.BunifuCircleProgressbar hours;
        private Bunifu.Framework.UI.BunifuCircleProgressbar minutes;
        private Bunifu.Framework.UI.BunifuCircleProgressbar seconds;
        private System.Windows.Forms.Label lbYears;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbMonths;
        private Bunifu.Framework.UI.BunifuCircleProgressbar months;
    }
}

