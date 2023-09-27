using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class Tasks 
    {
        public void Run()
        {
            /* Clase Task / Task<T>
             * Permite crear tareas que correrán en un hilo perteneciente al
             * ThreadPool del proceso. Es la manera recomendada de ejecutar
             * tareas concurrentes/paralelas.
             */

            Task myTask = new Task(TrabajoTask);
            myTask.Start();
            myTask.Wait();

            Task myFactoryTask = Task.Factory.StartNew(() => Console.WriteLine("Tarea creada desde factory"));
            myFactoryTask.Wait();
        }

        private void TrabajoTask()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task {Environment.CurrentManagedThreadId} -> {i}");
            }
        }
    }
}
