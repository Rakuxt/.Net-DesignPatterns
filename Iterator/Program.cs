namespace Iterator
{
    /*
    The Iterator pattern is a behavioral design pattern that provides a way to access the elements of a collection (or aggregate) sequentially without exposing
    the underlying structure. It encapsulates the traversal logic and allows clients to iterate over a collection's elements without needing to know the internal
    details of how the iteration is implemented.

    Key components of the Iterator pattern:

    Iterator: This is the interface that defines the methods for traversing a collection, such as MoveNext, GetCurrent, and Reset.

    Concrete Iterator: These are the classes that implement the Iterator interface and provide the actual traversal logic over a specific collection.

    Aggregate: This is the interface that defines the method for creating an Iterator. It represents the collection of objects that you want to traverse.

    Concrete Aggregate: These are the classes that implement the Aggregate interface and create Concrete Iterators for their specific collections.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Iterator pattern allows you to iterate over the songs in a playlist without exposing the underlying array structure. The Playlist
        /// class acts as the Aggregate, creating an instance of PlaylistIterator as the Concrete Iterator. The client code interacts with the IIterator interface,
        /// which encapsulates the traversal logic. This pattern provides a way to iterate over different types of collections while keeping the traversal logic
        /// separate from the collection itself.
        /// </summary>
        static void Main(string[] args)
        {
            IPlaylist playlist = new Playlist();
            IIterator iterator = playlist.GetIterator();

            while (iterator.MoveNext())
            {
                Song song = (Song)iterator.GetCurrent();
                Console.WriteLine($"Playing: {song.Title}");
            }
        }
    }
}