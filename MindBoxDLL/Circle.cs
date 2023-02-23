using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL.Figure
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle()
        {
            Name = "Circle";
        }
        public Circle(double radius):this()
        {
            if (!CheckSides(radius))
                throw new ArgumentException("Круга с таким радиусом не бывает");
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override bool CheckSides(params double[] a)
        {
            if (a[0] <= 0)
                return false;
            return true;
        }
        public override string ToString()
        {
            return $"Name = {Name}, radius = {Radius}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            var o = (Circle)obj;
            return this.Radius == o.Radius;
        }
    }
}
