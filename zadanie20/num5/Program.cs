using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace num5
{
    internal class Program
    {
        private static void Calc(int a)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            int sum = 0;
            int pr = 1;
            int[] mas = new int[4] { 43, 87, 33, 5 };
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                pr *= mas[i];
                Thread.Sleep(490);

                if (pr == 617265 || sum == 617265)
                {
                    cancelTokenSource.Cancel();
                    Console.WriteLine("Число равно 617265");

                }
                Console.WriteLine(sum);
                Console.WriteLine(pr);
            }

        }
        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            new Task(() =>
            {
                Thread.Sleep(400);
                cancelTokenSource.Cancel();
            }).Start();

            try
            {

                Parallel.ForEach<int>(new List<int>() { 43, 87, 33, 5 }, new ParallelOptions { CancellationToken = token }, Calc);

            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция прервана");
            }
            finally
            {
                cancelTokenSource.Dispose();
            }
            Console.ReadLine();
        }
    }
}
