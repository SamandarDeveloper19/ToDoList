using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    internal class AddressService
    {
        public List<Address> Addresses { get; set; }

        public AddressService()
        {
            Addresses = new List<Address>();

            Addresses.Add(new Address("Tashkent"));
            Addresses.Add(new Address("Samarkand")); ;
            Addresses.Add(new Address("Kharazm")); ;
        }


        public void ToDoList()
        {
            int d = 0; //variable created for do while  

            do
            {
                Console.WriteLine("Available addresses:");
                for (int i = 0; i < Addresses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Addresses[i].AnyAddress}");
                }

                Console.WriteLine("\nWhat do you want to do\n1. Add\n2. Remove\n3. Exchange");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Add(Addresses);
                }
                else if (a == 2)
                {
                    Remove(Addresses);
                }
                else if (a == 3)
                {
                    Replace(Addresses);
                }
                Console.WriteLine("Do you want to do something again?\n1. Yes\n2. No");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            } while (d == 1);

            Console.WriteLine("The work has been completed!!!\nFinal adresses:");
            for (int i = 0; i < Addresses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Addresses[i].AnyAddress}");
            }
        }

        public void Add(List<Address> addresses)
        {
            Console.Write("What address are you going to add: ");
            string job = Console.ReadLine();
            if (addresses.Count == 10)
            {
                Console.WriteLine("Reminder!\nThe list should not exceed 10!\nYou can replace it with " +
                    "another one!\nDo you want to replace?\n1. Yes\n2. No");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (b == 1)
                {
                    Console.WriteLine("Which one do you want to write instead?");
                    Console.WriteLine("Available addresses:");
                    for (int i = 0; i < addresses.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {addresses[i].AnyAddress}");
                    }
                    int c = Convert.ToInt32(Console.ReadLine());
                    addresses[c - 1] = new Address($"{job}");
                    Console.WriteLine("The work has been completed successfully!");
                }
                else
                {
                    Console.WriteLine("The work has been completed!");
                }
            }
            else
            {
                addresses.Add(new Address($"{job}"));
                Console.WriteLine("The work has been completed successfully!");
            }
        }
        public void Remove(List<Address> addresses)
        {
            Console.Write("Which address do you want to remove: ");
            int b = Convert.ToInt32(Console.ReadLine());
            addresses.RemoveAt(b - 1);
            Console.WriteLine("The work has been completed successfully!");
        }
        public void Replace(List<Address> addresses)
        {
            Console.Write("Which address do you want to replace: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("What address do you want to write instead: ");
            string job = Console.ReadLine();
            addresses[b - 1] = new Address($"{job}");
            Console.WriteLine("The work has been completed successfully!");
        }
    }
}
