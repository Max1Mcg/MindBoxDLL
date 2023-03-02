﻿using System;
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
