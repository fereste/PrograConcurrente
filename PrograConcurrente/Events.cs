using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class Events
    {
        public async Task Run()
        {
            Console.WriteLine($"Thread principal {Environment.CurrentManagedThreadId}");

            EventManager em = new EventManager();
            em.MyEvent += (sender, args) => Console.WriteLine($"Disparamos evento en {Environment.CurrentManagedThreadId}");

            await Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"Thread del Task {Environment.CurrentManagedThreadId}");
                em.FireEvent();
            });
        }
    }

    public class EventManager
    {
        public event EventHandler MyEvent;

        public void FireEvent()
        {
            MyEvent(this, null);
        }
    }
}
