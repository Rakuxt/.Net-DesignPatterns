namespace Composite
{
    internal class ShapeGroup : IShape
    {
        private readonly List<IShape> shapes = new();

        public void AddShape(IShape shape) { shapes.Add(shape); }

        public void Draw()
        {
            Console.WriteLine("Drawing a shape group:");
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
