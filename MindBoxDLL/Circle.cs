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
        /// <summary>
        /// Method for get area for circle
        /// </summary>
        /// <returns>area of circle</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        /// <summary>
        /// method for check radius 
        /// </summary>
        /// <param name="a">radius</param>
        /// <returns>correct or not</returns>
        public override bool CheckSides(params double[] a)
        {
            if (a[0] <= 0)
                return false;
            return true;
        }
        /// <summary>
        /// Override method ToString from Object
        /// </summary>
        /// <returns>Triangle as String</returns>
        public override string ToString()
        {
            return $"Name = {Name}, radius = {Radius}";
        }
        /// <summary>
        /// Override method Equals from Object
        /// </summary>
        /// <param name="obj">Object to comparison</param>
        /// <returns>Two objects are equals or not</returns>
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
