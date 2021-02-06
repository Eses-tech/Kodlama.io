using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io
{
    class CustomerManager
    {
        public void CustomerAdd(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + "müsterilere eklendi..");

            }
            Console.WriteLine("***************");

        }
        public void CustomerList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Musteri Numarasi:" + customer.CustomerId);
                Console.WriteLine("Musteri Ad - Soyad:" + customer.CustomerName + " " + customer.CustomerSurname);
                Console.WriteLine("Musteri Yas:" + customer.Age);
                Console.WriteLine("*****************");

            }
        }

        public void CustomerDelete(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + "musterilerden silindi..");


            }
        }

    }
}
