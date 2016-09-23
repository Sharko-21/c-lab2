using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nerwork.Library;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Nerwork.Library.client start = new Nerwork.Library.client();
            Nerwork.Library.server open = new Nerwork.Library.server();

            var ResponseArray = new string[3];
            ResponseArray = start.Client();

            open.Server(false, ResponseArray);
            Console.Read();

        }
    }
}
