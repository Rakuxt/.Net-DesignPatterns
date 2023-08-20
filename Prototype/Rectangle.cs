namespace Prototype
{
    // Concrete Prototypes
    internal class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public IShape Clone()
        {
            return new Rectangle { Width = this.Width, Height = this.Height };
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
        }
    }

}
