
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

        //p89~90参考
        private static void Exercise1() {
            //if-else文を使用 (コード4.9)
            Console.Write("文字を入力：");
            var lang = Console.ReadLine(); //int langs = int.Parse(lang);
            if (int.TryParse(lang, out var langs)) {
                if (langs < 0) {
                    Console.WriteLine(langs);
                }
                else if (langs < 100) {
                    Console.WriteLine(langs * 2);
                }
                else if (langs < 500) {
                    Console.WriteLine(langs * 3);
                }
                else {
                    Console.WriteLine(langs);
                }
            }else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise2() {
            //switch文を使用 (コード4.10)
            Console.Write("文字を入力：");
            var langs = Console.ReadLine(); 
            if (int.TryParse(langs, out var num)) {
                switch (num) {
                    case < 0:
                        Console.WriteLine(num);
                        break;
                    case < 100:
                        Console.WriteLine(num * 2);
                        break;
                    case < 500:
                        Console.WriteLine(num * 3);
                        break;
                    default:
                        Console.WriteLine(num);
                        break;
                }
            }
            else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise3() {
            //switch式を使用　(コード4.11)
            Console.Write("文字を入力：");
            var langs = Console.ReadLine();
            if (int.TryParse(langs, out var num)) {
                var text = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _ => num
                };
                Console.WriteLine(text);
            }
            else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }
    }
}
