using ToDoList.Services;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressService addressService = new AddressService();

            addressService.ToDoList();
        }
    }
}