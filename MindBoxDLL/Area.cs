using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL.Figure
{
    public static class Area
    {
        /// <summary>
        /// Static method for get area for any inheriting from Figure by using reflection
        /// </summary>
        /// <param name="o">Object of class</param>
        /// <returns>area</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static double GetArea(Object o)
        {
            if (o is Circle c)
                return c.GetArea();
            else if (o is Triangle t)
                return t.GetArea();
            else if (o is OtherFigure of)
                return of.GetArea();
            throw new InvalidCastException("Данный тип не является производным от Figure");
        }
    }
}
