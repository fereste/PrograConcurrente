using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class Threads 
    {
        public void Run()
        {
            /* Clase Thread
             * Es la manera más simple y básica de crear hilos (threads) que permitan ejecutar tareas
             * de forma concurrente/paralela.
             */

            Console.WriteLine("Soy el hilo principal");

            Thread thread1 = new Thread(TrabajoThread1); // { IsBackground = true };
            Thread thread2 = new Thread(TrabajoThread2);

            thread1.Start();
            thread2.Start(DateTime.Now.ToShortTimeString());

            Console.WriteLine($"Esperando hilo 1 ({thread1.ManagedThreadId})");
            thread1.Join();

            Console.WriteLine($"Esperando hilo 2 ({thread1.ManagedThreadId})");
            thread2.Join();
        }

        private void TrabajoThread1()
        {
            Console.WriteLine($"Soy el hilo {Environment.CurrentManagedThreadId}");
            Thread.Sleep(1000);
        }

        private void TrabajoThread2(object args)
        {
            string param1 = (string)args;
            Console.WriteLine($"Soy el hilo {Environment.CurrentManagedThreadId} con el parámetro {param1}");
            Thread.Sleep(1500);
        }
    }
}
