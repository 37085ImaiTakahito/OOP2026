using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var sb = new StringBuilder();
            foreach(var word in GetWords()) {
                sb.Append(word);
            }
            Console.WriteLine(sb);

            var result = String.Join(",", GetWords());
            Console.WriteLine(result);

        }

        private static IEnumerable<object> GetWords() {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}
