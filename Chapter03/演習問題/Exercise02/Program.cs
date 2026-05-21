
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            #region
            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_1(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.2 *****");
            Exercise2_2(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.3 *****");
            Exercise2_3(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.4 *****");
            Exercise2_4(cities);
            Console.WriteLine();
            #endregion
        }

        private static void Exercise2_1(List<string> cities) {
            Console.Write("都市名を入力。空行で終了");
            var name = Console.ReadLine();
            var exists = cities.FindIndex(s => s.Equals( name));
            Console.WriteLine(exists);
        }

        private static void Exercise2_2(List<string> cities) {
            var query = cities.Count(s => s.Contains("o"));
            Console.WriteLine(query);
        }

        private static void Exercise2_3(List<string> cities) {
            IEnumerable<string> query = cities.Where(s => s.Contains("o")).ToArray();
            foreach (string s in query) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> cities) {
            
            var query = cities.Select(s => s.StartsWith('B'));
            var sele = query.Where(s => query.Count('B'));
        }//p135
    }
}
