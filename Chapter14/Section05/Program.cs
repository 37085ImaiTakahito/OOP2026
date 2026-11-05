// See https://aka.ms/new-console-template for more information




Console.WriteLine("並列処理あり");
Parallel.For(0, 100, i => {
    Console.WriteLine($"処理{i}開始");
    Thread.Sleep(100);
    
    Console.WriteLine($"処理{i}終了");
});
//Thread.Sleep(3000);
await Task.Delay(3000);
Console.WriteLine();    //改行
Console.WriteLine("並列処理なし");
for (int i = 0; i < 100; i++) {
    Console.WriteLine($"処理{i}開始");
    Thread.Sleep(100);
    
    Console.WriteLine($"処理{i}終了");
}