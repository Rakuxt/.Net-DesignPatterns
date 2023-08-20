namespace Memento
{
    // Memento
    internal class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
