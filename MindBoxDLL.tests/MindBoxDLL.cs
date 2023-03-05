using MindBoxDLL;
using Xunit.Sdk;

namespace MindBoxDLL.Tests 
{ 
    public class MindBoxDLL
    {
        [Fact]
        public void CircleArea()
        {
            var v = new Circle(12.2);
            Assert.Equal(467.59465056030473, v.GetArea());
        }
        [Fact]
        public void CircleConstructorException()
        {
            try { var v = new Circle(-12); } 
            catch (Exception e) {
                ThrowsException.Equals(e.Message, "����� � ����� �������� �� ������");
            }
        }
        //����� ��� ��������� ������� ������, �� ���� � ���� �� ����� ����������, �������
        //��� ������� ��� OtherFigure �������� �������������
        [Fact]
        public void OtherFigureArea()
        {
            Assert.Equal(5, Area.GetArea("MyFigure", new List<double>() { 1, 2, 3 }, "!0 * (!1+!2)"));
        }
    }
}