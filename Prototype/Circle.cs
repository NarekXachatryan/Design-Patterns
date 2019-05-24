using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом { 0}", radius);
        }
    }

    
}
