using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL.Figure
{
    public class Triangle:Figure {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {
            Name= "Triangle";
        }
        public Triangle(double x1, double x2, double x3):this()
        {
            if (!CheckSides(x1, x2, x3))
                throw new ArgumentException("Треугольника с такими длинами сторон не бывает");
            A = x1; B = x2; C = x3;
        }
        /// <summary>
        /// Virtual method for get area of triangle.
        /// </summary>
        /// <returns>Area of triangle</returns>
        public override double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        /// <summary>
        /// Method for testing a triangle for a rectangular
        /// </summary>
        /// <returns>Is rectangular or not</returns>
        public bool IsRectangular()
        {
            var max = new[] { A,B,C}.Max();
            return Math.Pow(max, 2) == new[] { A, B, C }.Sum(x => Math.Pow(x, 2)) - Math.Pow(max, 2);
        }
        /// <summary>
        /// Method for check correct values of sides
        /// </summary>
        /// <param name="a">Massive of params for sides</param>
        /// <returns>Correct or not</returns>
        public override bool CheckSides(params double[] a)
        {
            const int sidesInTriangle = 3;
            if(a.Count(e => e > 0) != sidesInTriangle || a.Count(e => e * 2 < a.Sum()) != sidesInTriangle)
                return false;
            return true;
        }
        /// <summary>
        /// Override method ToString from Object
        /// </summary>
        /// <returns>Triangle as String</returns>
        public override string ToString()
        {
            return $"Name = {Name}, sideA = {A}, sideB = {B}, sideC = {C}";
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
            var o = (Triangle)obj;
            return this.A == o.A && this.B == o.B && this.C == o.C;
        }
    }
}
