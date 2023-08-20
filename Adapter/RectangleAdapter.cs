namespace Adapter
{
    // Adapter
    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle adaptee;

        public RectangleAdapter(LegacyRectangle adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Draw()
        {
            // Adapting the Adaptee's method to the Target's interface
            adaptee.Display(10, 20, 30, 40);
        }
    }
}
