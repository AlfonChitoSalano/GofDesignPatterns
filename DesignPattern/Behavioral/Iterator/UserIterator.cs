namespace DesignPattern.Behavioral.Iterator
{
    internal class UserIterator : IUserIterator
    {
        private readonly UserCollection _users;

        private int _currentIndex;

        public UserIterator(UserCollection users)
        {
            if (!users.Any())
            {
                throw new NullReferenceException();
            }

            _users = users;
        }

        public bool IsDone => _currentIndex >= _users.Count;

        public User CurrentItem
        {
            get { return _users.OrderBy(p => p.Name).ToList()[_currentIndex]; }
        }

        public User First()
        {
            _currentIndex = 0;
            return _users.OrderBy(p => p.Name).ToList()[_currentIndex];
        }

        public User? Next()
        {
            _currentIndex++;

            if (!IsDone)
            {
                return _users
                    .OrderBy(p => p.Name).ToList()[_currentIndex];
            }

            return null;
        }
    }
}