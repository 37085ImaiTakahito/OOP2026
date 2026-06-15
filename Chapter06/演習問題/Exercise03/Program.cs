
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            int count = text.Count(c => c == ' ');
            Console.WriteLine($"空白数：{count}");
        }

        private static void Exercise2(string text) {
            Console.Write("検索：");
            var str1 = Console.ReadLine();
            Console.Write("置換：");
            var str2 = Console.ReadLine();

            var rep = text.Replace(str1,str2);
            Console.WriteLine(rep);
        }

        private static void Exercise3(string text) {
            //あとまわし
            var sb = new StringBuilder();
            foreach (var word in text) {
                sb.Append(word);
            }
            Console.WriteLine(sb);
        }

        private static void Exercise4(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine($"単語数：{count}");
        }

        private static void Exercise5(string text) {
            var str1 = text.Split(' ').Where(s => s.Length <= 4);
            foreach(var s in str1) {
                Console.WriteLine(s);
            }
        }

        //アルファべトの数をカウントして表示
        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ", " ");

            //辞書（ディクショナリ）を使った集計
            var alphDicCount = Enumerable.Range('a', 26).
                ToDictionary(num => ((char)num),num => 0);

            //var dict = new SortedDictionary<char, int>();
            foreach(var c in str) {
                if(alphDicCount.ContainsKey(c))
                    alphDicCount[c]++;
                else
                    alphDicCount[c] = 1;
            }

            foreach (var word in alphDicCount) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }

            Console.WriteLine();

            //配列を用いた集計
            var array = Enumerable.Repeat(0, 26).ToArray();
            foreach(var alph in str) {
                if (alph >= 'a' && alph <= 'z') {
                    array[alph - 'a']++;
                }
            }

            for (char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }

            //aから順にカウントして集計
            for (char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{str.Count(c => c == ch)}");
            }
        }
    }
}
