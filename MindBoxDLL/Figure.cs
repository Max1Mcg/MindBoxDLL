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
        /// <summary>
        /// abstract method from ICheckSides
        /// </summary>
        /// <param name="a">massive of sides</param>
        /// <returns>correct or not</returns>
        public abstract bool CheckSides(params double[] a);
        /// <summary>
        /// abstract method for get area
        /// </summary>
        /// <returns>area of figure</returns>
        public abstract double GetArea();
    }
}
