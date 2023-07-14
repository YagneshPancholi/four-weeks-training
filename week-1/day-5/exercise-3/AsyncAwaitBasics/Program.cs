using System.Diagnostics;

namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            Console.WriteLine("Enter the number of tasks:");
            int numberOfTasks = int.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();
            await PerformCalculations(numberOfTasks);
            sw.Stop();
            Console.WriteLine($"All tasks completed in {sw.ElapsedMilliseconds} milliseconds");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            // Implement long-running task simulation
            await Task.Delay(delayInSeconds*1000);
            Thread.Sleep(delayInSeconds*1000);
            Console.WriteLine($"Task with {delayInSeconds} seconds delay completed");
        }

        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                tasks[i] = SimulateLongRunningTask(i + 1);
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed");
        }
    }
}