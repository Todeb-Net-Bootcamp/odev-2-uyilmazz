using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Square : IShape
    {
        private int _Height;

        // Encapsulation
        public int Height
        {
            get { return _Height; }
            set { _Height = value <= 0 ? 1 : value; }
        }

        public override void CalculateArea()
        {
            var area = Math.Pow(_Height, 2);
            Console.WriteLine("Area of square : " + area);
        }

        public override void CalculatePerimeter()
        {
            var perimeter = 4 * _Height;
            Console.WriteLine("Perimeter of square : " + perimeter);
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Square classı IShape classından extend edildi.");
        }
    }
}
