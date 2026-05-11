namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"date\sales.csv");

            var amountParStore = sales.GetPerStoreSales();
 
            foreach (var obj in amountParStore) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            } 
        }
    }
}
