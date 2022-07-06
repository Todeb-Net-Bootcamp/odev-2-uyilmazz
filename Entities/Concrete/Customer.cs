using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : User
    {
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public string Address { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email + " Password: " + Password + " PhoneNumber: " + _PhoneNumber + " Address: " + Address;  
        }
    }

   
}
