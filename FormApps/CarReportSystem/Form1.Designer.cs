namespace CarReportSystem {
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
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbYunyuu = new RadioButton();
            rbSubalu = new RadioButton();
            rbHonda = new RadioButton();
            rbNIssan = new RadioButton();
            rbToyota = new RadioButton();
            cbAuthor = new ComboBox();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            dgvRecords = new DataGridView();
            tbReport = new TextBox();
            label6 = new Label();
            bt = new Button();
            label7 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDeleteRecord = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            ファイルAToolStripMenuItem = new ToolStripMenuItem();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(117, 42);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(240, 39);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(25, 163);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbYunyuu);
            groupBox1.Controls.Add(rbSubalu);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNIssan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(117, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 53);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 11.25F);
            rbOther.Location = new Point(340, 19);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(65, 24);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbYunyuu
            // 
            rbYunyuu.AutoSize = true;
            rbYunyuu.Font = new Font("Yu Gothic UI", 11.25F);
            rbYunyuu.Location = new Point(262, 19);
            rbYunyuu.Name = "rbYunyuu";
            rbYunyuu.Size = new Size(72, 24);
            rbYunyuu.TabIndex = 0;
            rbYunyuu.TabStop = true;
            rbYunyuu.Text = "輸入車";
            rbYunyuu.UseVisualStyleBackColor = true;
            // 
            // rbSubalu
            // 
            rbSubalu.AutoSize = true;
            rbSubalu.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubalu.Location = new Point(194, 19);
            rbSubalu.Name = "rbSubalu";
            rbSubalu.Size = new Size(62, 24);
            rbSubalu.TabIndex = 0;
            rbSubalu.TabStop = true;
            rbSubalu.Text = "スバル";
            rbSubalu.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(127, 19);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(62, 24);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNIssan
            // 
            rbNIssan.AutoSize = true;
            rbNIssan.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNIssan.Location = new Point(64, 19);
            rbNIssan.Name = "rbNIssan";
            rbNIssan.Size = new Size(57, 24);
            rbNIssan.TabIndex = 0;
            rbNIssan.TabStop = true;
            rbNIssan.Text = "日産";
            rbNIssan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(6, 18);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(62, 25);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(117, 101);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(295, 40);
            cbAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(42, 216);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(117, 216);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(240, 40);
            cbCarName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(21, 280);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // dgvRecords
            // 
            dgvRecords.AccessibleName = "";
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(117, 431);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(719, 292);
            dgvRecords.TabIndex = 4;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(117, 280);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(382, 134);
            tbReport.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(42, 431);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // bt
            // 
            bt.BackColor = SystemColors.ActiveCaption;
            bt.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bt.Location = new Point(369, 40);
            bt.Name = "bt";
            bt.Size = new Size(127, 41);
            bt.TabIndex = 6;
            bt.Text = "新規入力";
            bt.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(538, 47);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = SystemColors.ActiveCaption;
            btPicOpen.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btPicOpen.Location = new Point(623, 42);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(116, 38);
            btPicOpen.TabIndex = 6;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = false;
            // 
            // btPicDelete
            // 
            btPicDelete.BackColor = Color.LightCoral;
            btPicDelete.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btPicDelete.Location = new Point(745, 43);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(91, 38);
            btPicDelete.TabIndex = 6;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = false;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = SystemColors.ActiveCaption;
            btAddRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.Location = new Point(538, 358);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(94, 56);
            btAddRecord.TabIndex = 6;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = Color.Khaki;
            btModifyRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyRecord.Location = new Point(650, 358);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(94, 56);
            btModifyRecord.TabIndex = 7;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.LightCoral;
            btDeleteRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.Location = new Point(764, 358);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(72, 56);
            btDeleteRecord.TabIndex = 8;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(538, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 253);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルAToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(916, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルAToolStripMenuItem
            // 
            ファイルAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルAToolStripMenuItem.Name = "ファイルAToolStripMenuItem";
            ファイルAToolStripMenuItem.Size = new Size(67, 20);
            ファイルAToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(163, 22);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(163, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(163, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(160, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(163, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(160, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(163, 22);
            終了ToolStripMenuItem.Text = "終了(X)     Alt+F4";
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(164, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 743);
            Controls.Add(pictureBox1);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btPicDelete);
            Controls.Add(btAddRecord);
            Controls.Add(btPicOpen);
            Controls.Add(bt);
            Controls.Add(tbReport);
            Controls.Add(dgvRecords);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbYunyuu;
        private RadioButton rbSubalu;
        private RadioButton rbHonda;
        private RadioButton rbNIssan;
        private RadioButton rbToyota;
        private ComboBox cbAuthor;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private DataGridView dgvRecords;
        private TextBox tbReport;
        private Label label6;
        private Button bt;
        private Label label7;
        private Button btPicOpen;
        private Button btPicDelete;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDeleteRecord;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルAToolStripMenuItem;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
    }
}
