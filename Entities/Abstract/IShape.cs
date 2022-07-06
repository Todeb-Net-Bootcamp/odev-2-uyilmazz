using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class IShape
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public virtual void ShowInfo()
        {
            Console.WriteLine("IShape abstract class tanımlandı.");
        }
    }
}
