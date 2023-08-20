namespace State
{
    // State
    internal interface IPlayerState
    {
        void Play(MusicPlayer player);
        void Pause(MusicPlayer player);
        void Stop(MusicPlayer player);
    }
}
