using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal class Sincronizacion
    {
        /*
         Otros mecanismos de sincronización         
         */
        public void Run()
        {
            // Semáforo común (contador)
            Semaphore sem = new Semaphore(initialCount: 1, maximumCount: 3);
            sem.WaitOne();
            sem.Release();

            // Semáforos para lectura/escritura
            ReaderWriterLock rwLock = new ReaderWriterLock();
            rwLock.AcquireReaderLock(5000);
            rwLock.ReleaseReaderLock();

            rwLock.AcquireWriterLock(5000);
            rwLock.ReleaseWriterLock();

            // Patrón barrera
            Barrier barrier = new Barrier(5);
            barrier.SignalAndWait();
        }
    }
}
