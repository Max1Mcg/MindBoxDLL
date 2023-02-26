using MindBoxDLL.Figure;
using MindBoxDLL.Check;
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
                ThrowsException.Equals(e.Message, "Круга с таким радиусом не бывает");
            }
        }
        [Fact]
        public void OtherFigureArea()
        {
            Object o = new OtherFigure("MyFigure",new List<double>() { 1,2,3}, "!0 * (!1+!2)");
            Assert.Equal(5, Area.GetArea(o));
        }
    }
}