using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
