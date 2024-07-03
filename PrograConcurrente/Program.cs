namespace PrograConcurrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programación concurrente");
                Console.WriteLine("1. Thread.");
                Console.WriteLine("2. Task.");
                Console.WriteLine("3. async/await.");
                Console.WriteLine("4. ThreadPool limits.");
                Console.WriteLine("5. Pipes. Servidor.");
                Console.WriteLine("6. Pipes. Cliente.");
                Console.WriteLine("7. Sincronización.");
                Console.WriteLine("8. Eventos.");
                Console.WriteLine("9. EF async.");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8": break;
                    case "9": break;
                }
            }
            // new Threads().Run();
            // new Tasks().Run();
            // new AsyncAwait().Run().Wait();
            //new ThreadPoolLimit().Run();
            //new EfAsync().Run().Wait();
            // Pipes.RunServer();
            // Pipes.RunClient();
            //new Lock().Run().Wait();
            // no correr - Sincronizacion
            //new Events().Run().Wait();

            Console.WriteLine("Listo");
            Console.ReadLine();
        }
    }
}