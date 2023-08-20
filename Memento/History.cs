namespace Memento
{
    // Caretaker
    internal class History
    {
        private Stack<EditorMemento> states = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            states.Push(memento);
        }

        public EditorMemento Pop()
        {
            return states.Pop();
        }
    }
}
