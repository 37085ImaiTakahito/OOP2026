namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ƒ{ƒ^ƒ“_Click(object sender, EventArgs e) {
            var num = nudNum1.Value + nudNum2.Value;
            tbOutput.Text = num.ToString();
        }

        private void ofdOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            ofdOpen.ShowDialog();
            
        }
    }
}
