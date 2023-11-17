using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class Address
    {
        public string AnyAddress { get; set; }

        public Address(string address)
        {
            AnyAddress = address;
        }
    }
}
