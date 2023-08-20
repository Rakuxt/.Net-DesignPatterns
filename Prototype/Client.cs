namespace Prototype
{
    internal class Client
    {
        public static void DrawShapes()
        {
            IShape circle = new Circle { Radius = 5 };
            IShape clonedCircle = circle.Clone();
            circle.Draw();
            clonedCircle.Draw();

            IShape rectangle = new Rectangle { Width = 10, Height = 5 };
            IShape clonedRectangle = rectangle.Clone();
            rectangle.Draw();
            clonedRectangle.Draw();
        }
    }
}
