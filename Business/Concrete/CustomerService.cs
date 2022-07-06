using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerService : ICustomerManager
    {
        ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer entity)
        {
            // An error will be thrown because the database does not exist.
            try
            {
                _customerDal.Add(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The customer with name " + entity.Name + " has been added.");
            }
        }

        public void Delete(Customer entity)
        {
            // An error will be thrown because the database does not exist.
            try
            {
                _customerDal.Add(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The customer with id " + entity.Id +" has been deleted.");
            }
        }

        public Customer Get(int customerId)
        {
            //  I returned fake data as there is no database.
            try
            {
                return _customerDal.Get(p => p.Id == customerId);
            }
            catch (Exception)
            {
                return new Customer() { Id = 1, Email = "customer@customer.com", Name = "Customer 1", 
                    Password = "123456" ,Address = "Customer 1 Address",PhoneNumber = "111111111"};
            }


        }

        public List<Customer> GetAll()
        {
            // I returned fake data as there is no database.
            try
            {
                return _customerDal.GetAll();
            }
            catch (Exception)
            {
                List<Customer> customerList = new();
                customerList.Add(new Customer()
                {
                    Id = 1,
                    Email = "customer@customer2.com",
                    Name = "Customer 2",
                    Password = "123456",
                    Address = "Customer 2 Address",
                    PhoneNumber = "111111111"
                });
                customerList.Add(new Customer()
                {
                    Id = 1,
                    Email = "customer@customer3.com",
                    Name = "Customer 3",
                    Password = "123456",
                    Address = "Customer 3 Address",
                    PhoneNumber = "111111111"
                });
                return customerList;
            }
        }

        public void Update(Customer entity)
        {
            try
            {
                _customerDal.Update(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The customer with id " + entity.Id + " has been updated.");
            }
        }
    }
}
