
using static System.Reflection.Metadata.BlobBuilder;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
            #region

            Console.WriteLine("\n7.1.1");
            Exercise1(numbers);

            Console.WriteLine("\n7.1.2");
            Exercise2(numbers);

            Console.WriteLine("\n7.1.3");
            Exercise3(numbers);

            Console.WriteLine("\n7.1.4");
            Exercise4(numbers);

            Console.WriteLine("\n7.1.5");
            Exercise5(numbers);
            #endregion

        }

        private static void Exercise1(int[] numbers) {
            var MaxNumbers = numbers.Max();
            Console.WriteLine(MaxNumbers);
        }

        private static void Exercise2(int[] numbers) {
            foreach (var number in numbers.TakeLast(2)) {
                Console.WriteLine(number);
            }
        }

        private static void Exercise3(int[] numbers) {
            //p173
            foreach(var number in numbers.Select(x => x.ToString("000"))) {
                Console.WriteLine(number);
            }
        }

        private static void Exercise4(int[] numbers) {
            //p175

        }

        private static void Exercise5(int[] numbers) {
            //p174

        }
    }
}
