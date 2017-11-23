namespace Test
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxText1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProcessTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFunctionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxText2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxLogFileName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 61);
            this.button1.TabIndex = 31;
            this.button1.Text = "LOG 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Text 1";
            // 
            // textBoxText1
            // 
            this.textBoxText1.Location = new System.Drawing.Point(644, 63);
            this.textBoxText1.Name = "textBoxText1";
            this.textBoxText1.Size = new System.Drawing.Size(132, 20);
            this.textBoxText1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Process Time";
            // 
            // textBoxProcessTime
            // 
            this.textBoxProcessTime.Location = new System.Drawing.Point(513, 63);
            this.textBoxProcessTime.Name = "textBoxProcessTime";
            this.textBoxProcessTime.Size = new System.Drawing.Size(125, 20);
            this.textBoxProcessTime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Function Name";
            // 
            // textBoxFunctionName
            // 
            this.textBoxFunctionName.Location = new System.Drawing.Point(12, 63);
            this.textBoxFunctionName.Name = "textBoxFunctionName";
            this.textBoxFunctionName.Size = new System.Drawing.Size(125, 20);
            this.textBoxFunctionName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type Status";
            // 
            // comboBoxTypeStatus
            // 
            this.comboBoxTypeStatus.FormattingEnabled = true;
            this.comboBoxTypeStatus.Items.AddRange(new object[] {
            "",
            "START",
            "END",
            "REPORT"});
            this.comboBoxTypeStatus.Location = new System.Drawing.Point(143, 63);
            this.comboBoxTypeStatus.Name = "comboBoxTypeStatus";
            this.comboBoxTypeStatus.Size = new System.Drawing.Size(102, 21);
            this.comboBoxTypeStatus.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 208);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "yyyymmdd_hhmmss :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "yyyyMMdd_HHmmss :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "From";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(251, 63);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(125, 20);
            this.textBoxFrom.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "To";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(382, 63);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(125, 20);
            this.textBoxTo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(819, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Text 2";
            // 
            // textBoxText2
            // 
            this.textBoxText2.Location = new System.Drawing.Point(782, 63);
            this.textBoxText2.Name = "textBoxText2";
            this.textBoxText2.Size = new System.Drawing.Size(126, 20);
            this.textBoxText2.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Log File Name";
            // 
            // comboBoxLogFileName
            // 
            this.comboBoxLogFileName.FormattingEnabled = true;
            this.comboBoxLogFileName.Items.AddRange(new object[] {
            "",
            "Operation",
            "SQL",
            "Connection",
            "Display"});
            this.comboBoxLogFileName.Location = new System.Drawing.Point(12, 23);
            this.comboBoxLogFileName.Name = "comboBoxLogFileName";
            this.comboBoxLogFileName.Size = new System.Drawing.Size(102, 21);
            this.comboBoxLogFileName.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 61);
            this.button3.TabIndex = 45;
            this.button3.Text = "NEW LOG";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 251);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxLogFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxText2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxText1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProcessTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFunctionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypeStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxText1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProcessTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFunctionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxText2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxLogFileName;
        private System.Windows.Forms.Button button3;
    }
}

