using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarReportSystem.CarReport;

//
//
namespace CarReportSystem {
    internal class CarReportRepository {
        //全レポートを取得する。Read(SELECT)に相当する
        public List<CarReport> GetAll() {

            var reports = new List<CarReport>();

            using var connection = Database.GetConnection();
            connection.Open();

            //SQLを実行するためのコマンドオブジェクトを作る
            using var command = connection.CreateCommand();

            //テーブルを作るSQL
            command.CommandText =
                """
            SELECT 
                Id,Date,Author,Maker,CarName,Report,Picture
            FROM CarReports
            ORDER BY Id;
            """;

            //SELECTを実行し、複数行の検索結果を読み取る
            using var reader = command.ExecuteReader();

            while (reader.Read()) {
                reports .Add(new CarReport {
                    Id = reader.GetInt32(0),  
                    Date = DateTime.ParseExact(
                        reader.GetString(1),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture),
                    Author = reader.GetString(2),
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = reader.IsDBNull(6) 
                        ? null :  BytesToImage(reader.GetFieldValue<byte[]>(6))
                });
            }
            return reports;
        }

        //商品を1件追加する。Create(INSERT)に相当する
        //戻り値として自動採番されたIdを返す
        public int Add(DateTime date,string author,MakerGroup maker, 
                        string carName,string report, Image? picture) {
            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();

            //DBを開く
            connection.Open();

            //SQLを実行するためのコマンドオブジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText =
                """
            INSERT INTO CarReports 
            (Date, Author, Maker,CarName, Report, Picture)
            VALUES ($date,$author,$maker,$carName,$report,$picture);

            SELECT last_insert_rowid();
            """;

            command.Parameters.AddWithValue("$date",date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$author", author);
            command.Parameters.AddWithValue("$maker", maker);
            command.Parameters.AddWithValue("$carName", carName);
            command.Parameters.AddWithValue("$report", report);
            command.Parameters.AddWithValue("$picture", ImageToBytes(picture));

            //一つの値を返すSQLを実行する
            var result = command.ExecuteScalar();

            if (result is null)
                throw new InvalidOperationException("登録した商品のIDを取得できませんでした");

            //SQLiteのINTEGERはlongとして返るため、intへ変換する
            return Convert.ToInt32((long)result);
        }

        public void Update(CarReport report) {
            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();

            command.CommandText =
                """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = $maker,
                CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$date",report.Date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$author", report.Author);
            command.Parameters.AddWithValue("$maker", report.Maker);
            command.Parameters.AddWithValue("$carName", report.CarName);
            command.Parameters.AddWithValue("$report", report.Report);
            command.Parameters.AddWithValue("$picture",ImageToBytes(report.Picture));
            command.Parameters.AddWithValue("$id", report.Id);

            //更新件数が0なら対象が存在しない
            if (command.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
        }

        public void Delete(int id) {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
            DELETE FROM CarReports
            WHERE  Id = $id;
            """;

            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        private static byte[]? ImageToBytes(Image? image) {
            if (image is null) return null;

            using var stream = new MemoryStream();
            image.Save(stream, image.RawFormat);
            return stream.ToArray();
        }

        private static Image? BytesToImage(byte[]? bytes) {
            if (bytes is null || bytes.Length == 0)
                return null;
            using var stream = new MemoryStream(bytes);
            using var image = Image.FromStream(stream);
            return new Bitmap(image);
        }
    }
}
