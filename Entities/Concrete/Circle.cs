using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Circle : IShape
    {
        private int _Radius;

        // Encapsulation
        public int Radius
        {
            get { return _Radius; }

            set
            {
                if(value <= 0)
                {
                    _Radius = 1;
                }else
                {
                    _Radius = value;
                }
            }
        }

        public override void CalculateArea()
        {
            var area = Math.PI * Math.Pow(_Radius, 2);
            Console.WriteLine("Area of Circle : " + area);
        }

        public  override void CalculatePerimeter()
        {
            var perimeter = Math.PI * 2 * _Radius;
            Console.WriteLine("Perimeter of Circle : " + perimeter);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Circle classı IShape classından extend edildi.");
        }
    }
}
