namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"date\sales.csv");
            //var sales = new SalesCounter(SalesCounter.ReadSales(@"date\sales.csv"));

            Dictionary<string, int> amountParStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in amountParStore) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
        }
    }
}
