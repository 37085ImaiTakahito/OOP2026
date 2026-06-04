namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var obj = new YearMonth(2020, 12);
            Console.WriteLine(obj);
            Console.WriteLine(obj.AddOneMonth());
            Console.WriteLine(obj.ToString());

        }
    }


}
