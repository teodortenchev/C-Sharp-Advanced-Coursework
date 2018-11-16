using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    class TCPServer
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[10];
            var listener = new TcpListener(IPAddress.Loopback, 3080);
            listener.Start();

            Console.WriteLine("TCP Server listening on port 3080");
            while (true)
            {
                using(var stream = listener.AcceptTcpClient().GetStream())
                {
                    int readBytes = stream.Read(buffer, 0, buffer.Length);

                    while (readBytes != 0)
                    {
                        Console.Write(Encoding.UTF8.GetString(buffer, 0, readBytes));
                        
                        readBytes = stream.Read(buffer, 0, buffer.Length);

                    }
                    stream.Write(Encoding.UTF8.GetBytes("Data received!"));
                    Console.WriteLine();
                }
            }
        }
    }
}
