using System;

namespace Kodlama.io
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Musteri Takip Sistemine Hosgeldiniz*****");



            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Gizem";
            customer1.CustomerSurname = "Koca";
            customer1.Age = 29;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Esra";
            customer2.CustomerSurname = "Kul";
            customer2.Age = 34;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Hulya";
            customer3.CustomerSurname = "Umut";
            customer3.Age = 27;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customers);
            customerManager.CustomerList(customers);
            customerManager.CustomerDelete(customers);

        }
    }
}
