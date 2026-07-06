using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpDate.Value;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var strDate = dt1.ToString("ggyy”NMŒŽd“ú",culture);
            tbOut.Text = strDate;

        }

    }
}
