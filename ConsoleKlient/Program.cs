using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConsoleKlient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kliknij by rozpocząć");
            Console.ReadLine();
            TcpClient klient = new TcpClient("127.0.0.1", 1243);
            NetworkStream ns = klient.GetStream();
            BinaryWriter writer = new BinaryWriter(ns);
            BinaryReader reader = new BinaryReader(ns);
            string buffor = reader.ReadString();
            if (buffor == "##AUTH##")
            {
                Console.WriteLine("ODBERANO:" + buffor);
                writer.Write("##AUTH##RAIK");
            }
            
            while (buffor != "##EXIT##")
            {
                buffor = Console.ReadLine();
                writer.Write(buffor);
            }
            Console.WriteLine("WYSLANO PROSBE O ROZLACZENIE");
            Console.ReadLine();
        }
    }
}
