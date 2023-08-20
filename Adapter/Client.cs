namespace Adapter
{
    internal class Client
    {
        public static void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
