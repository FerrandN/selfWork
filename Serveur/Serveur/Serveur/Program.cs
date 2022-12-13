using System.Net;
using System.Net.Sockets;
using System.Text;

string request = "GET/HTTP/1.1\r\n\r\n";

try
{
/*  La classe Socket prends en paramètre de son constructeur 3 données:

    AddressFamily: renseigne sur le modèle d'adresse utilisé par la socket.
    SocketType: indique le type de socket à utiliser: Stream, Row, DGram, etc...
    ProtocolType: spécifie les protocoles pris en charge par la socket.
*/
    Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    /*
     * La méthode SetSocketOption permet de d'affecter une valeur à une option en précisant en premier argument le niveau auquel s'applique l'option,
     * en second le nom de l'option et en troisième la valeur de cette option. Ici, c'est l'option de timeout en réception qui a été initialisée à 3 secondes 
     * (un appel de réception de données bloquant plus de 3 secondes génèrera une SocketException).
     * 
     * Les méthodes Send et Receive sont explicit, elles servent respectivement à l'envoi et la réception de données sous forme de tableau de byte.
     * 
     * Il existe des méthodes d'envoi de réception et de connexions dites asynchrones, elle seront détaillées au chapitre suivant dans la classe TcpClient.
     */

    clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);

    clientSocket.Connect(new IPEndPoint(Dns.GetHostByName("www.free.fr").AddressList[0], 80));

    int count = clientSocket.Send(Encoding.ASCII.GetBytes(request), 0, request.Length, SocketFlags.None);

    Console.WriteLine("Nombre d'octets envoyes : " + count);

    byte[] buffer = new byte[1024];

    count = clientSocket.Receive(buffer, 0, 1024, SocketFlags.None);

    Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, count));

    clientSocket.Close();
}
catch (Exception e)
{
    Console.Error.WriteLine(e.Message);
}