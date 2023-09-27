using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class ThreadPoolLimit
    {
        private void Trabajo()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Hola mundo desde {Environment.CurrentManagedThreadId}");
        }

        public void Run()
        {
            Console.WriteLine($"Tamaño ThreadPool -> {ThreadPool.ThreadCount}");
            
            Parallel.Invoke(Enumerable.Repeat(Trabajo, 10).ToArray());

            //ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            //Parallel.Invoke(options, Enumerable.Repeat(Trabajo, 10).ToArray());
        }
    }
}
