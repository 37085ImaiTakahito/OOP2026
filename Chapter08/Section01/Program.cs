namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");

            while (true) {
                //都道府県の入力 pref
                Console.Write("都道府県：");
                pref = Console.ReadLine();

                if (pref == null) break;    //無限ループを抜ける(Ctrl + 'Z')

                //県庁所在地の入力 prefCaptalLocation
                Console.Write("県庁所在地：");
                prefCaptalLocation = Console.ReadLine();

                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") continue;
                }

                //県庁所在地登録処理
                prefOfficeDict[pref] = prefCaptalLocation;
                Console.WriteLine();
            }

            Boolean endFlag = false;
            while (true) {
                switch (menuDisp()) {
                    case 1:
                        allDisp();
                        break;

                    case 2:
                        searchPrefCaptalLocation();
                        break;

                    default:
                        endFlag = true;
                        break;
                }
                Console.WriteLine();
            }
        }

        //メニュー表示
        private static int menuDisp() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write("＞");
            var num = int.Parse(Console.ReadLine());
            return num;
        }

        //一覧表示処理
        private static void allDisp() {
            foreach (var result in prefOfficeDict) {
                Console.WriteLine($"{result.Key}の県庁所在地は{result.Value}です。");
            }
        }

        //検索処理
        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県：");
            var str = Console.ReadLine();
            if (str is null) return;

            if (prefOfficeDict.ContainsKey(str)) {
                Console.WriteLine($"{str}の県庁所在地は{prefOfficeDict[str]}です。");
            }
        }

    }
}
