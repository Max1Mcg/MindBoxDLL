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
        public override double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsTriangle()
        {
            var max = new[] { A,B,C}.Max();
            return Math.Pow(max, 2) == new[] { A, B, C }.Sum(x => Math.Pow(x, 2)) - Math.Pow(max, 2);
        }
        public override bool CheckSides(params double[] a)
        {
            const int sidesInTriangle = 3;
            if(a.Count(e => e > 0) != sidesInTriangle || a.Count(e => e * 2 < a.Sum()) != sidesInTriangle)
                return false;
            return true;
        }
        public override string ToString()
        {
            return $"Name = {Name}, sideA = {A}, sideB = {B}, sideC = {C}";
        }
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
