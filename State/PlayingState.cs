namespace State
{
    // Concrete States
    internal class PlayingState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Pausing playback.");
            player.SetState(new PausedState());
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Stopping playback.");
            player.SetState(new StoppedState());
        }
    }
}
