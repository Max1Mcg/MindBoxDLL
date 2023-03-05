using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL
{
    //Статический класс для вычисления фигуры, без знания её типа(точнее тип будет Object,
    //объект которого является производным от Figure или нет)
    public static class Area
    {
        static readonly System.Collections.Generic.Dictionary<string, Type> d = null;
        static Area()
        {
            d = new System.Collections.Generic.Dictionary<string, Type>() { { "Circle", typeof(Circle)}, { "Triangle", typeof(Triangle)}, {"OtherFigure", typeof(OtherFigure)} };
        }
        public static double GetArea(string name, List<double>sides, string formulaForArea = "")
        {
            Figure figure = null;
            switch (name)
            {
                case "Circle":
                    figure = new Circle(sides[0]);
                    break;
                case "Triangle":
                    figure = new Triangle(sides[0], sides[1], sides[2]);
                    break;
                default:
                    figure = new OtherFigure(name, sides, formulaForArea);
                    break;
            }
            return figure.GetArea();
        }
    }
}
