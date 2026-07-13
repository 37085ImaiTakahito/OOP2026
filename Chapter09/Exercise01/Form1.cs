namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender,EventArgs e) {
            var dateTime = DateTime.Now;

            tbOut1.Text = string.Format($"{dateTime:yyyy/MM/dd HH:mm}");
        }

        private void btButton2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            tbOut2.Text = dateTime.ToString($"{dateTime:yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b}");
        }

        private void btButton3_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;

            //var culture = new CultureInfo()
        }

    }
}
