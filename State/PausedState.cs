namespace State
{
    // Concrete States
    internal class PausedState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Resuming playback.");
            player.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Stopping playback.");
            player.SetState(new StoppedState());
        }
    }
}
