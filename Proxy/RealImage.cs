namespace Proxy
{
    // Real Subject
    internal class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }
    }
}
