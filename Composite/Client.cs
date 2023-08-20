namespace Composite
{
    internal class Client
    {
        public static void DrawShapes(IShape shape)
        {
            shape.Draw();
        }
    }
}
