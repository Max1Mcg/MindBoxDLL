<br>Задание 1) #Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам: Папка MindBoxDLL,
файлы Figure.cs(абстрактный класс фигуры), ICheckSides.cs(интерфейс для проверки на корректность измерений для сторон), Circle.cs(круг), Triangle.cs(треугольник).</br>
<br>1.1) Юнит-тесты: Папка MindBoxDLL.tests, файл MindBoxDLL.cs</br>
<br>1.2) Легкость добавления других фигур: Папка MindBoxDLL, OtherFigure.cs(формула для площади задается пользователем, а сам метод затем вычисляет площадь с помощью интерполяции и метода .Compute(...))</br>
<br>1.3*) Вычисление площади фигуры без знания типа фигуры в compile-time: Папка MindBoxDLL, файл Area.cs(можно было сделать статический метод для площади и в абстрактном классе Figure, но тогда бы все его производные классы его унаследовали, чего делать не хотелось)</br>
<br>*Не совсем понял задание, выполнил как упаковку в Object(после этого тип фактически известен не будет), а затем при помощи оператора is вычислял площадь для Object, распаковывая его, если это возможно.</br>
<br>**Можно было сделать при помощи поля в базовом классе, которое получало бы значение в зависимости от того какой конструктор был вызван ИЛИ с помощью методов расширений, хотя для них нужен экземпляр класса, поэтому решение было бы похоже на реализованное мною.</br>
<br>1.4) Проверку на то, является ли треугольник прямоугольным: Папка MindBoxDLL, файл Triangle.cs</br>
<br>Задание 2) В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.: Папка MindBoxDLL => Task2, файл Task2.sql</br>
