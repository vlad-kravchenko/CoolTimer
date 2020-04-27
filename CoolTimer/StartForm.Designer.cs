namespace CoolTimer
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.lbLimit = new System.Windows.Forms.Label();
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(12, 12);
            this.date.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(132, 20);
            this.date.TabIndex = 0;
            this.date.Value = new System.DateTime(1995, 7, 13, 0, 0, 0, 0);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(256, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(150, 12);
            this.time.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.time.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(118, 20);
            this.time.TabIndex = 2;
            this.time.Value = new System.DateTime(2019, 8, 24, 21, 0, 0, 0);
            // 
            // lbLimit
            // 
            this.lbLimit.AutoSize = true;
            this.lbLimit.Location = new System.Drawing.Point(13, 39);
            this.lbLimit.Name = "lbLimit";
            this.lbLimit.Size = new System.Drawing.Size(196, 13);
            this.lbLimit.TabIndex = 3;
            this.lbLimit.Text = "How much are you going to live? (years)";
            // 
            // cbLimit
            // 
            this.cbLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.Location = new System.Drawing.Point(215, 36);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(53, 21);
            this.cbLimit.TabIndex = 4;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 94);
            this.Controls.Add(this.cbLimit);
            this.Controls.Add(this.lbLimit);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "Enter your birth day and time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label lbLimit;
        private System.Windows.Forms.ComboBox cbLimit;
    }
}