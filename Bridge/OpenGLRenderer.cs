namespace Bridge
{
    // Concrete Implementations
    internal class OpenGLRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"OpenGL Rendering Circle with radius {radius}");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"OpenGL Rendering Square with side {side}");
        }
    }
}
