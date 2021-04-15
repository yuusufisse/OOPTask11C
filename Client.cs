using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask11C
{
    class Client
    {
        public Client(string name, DateTime dateOfRegistration)
        {
            Name = name;
            DateOfRegistration = dateOfRegistration;
        }

        public string Name { get; set; }
        public DateTime DateOfRegistration { get; set; }

    }
}
