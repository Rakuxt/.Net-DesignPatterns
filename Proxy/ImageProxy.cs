namespace Proxy
{
    // Proxy
    internal class ImageProxy : IImage
    {
        private RealImage realImage;
        private string filename;

        public ImageProxy(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }

}
