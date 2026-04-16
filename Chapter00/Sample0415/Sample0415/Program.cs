namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("要素数：");
            string? mozi = Console.ReadLine();
            int suu = int.Parse(mozi);
            int[] hai = new int[suu];
            int sum = 0;

            Console.WriteLine("入力：");
            for (int i = 0; i < hai.Length; i++)
            {
                Console.Write("array[" + i + "]:");
                hai[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine("集計：");
            //for (int i = 0; i < hai.Length; i++)
            //{
            //    sum += hai[i];
            //}

            Console.WriteLine("出力：");
            for (int i = 0; i < hai.Length; i++)
            {
                Console.Write("array[" + i + "]:");
                int v = hai[i];
                astOut(v);
            }

            Console.WriteLine("合計：" + hai.Where(n => n % 2 == 0).Sum());
        }

        static void astOut(int num)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
