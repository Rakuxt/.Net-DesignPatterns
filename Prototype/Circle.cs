namespace Prototype
{
    internal class Circle : IShape
    {
        public int Radius { get; set; }

        public IShape Clone()
        {
            return new Circle { Radius = this.Radius };
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
    }
}
