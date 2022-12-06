using DesignPattern.Behavioral.Iterator;

namespace DesignPattern.RunnerOnly
{
    internal class IteratorProgramRunner : IProgramRunner
    {
        public void Run()
        {
            var userCollection = new UserCollection
            {
                new("Chito Salano", "Manda"),
                new("Alfie Salano", "Rizal"),
                new("Rona Monares", "Caloocan"),
                new("Joseph Cadag", "Makati")
            };

            var userIterator = userCollection.CreateIterator();
            var user = userIterator.First();

            do
            {
                Console.WriteLine(user.Name);
                user = userIterator.Next();
            } while (!userIterator.IsDone && user != null);
        }
    }
}