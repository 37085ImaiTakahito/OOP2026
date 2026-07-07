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

            var age = GetAge(birth, today);
            tbOut.Text = $"あなたは{age}歳";

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です。";
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday,DateTime targetDay) {
            int age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
