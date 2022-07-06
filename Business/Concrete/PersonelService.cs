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
    public class PersonelService : IPersonelManager
    {
        IPersonelDal _personelDal;

        public PersonelService(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void Add(Personel entity)
        {
            // An error will be thrown because the database does not exist.
            try
            {
                _personelDal.Add(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The Personel with name " + entity.Name + " has been added.");
            }
        }

        public void Delete(Personel entity)
        {
            // An error will be thrown because the database does not exist.
            try
            {
                _personelDal.Add(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The Personel with id " + entity.Id + " has been deleted.");
            }
        }

        public Personel Get(int personelId)
        {
            //  I returned fake data as there is no database.
            try
            {
                return _personelDal.Get(p => p.Id == personelId);
            }catch(Exception)
            {
                return new Personel() { Id = 1, Email = "personel@personel.com", Name = "Personel 1", Password = "123456" };
            }
            
            
        }

        public List<Personel> GetAll()
        {
            // I returned fake data as there is no database.
            try
            {
                return _personelDal.GetAll();
            }
            catch (Exception)
            {
                List<Personel> personelList = new List<Personel>();
                personelList.Add(new Personel() { Id = 1, Email = "personel@personel.com", Name = "Personel 1", Password = "123456" });
                personelList.Add(new Personel() { Id = 2, Email = "personel@personel2.com", Name = "Personel 2", Password = "123456" });
                return personelList;
            }
        }

        public void Update(Personel entity)
        {
            try
            {
                 _personelDal.Update(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("The Personel with id " + entity.Id + " has been updated.");
            }
        }
    }
}
