using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing proxy application");

            Console.Write("Proxy application loaded. ");

            if (Array.Exists(args, arg =>
                arg.ToLower().Equals("--client") ||
                arg.ToLower().Equals("-c")))
            {
                Console.WriteLine();
                Client(args);
            }
            else
            {
                Console.WriteLine("Type help to view all commands");
            }//Server(args);



            while (true)
            {
                string line = Console.ReadLine();
                switch(line.ToLower())
                {
                    case "client":
                        Client(line.Length >= 6 ? line.Substring(6).Split(' ') : new string[0]);
                        break;
                    case "server":
                        Server(line.Length >= 6 ? line.Substring(6).Split(' ') : new string[0]);
                        break;
                    default:
                        Help(new string[0]);
                        break;
                }
            }
        }

        static void Client(string[] args)
        {
            Console.WriteLine("Client started");
            Console.WriteLine("Client shutting down");
        }

        static void Server(string[] args)
        {
            Console.WriteLine("Server started.");
            Console.WriteLine("Server shutting down.");
        }

        static void Help(string[] args)
        {
            Console.WriteLine(
                "Valid commands:\n" +
                "client - Start the proxy debug client\n" +
                "server - Start the proxy server\n");
        }
    }
}
