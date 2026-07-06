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
            dtpDate.Location = new Point(32, 34);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(32, 235);
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
            dateTimePicker1.Location = new Point(33, 178);
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
            tbOut2.Location = new Point(32, 277);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(210, 23);
            tbOut2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
