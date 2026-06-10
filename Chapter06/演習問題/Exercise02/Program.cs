namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("1:");
            var str1 = Console.ReadLine();
            int num;
            int.TryParse(str1,out num);
            var str2 = num.ToString("#,0");
            Console.WriteLine(str2);
        }
    }
}
