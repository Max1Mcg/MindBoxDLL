using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBoxDLL.Check;

namespace MindBoxDLL.Figure
{
    public abstract class Figure: ICheckSides
    {
        public string Name { get; set; }
        public abstract bool CheckSides(params double[] a);
        public abstract double GetArea();
    }
}
