// This is nothing special, just trying out the Periodic Timer in .NET 6

using System.Diagnostics;

using var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
Stopwatch sw = Stopwatch.StartNew();
while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}ms");
    await Task.Delay(500);
}