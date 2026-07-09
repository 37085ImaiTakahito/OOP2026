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
            DateTime birth = dtpDate.Value.Date; 
            DateTime today = DateTime.Now; 
            
            tbOut.Text = $"あなたは{GetAge(birth, today)}歳";

            TimeSpan ts = today - birth;
            tbOut2.Text = $"生まれてから{ts.Days}日目です。";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);
            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は" +
                                $"第{NthWeek(birth)}週の{dayOfWeek}です。";

            //今年の誕生日を作成
            DateTime thisYearBirthday = new DateTime(today.Year, birth.Month, birth.Day);
            //既に誕生日が過ぎたか？
            if(thisYearBirthday < today) {
                //来年の誕生日を作成
                thisYearBirthday = thisYearBirthday.AddYears(1);
            }

            var span = thisYearBirthday - today;

            if(span.Days == 0) {
                tbOut4.Text = "誕生日は今日です";
            }else {
                tbOut4.Text = $"誕生日まであと{span.Days}日です。";
            }
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday,DateTime targetDay) {
            int age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
