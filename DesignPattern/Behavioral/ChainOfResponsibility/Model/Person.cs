namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    internal class Person
    {
        public Person(string name, string password, string role, string region)
        {
            Name = name;
            Password = password;
            Role = role;
            Region = region;
        }

        public string Name { get; }
        public string Password { get; }
        public string Role { get; }
        public string Region { get; }
    }
}
