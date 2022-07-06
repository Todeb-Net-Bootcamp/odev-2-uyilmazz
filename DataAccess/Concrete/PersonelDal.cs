using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PersonelDal : BaseDal<Personel>, IPersonelDal
    {
        public void Deliver()
        {
            // Database operations
            // An error will be thrown because the database does not exist.
            throw new NotImplementedException();
        }
    }
}
