namespace Iterator
{
    // Concrete Aggregate
    internal class Playlist : IPlaylist
    {
        private Song[] songs;

        public Playlist()
        {
            songs = new Song[3];
            songs[0] = new Song("Song 1");
            songs[1] = new Song("Song 2");
            songs[2] = new Song("Song 3");
        }

        public IIterator GetIterator()
        {
            return new PlaylistIterator(songs);
        }
    }
}
