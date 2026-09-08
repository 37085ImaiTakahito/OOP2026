using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    internal class Database {
        //DBファイルの保存場所
        private static readonly string DatabasePath =
            Path.Combine(AppContext.BaseDirectory, "carreport.db");

        //SQLiteへ接続するための接続文字列
        private static readonly string ConnectionString =
            $"Data Source={DatabasePath}";

        //DBファイルの保存場所を外部から確認するための読み取り専用プロパティ
        public static string FilePath => DatabasePath;

        //新しいSQLiteConnectionを生成して返す
        public static SqliteConnection GetConnection() {
            return new SqliteConnection(ConnectionString);
        }

        //DBの初期化処理
        public static void Initialize() {
            //接続オブジェクトを生成する
            using var connection = GetConnection();

            //DBを開く
            connection.Open();

            //SQLを実行するためのコマンドオブジェクトを作る
            using var command = connection.CreateCommand();

            //Productテーブルを作るSQL
            //IF NOT EXISTSにより、既にテーブルがあってもエラーにならない
            command.CommandText =
                """
            CREATE TABLE IF NOT EXISTS Products(
                Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                Name    TEXT NOT NULL,
                Price   INTEGER NOT NULL CHECK (Price >= 0)
            );
            """;

            //結果行を返さないSQLを実行する
            command.ExecuteNonQuery();
        }
    }
}

