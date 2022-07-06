using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rectangle : IShape
    {
        private int _Height;
        // Encapsulation
        public int Height
        {
            get { return _Height; }
            set { _Height = value <= 0 ?  1 : value; }
        }

        private int _Weight;
        // Encapsulation
        public int Weight  
        {
            get { return _Weight; }
            set { _Weight = value <= 0 ?  1 : value;} 
        }

        public override void CalculateArea()
        {
            var area = _Height * _Weight;
            Console.WriteLine("Area of rectangle : " + area);
        }

        public override void CalculatePerimeter()
        {
            var perimeter = 2 * (_Height + _Weight);
            Console.WriteLine("Perimeter of rectangle : " + perimeter);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Rectange classı IShape classından extend edildi.");
        }
    }
}
