using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOPTask11C
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Public\Json\client.json";
            List<Client> clients = new List<Client>();
            string path = Environment.CurrentDirectory.Replace(@"\bin\Debug\net5.0.", "").
                Replace(@"\bin\Release\net5.0", "") + "\\";
            using (StreamReader streamReader=new StreamReader(path + "client.json"))
            {
                var jsonString = streamReader.ReadToEnd();
                //Deserialization...
                clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
            }
            Console.WriteLine("Before adding a client:");
            foreach (var c in clients)
                Console.WriteLine("Name: " + c.Name + ", Date of registration: " + 
                    c.DateOfRegistration.ToShortDateString());
            Console.WriteLine();
            //One new client:
            clients.Add(new Client("Donald Duck", new DateTime(2021, 3, 29)));
            //Serializing...
            using(StreamWriter streamWriter=new StreamWriter(path + "client.json", false))
            {
                string jsonData = JsonConvert.SerializeObject(clients);
                streamWriter.Write(jsonData);
                streamWriter.Close();
            }
            //Did it go??

            using (StreamReader streamReader = new StreamReader(path + "client.json"))
            {
                var jsonString = streamReader.ReadToEnd();
                //Deserialization...
                clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
            }
            Console.WriteLine("After adding a client:");
            foreach (var c in clients)
                Console.WriteLine("Name: " + c.Name + ", Date of registration: " +
                    c.DateOfRegistration.ToShortDateString());
            Console.WriteLine();
        }
    }
}
