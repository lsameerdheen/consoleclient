namespace consoleclient;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

           
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! - client");
        TcpClient client = new TcpClient("127.0.0.1", 5555);
        NetworkStream stream = client.GetStream();
           using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                String response = null ;
                do{
                Console.WriteLine("Write something to send to server:");
                String input = Console.ReadLine();
                writer.WriteLine(input);
                writer.Flush();
              
                response = reader.ReadLine();
                Console.WriteLine("Server said: {0}", response);  
                Boolean status = response !=null &&  response  != "see you!!";              
                Console.WriteLine("Connection status", status);  
                }while(response !=null &&  response  != "see you!!");
            }
          
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

    }
}
