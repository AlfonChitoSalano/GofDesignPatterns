namespace DesignPattern.Behavioral.Iterator
{
    internal class User
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public User(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}
