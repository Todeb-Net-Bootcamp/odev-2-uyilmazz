using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerManager
    {
        List<Customer> GetAll();
        Customer Get(int personelId);
        void Add(Customer entity);
        void Delete(Customer entity);
        void Update(Customer entity);
    }
}
