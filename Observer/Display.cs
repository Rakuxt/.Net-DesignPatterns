namespace Observer
{
    // Concrete Observer
    internal class Display : IObserver
    {
        private string name;

        public Display(string name)
        {
            this.name = name;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"{name} Display: Temperature = {temperature}, Humidity = {humidity}, Pressure = {pressure}");
        }
    }
}
