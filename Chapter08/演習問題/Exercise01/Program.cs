
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Console.WriteLine("問題8.1.1");
            Exercise1(text);
            Console.WriteLine();
            Console.WriteLine("問題8.1.2");
            Exercise2(text);
            Console.WriteLine();
        }

        private static void Exercise1(string text) {
            //コミットコメント（問題８．１.１完成）
            var dict = new Dictionary<char, int>();
            foreach(char c in text.ToUpper()) {
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c)) {
                        dict[c]++;
                    }
                    else {
                        dict[c] = 1;
                    }
                }
            }
            foreach (var d in dict.OrderBy(x => x.Key)) {
                Console.WriteLine($"{d.Key} {d.Value}");
            }
        }

        private static void Exercise2(string text) {
            //コミットコメント（問題8.1.2完成）
            var dict = new SortedDictionary<char, int>();
            foreach (char c in text.ToUpper()) {
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c)) {
                        dict[c]++;
                    }
                    else {
                        dict[c] = 1;
                    }
                }
            }
            foreach (var d in dict) {
                Console.WriteLine($"{d.Key} {d.Value}");
            }
        }
    }
}
