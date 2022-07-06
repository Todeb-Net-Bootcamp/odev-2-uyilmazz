using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BaseDal<T> : IBaseDal<T>
    {
        public void Add(T entity)
        {
            // Database operations
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            // Database operations
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            // Database operations
            // An error will be thrown because the database does not exist.
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            // Database operations
            // An error will be thrown because the database does not exist.
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            // Database operations
            // An error will be thrown because the database does not exist.
            throw new NotImplementedException();
        }
    }
}
