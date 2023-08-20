namespace Facade
{
    internal class HomeTheaterFacade
    {
        private DVDPlayer dvdPlayer;
        private Projector projector;
        private Lights lights;

        public HomeTheaterFacade()
        {
            dvdPlayer = new DVDPlayer();
            projector = new Projector();
            lights = new Lights();
        }

        public void TurnOn()
        {
            dvdPlayer.TurnOn();
            projector.TurnOn();
            lights.TurnOn();
            Console.WriteLine("Home Theater System is turned on");
        }

        public void TurnOff()
        {
            dvdPlayer.TurnOff();
            projector.TurnOff();
            lights.TurnOff();
            Console.WriteLine("Home Theater System is turned off");
        }
    }
}
