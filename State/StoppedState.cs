namespace State
{
    // Concrete States
    internal class StoppedState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Starting playback.");
            player.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Cannot pause when stopped.");
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
