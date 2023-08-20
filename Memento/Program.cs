namespace Memento
{
    /*
    The Memento pattern is a behavioral design pattern that allows an object's state to be captured and stored externally so that it can be restored to that state
    later without revealing its internal structure. This pattern is used to implement undo mechanisms, checkpoints, and snapshots in applications.

    Key components of the Memento pattern:

    Originator: This is the object whose state needs to be saved and restored. It creates and stores mementos containing its state.

    Memento: This is the object that stores the state of the originator. It provides a way to restore the originator's state.

    Caretaker: This is responsible for keeping track of mementos. It doesn't manipulate the memento but can request the originator to restore its state.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Memento pattern is used to implement the undo functionality of a text editor. The Editor is the originator that maintains its 
        /// state and can save and restore it using the EditorMemento. The History acts as a caretaker, keeping track of the mementos. The client code simulates 
        /// typing sentences, saving the state, and then restoring the previous state, effectively undoing the changes.
        /// </summary>
        static void Main(string[] args)
        {
            Editor editor = new Editor("");
            History history = new History();

            editor.Type("This is the first sentence.");
            history.Push(editor.Save());

            editor.Type("This is the second sentence.");
            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent()); // Output: This is the first sentence.
        }
    }
}