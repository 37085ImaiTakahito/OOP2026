using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //nudDay
        private void button1_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpDate.Value;
            tbOut.Text = dt1.AddDays((double)nudDay.Value).ToString();

        }

        private void button2_Click(object sender, EventArgs e) {
            DateTime birth = dtpDate.Value; //
            DateTime today = DateTime.Today; //

            int age = today.Year - birth.Year;
            if(today < birth.AddYears(age)) {
                age--;
            }
            tbOut.Text = $"‚ ‚È‚½‚Í{age}Î";

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"¶‚Ü‚ê‚Ä‚©‚ç{ts.Days}“ú–Ú‚Å‚·B";
        }
    }
}
