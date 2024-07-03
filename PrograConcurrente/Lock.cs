using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class Lock
    {
        private object LockObject = new object();

        private int recursoCompartido = 0;

        public async Task Run()
        {
            Task t1 = Task.Factory.StartNew(Trabajo);
            Task t2 = Task.Factory.StartNew(Trabajo);
            Task t3 = Task.Factory.StartNew(Trabajo);
            Task t4 = Task.Factory.StartNew(Trabajo);

            await Task.WhenAll(t1, t2, t3, t4);

            Console.WriteLine(recursoCompartido);
        }

        private void Trabajo()
        {
            lock (LockObject)
            {
                recursoCompartido++;
            }
        }
    }
}
