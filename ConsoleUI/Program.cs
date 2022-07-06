using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****************** Shape ********************");
            SampleShape();
            CustomerFunctions();
            PersonelFunctions();

        }

        private static void PersonelFunctions()
        {
            Console.WriteLine(" ");
            Console.WriteLine("****************** Personel Functions ********************");
            IPersonelManager personelManager = new PersonelService(new PersonelDal());

            Personel personel1 = new Personel()
            {
                Name = "New Personel",
                Email = "newPersonel@newPersonel.com",
                Password = "123456",
            };
            personelManager.Add(personel1);

            var personel = personelManager.Get(2); // return fake Personel object
            Console.WriteLine(personel.ToString());

            List<Personel> personelList = personelManager.GetAll(); // return fake Personel objects
            foreach (Personel item in personelList)
            {
                Console.WriteLine(item.ToString());
            }

            personelManager.Delete(new Personel() { Id = 2, Name = "deletedCustomer" });
            personelManager.Update(new Personel() { Id = 3, Name = "updatedCustomer" });
        }

        private static void CustomerFunctions()
        {
            Console.WriteLine(" ");
            Console.WriteLine("****************** Customer Functions ********************");
            ICustomerManager customerManager = new CustomerService(new CustomerDal());

            Customer customer1 = new Customer()
            {
                Name = "New Customer",
                Email = "newcustomer@newcustomer.com",
                Password = "123456",
                Address = "new customer address",
                PhoneNumber = "1122333654447"
            };
            customerManager.Add(customer1);

            var customer = customerManager.Get(2); // return fake Customer object
            Console.WriteLine(customer.ToString());

            List<Customer> customerList = customerManager.GetAll(); // return fake Customer objects
            foreach (Customer item in customerList)
            {
                Console.WriteLine(item.ToString());
            }

            customerManager.Delete(new Customer() { Id = 2, Name = "deletedCustomer" });
            customerManager.Update(new Customer() { Id = 3, Name = "updatedCustomer" });
        }

        private static void SampleShape()
        {
            IShape circle = new Circle() { Radius = 5 };
            IShape rectange = new Rectangle() { Height = 5, Weight = -1 };
            IShape square = new Square() { Height = 7 };

            IShapeManager shapeManager = new ShapeService();

            // Area
            shapeManager.CalculateArea(circle);
            shapeManager.CalculateArea(rectange);
            shapeManager.CalculateArea(square);

            // Perimeter
            shapeManager.CalculatePerimeter(circle);
            shapeManager.CalculatePerimeter(rectange);
            shapeManager.CalculatePerimeter(square);

            // Information
            shapeManager.ShowInfo(circle);
            shapeManager.ShowInfo(rectange);
            shapeManager.ShowInfo(square);
        }
    }
}
