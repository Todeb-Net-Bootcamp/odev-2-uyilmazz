using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ShapeService : IShapeManager
    {
       
        public void CalculateArea(IShape shape)
        {
            shape.CalculateArea();
        }

        public void CalculatePerimeter(IShape shape)
        {
            shape.CalculatePerimeter();
        }

        public void ShowInfo(IShape shape)
        {
            shape.ShowInfo();
        }
    }
}
