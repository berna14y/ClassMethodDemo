using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + customer.LastName + "Added to the system.\n");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + customer.LastName + "Deleted from the system.\n");

        }
        public void List(List<Customer> customers)
        {
            foreach (var customer in customers)
            
            {
                Console.WriteLine("Id :" + customer.Id);
                Console.WriteLine("First Name :" +customer.FirstName);
                Console.WriteLine("Last Name :" + customer.LastName);
                Console.WriteLine("PhoneNumber :" + customer.PhoneNumber);
                Console.WriteLine("Email :" + customer.Email);
                Console.WriteLine("Adress :" + customer.Adress);
            }
        }
          
    }
}
