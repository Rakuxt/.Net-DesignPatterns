namespace Adapter
{
    // Adaptee
    internal class LegacyRectangle
    {
        public void Display(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"LegacyRectangle: from ({x1}, {y1}) to ({x2}, {y2})");
        }
    }
}
