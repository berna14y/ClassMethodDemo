using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 123456,
                FirstName = "Berna",
                LastName = "Yılmaz",
                PhoneNumber = "+90 534 123 45 11",
                Email = "123@gmail.com",
                Adress = "Antalya"

            };

            Customer customer2 = new Customer()
            {
                Id = 536482,
                FirstName = "Nergiz",
                LastName = "Yıldırım",
                PhoneNumber = "+90 531 111 11 00",
                Email = "bnbn@gmail.com",
                Adress = "Eskişehir"

            };

            Customer customer3 = new Customer()
            {
                Id = 789635,
                FirstName = "Ahmet",
                LastName = "Kılıç",
                PhoneNumber = "+90 541 256 33 14",
                Email = "hgn1@gmail.com",
                Adress = "Van"
            };

            List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.List(customers);
        }
    }
}
