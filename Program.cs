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
            string path = @"C:\Users\Public\Json\client.json";
            List<Client> clients = new List<Client>();
            using(StreamReader streamReader=new StreamReader(path))
            {
                var jsonString = streamReader.ReadToEnd();
                //Deserialization...
                clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
            }
            foreach (var c in clients)
                Console.WriteLine("Name: " + c.Name + ", Date of registration: " + c.DateOfRegistration.ToShortDateString());
        }
    }
}
