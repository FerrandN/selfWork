using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace servcom
{
    internal class Client
    {
        public const int PORT = 8085;
        public const string IP = "127.0.0.1";
        private TcpClient tcpClient { get; set; }
        public Client()
        {
            tcpClient = new TcpClient(); // ON OUVRE UN LISTENET SUR LE PORT 8085
        }
        public void Send(string str)
        {
            tcpClient.Connect(IP, PORT);
            Console.Write("Envoi de " + str);
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] strToByte = asen.GetBytes(str);
            Stream stm = tcpClient.GetStream();
            stm.Write(strToByte);
            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);
            Console.Write("\n");
            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));
            tcpClient.Close();
        }
    }
}