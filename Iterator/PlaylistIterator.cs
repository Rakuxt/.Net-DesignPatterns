namespace Iterator
{
    // Concrete Iterator
    internal class PlaylistIterator : IIterator
    {
        private Song[] songs;
        private int current;

        public PlaylistIterator(Song[] songs)
        {
            this.songs = songs;
            current = 0;
        }

        public bool MoveNext()
        {
            if (current < songs.Length)
            {
                current++;
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            return songs[current - 1];
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
