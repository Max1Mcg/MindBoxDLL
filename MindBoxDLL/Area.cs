using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL
{
    //Статический класс для вычисления фигуры, без знания её типа
    //В switch-конструкции описаны классы Circle и Triangle, если площадь нужно вычислить
    //для круга или треугольника, default вычисляет площадь для OtherFigure.
    public static class Area
    {
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
