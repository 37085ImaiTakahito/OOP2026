using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            //dgvRecords.DateSource = listCarReports;
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pictureBox1.Image, //pbPicture
                
            };
            listCarReports.Add(carReport);

        }
    }
}
