namespace DesignPattern.Behavioral.Iterator
{
    internal interface IUserIterator
    {
        User First();
        User? Next();
        bool IsDone { get; }
        User CurrentItem { get; }
    }
}
