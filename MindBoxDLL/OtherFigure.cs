using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MindBoxDLL.Figure
{
    public class OtherFigure : Figure
    {
        public List<double> Sides { get; set; }
        //"!0 * (!1+!2)", where ! before index
        public string FormulaForArea{get;}
        public OtherFigure(string name, List<double> sides, string formulaForArea)
        {
            if (!CheckSides(sides.ToArray()))
                throw new ArgumentException("Одна или несколько сторон имеют отрицательную длину");
            Name = name;
            Sides = sides;
            FormulaForArea = formulaForArea;
        }
        public override bool CheckSides(params double[] a)
        {
            return a.Where(e => e < 0).Count() == 0;
        }
        public override double GetArea()
        {
            DataTable dt = new DataTable();
            var tempFormula = FormulaForArea;
            for (int i=0;i<Sides.Count;i++)
            {
                while (tempFormula.IndexOf($"!{i}") != -1)
                {
                    Console.WriteLine(tempFormula);
                    tempFormula = tempFormula.Replace($"!{i}", Convert.ToString(Sides[i]));
                }
            }
            var v = dt.Compute(tempFormula, "");
            return Convert.ToDouble(v);
        }
        public override string ToString()
        {
            var sb = new StringBuilder($"Name = {Name} ");
            foreach (var s in Sides)
            {
                sb.Append($"side[i] = {s}, ");
            }
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            var o = (OtherFigure)obj;
            return Enumerable.SequenceEqual(this.Sides, o.Sides);
        }
    }
}
