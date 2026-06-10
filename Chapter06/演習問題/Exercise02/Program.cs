using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("1:");
            var str1 = Console.ReadLine();

            if(int.TryParse(str1, out var num)) {
                Console.WriteLine($"{num:#,0}");
            }
            else {
                Console.WriteLine("整数文字列ではありあせん");
            }
            
            
        }
    }
}
