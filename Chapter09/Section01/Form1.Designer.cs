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
            label1 = new Label();
            ボタン = new Button();
            tbOutput = new TextBox();
            nudNum1 = new NumericUpDown();
            nudNum2 = new NumericUpDown();
            pbBox = new PictureBox();
            ボタン2 = new Button();
            ofdOpen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nudNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Chapter09";
            // 
            // ボタン
            // 
            ボタン.Location = new Point(38, 134);
            ボタン.Name = "ボタン";
            ボタン.Size = new Size(214, 105);
            ボタン.TabIndex = 1;
            ボタン.Text = "ボタン";
            ボタン.UseVisualStyleBackColor = true;
            ボタン.Click += ボタン_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(38, 271);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(310, 23);
            tbOutput.TabIndex = 2;
            // 
            // nudNum1
            // 
            nudNum1.Location = new Point(38, 84);
            nudNum1.Name = "nudNum1";
            nudNum1.Size = new Size(120, 23);
            nudNum1.TabIndex = 3;
            // 
            // nudNum2
            // 
            nudNum2.Location = new Point(228, 84);
            nudNum2.Name = "nudNum2";
            nudNum2.Size = new Size(120, 23);
            nudNum2.TabIndex = 3;
            // 
            // pbBox
            // 
            pbBox.Image = Properties.Resources.losSanta_Monica_3;
            pbBox.Location = new Point(418, 113);
            pbBox.Name = "pbBox";
            pbBox.Size = new Size(314, 246);
            pbBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBox.TabIndex = 4;
            pbBox.TabStop = false;
            // 
            // ボタン2
            // 
            ボタン2.Location = new Point(454, 84);
            ボタン2.Name = "ボタン2";
            ボタン2.Size = new Size(75, 23);
            ボタン2.TabIndex = 5;
            ボタン2.Text = "開く...";
            ボタン2.UseVisualStyleBackColor = true;
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            ofdOpen.FileOk += ofdOpen_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ボタン2);
            Controls.Add(pbBox);
            Controls.Add(nudNum2);
            Controls.Add(nudNum1);
            Controls.Add(tbOutput);
            Controls.Add(ボタン);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ボタン;
        private TextBox tbOutput;
        private NumericUpDown nudNum1;
        private NumericUpDown nudNum2;
        private PictureBox pbBox;
        private Button ボタン2;
        private OpenFileDialog ofdOpen;
    }
}
