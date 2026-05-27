
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            Console.WriteLine(" --- 4.1.1 --- ");

            //foreach文
            Console.WriteLine("foreach文で出力");
            foreach(string l in langs) {
                if (l.Contains("S")) {
                    Console.WriteLine(l);
                }
            }
            //for文
            Console.WriteLine("\nfor文で出力");
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains("S")) {
                    Console.WriteLine(langs[i]);
                }
            }
            //while文
            Console.WriteLine("\nwhile文で出力");
            int w = 0;
            while (w < langs.Count) {
                if (langs[w].Contains("S")) {
                    Console.WriteLine(langs[w]);
                }
                w++;
            }
        }

        private static void Exercise2(List<string> langs) {
            //LINQを使用する(Where)
            var exists = langs.Where(a => a.Contains("S"));
            foreach(string s in exists) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise3(List<string> langs) {
            var exists = langs.Find(x => x.Length == 10) ;
            if (exists is null) {
                Console.WriteLine("unknown");
            }
            else {
               // foreach (var s in exists) {
                    Console.WriteLine(exists);
               // }
            }

            
        }

    }
}
