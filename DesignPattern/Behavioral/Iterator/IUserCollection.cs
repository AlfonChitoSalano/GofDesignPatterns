namespace DesignPattern.Behavioral.Iterator
{
    internal interface IUserCollection
    {
        IUserIterator CreateIterator();
    }
}
