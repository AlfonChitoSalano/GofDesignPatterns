namespace DesignPattern.Behavioral.Iterator
{
    internal class UserCollection : List<User>, IUserCollection
    {
        public IUserIterator CreateIterator()
        {
            return new UserIterator(this);
        }
    }
}
