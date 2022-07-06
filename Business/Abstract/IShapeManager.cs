using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShapeManager
    {
        public void CalculateArea(IShape shape);
        public void CalculatePerimeter(IShape shape);

        public void ShowInfo(IShape shape);
    }
}
