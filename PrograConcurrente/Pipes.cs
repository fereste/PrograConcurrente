using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograConcurrente
{
    internal static class Pipes
    {
        public static async Task RunServer()
        {
            await Task.Run(() =>
            {
                using NamedPipeServerStream pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.Out);

                Console.Write("Esperando conexión...");
                pipeServer.WaitForConnection();

                Console.WriteLine("Cliente conectado.");
                try
                {
                    using StreamWriter sw = new StreamWriter(pipeServer);
                    sw.AutoFlush = true;
                    Console.Write("Enter text: ");
                    sw.WriteLine(Console.ReadLine());
                }
                // Catch the IOException that is raised if the pipe is broken
                // or disconnected.
                catch (IOException e)
                {
                    Console.WriteLine("ERROR: {0}", e.Message);
                }
            });
        }

        public static void RunClient()
        {
            using NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.In);

            // Connect to the pipe or wait until the pipe is available.
            Console.Write("Attempting to connect to pipe...");
            pipeClient.Connect();

            Console.WriteLine("Connected to pipe.");
            Console.WriteLine($"There are currently {pipeClient.NumberOfServerInstances} pipe server instances open.");

            using StreamReader sr = new StreamReader(pipeClient);
            // Display the read text to the console
            string temp;
            while ((temp = sr.ReadLine()) != null)
            {
                Console.WriteLine("Received from server: {0}", temp);
            }
        }
    }
}
