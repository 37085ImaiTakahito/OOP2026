namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            dtpDate = new DateTimePicker();
            tbOut = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbOut4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 27);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 0;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(43, 181);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(89, 230);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(199, 23);
            tbOut.TabIndex = 2;
            tbOut.Text = "計算";
            // 
            // nudDay
            // 
            nudDay.Location = new Point(32, 84);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 23);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 86);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(276, 178);
            button2.Name = "button2";
            button2.Size = new Size(95, 33);
            button2.TabIndex = 6;
            button2.Text = "計算";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(89, 259);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(210, 23);
            tbOut2.TabIndex = 7;
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(89, 288);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(225, 23);
            tbOut3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 238);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 9;
            label2.Text = "年齢";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 267);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "経過日数";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 297);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "メモ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 157);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "生年月日";
            // 
            // tbOut4
            // 
            tbOut4.Location = new Point(89, 317);
            tbOut4.Name = "tbOut4";
            tbOut4.Size = new Size(240, 23);
            tbOut4.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut);
            Controls.Add(dtpDate);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpDate;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private TextBox tbOut2;
        private TextBox tbOut3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbOut4;
    }
}
