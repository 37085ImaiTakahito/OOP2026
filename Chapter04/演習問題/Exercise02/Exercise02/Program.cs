
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用
            Console.Write("文字を入力：");
            var langs = Console.Read();
            if(langs < 0) {
                Console.WriteLine(langs);
            }else if(langs < 100){
                Console.WriteLine(langs * 2);
            }else if(langs < 500) {
                Console.WriteLine(langs * 3);
            }
            else {
                Co
            }
        }

        private static void Exercise2() {
            //switch文を使用

        }

        private static void Exercise3() {
            //switch式を使用


        }
    }
}
