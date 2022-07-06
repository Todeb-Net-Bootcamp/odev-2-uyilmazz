using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelManager
    {
        List<Personel> GetAll();
        Personel Get(int personelId);
        void Add(Personel entity);
        void Delete(Personel entity);
        void Update(Personel entity);
    }
}
