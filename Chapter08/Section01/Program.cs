namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptalLocation,str;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");

            while (true) {
                //都道府県の入力 pref
                Console.Write("都道府県：");
                pref = Console.ReadLine();

                if (pref == null) break;    //無限ループを抜ける(Ctrl + 'Z')

                //県庁所在地の入力 prefCaptalLocation
                Console.Write("県庁所在地：");
                prefCaptalLocation = Console.ReadLine();

                //県庁所在地登録処理
                prefOfficeDict[pref] = prefCaptalLocation;
            }

            while (true) {
                var num = menuDisp();
                if (num == 9) break;

                if (num == 1) {
                    foreach (var result in prefOfficeDict) {
                        Console.WriteLine($"{result.Key}の県庁所在地は{result.Value}です。");
                    }
                }
                else if (num == 2) {
                    Console.Write("都道府県：");
                    str = Console.ReadLine();
                    var result = prefOfficeDict.Where(x => x.Key == str)
                        .Select(x => x.Value).FirstOrDefault();

                    if (result != null) {
                        Console.WriteLine($"{str}の県庁所在地は{result}です。");
                    }
                    else {
                        Console.WriteLine("不一致");
                    }
                }
                else {
                    Console.WriteLine("存在しないコマンドです。");
                }
            }
        }

        private static int menuDisp() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write("＞");
            var str = Console.ReadLine();
            var num = int.Parse(str);
            return num;
        }
    }
}
