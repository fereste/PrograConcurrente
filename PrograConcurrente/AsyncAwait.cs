using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class AsyncAwait
    {
        private int a = 0;

        public async Task Run()
        {
            Console.WriteLine($"a -> {a}");
            await RunSomeTaskAsync();
            
            //Task task = RunSomeTaskAsync();
            //await task;
            Console.WriteLine($"a -> {a}");

            int result = await AddValuesAsync(1, 2, 3 ,4);
            Console.WriteLine($"result -> {result}");
        }

        private async Task RunSomeTaskAsync()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 5; i++)
                {
                    a++;
                }
                await Task.Delay(100);
            });
        }

        private async Task<int> AddValuesAsync(params int[] ints)
        {
            return await Task.Run(() =>
            {
                int result = 0;
                foreach (int value in ints)
                {
                    result += value;
                }
                return result;
            });
        }
    }
}
