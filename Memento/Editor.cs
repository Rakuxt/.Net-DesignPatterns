namespace Memento
{
    // Originator
    internal class Editor
    {
        private string content;

        public Editor(string content)
        {
            this.content = content;
        }

        public void Type(string words)
        {
            content += " " + words;
        }

        public string GetContent()
        {
            return content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        public void Restore(EditorMemento memento)
        {
            content = memento.Content;
        }
    }
}
