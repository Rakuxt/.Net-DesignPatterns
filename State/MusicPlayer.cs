namespace State
{
    // Context
    internal class MusicPlayer
    {
        private IPlayerState currentState;

        public MusicPlayer()
        {
            currentState = new StoppedState();
        }

        public void SetState(IPlayerState state)
        {
            currentState = state;
        }

        public void Play()
        {
            currentState.Play(this);
        }

        public void Pause()
        {
            currentState.Pause(this);
        }

        public void Stop()
        {
            currentState.Stop(this);
        }
    }
}
