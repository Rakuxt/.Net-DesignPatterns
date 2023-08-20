namespace Iterator
{
    // Iterator
    internal interface IIterator
    {
        bool MoveNext();
        object GetCurrent();
        void Reset();
    }
}
