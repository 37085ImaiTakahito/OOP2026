namespace Section01 {
    internal class Program {

        public delegate bool judgement(int value);

        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var exists = cities.FindAll(s => s.Length >= 6 && s.EndsWith("n") && s.Contains("o") );
            exists.ForEach(s=>Console.WriteLine(s));

        }



    }
}
