using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBoxDLL;

namespace MindBoxDLL
{
    public abstract class Figure: ICheckSides
    {
        //Свойство Name нужно для задания имени для нового типа фигуры(задание 1.1)
        public string Name { get; set; }
        //Данный метод проверяет корректность сторон для заранее неизвестного числа параметров,
        //(тоже для задания 1.1)
        public abstract bool CheckSides(params double[] a);
        public abstract double GetArea();
    }
}
