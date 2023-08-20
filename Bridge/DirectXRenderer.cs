namespace Bridge
{
    // Concrete Implementations
    internal class DirectXRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"DirectX Rendering Circle with radius {radius}");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"DirectX Rendering Square with side {side}");
        }
    }
}
