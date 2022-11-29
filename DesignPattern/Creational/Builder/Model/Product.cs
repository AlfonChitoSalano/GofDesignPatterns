namespace DesignPattern.Creational.Builder
{
    internal class Product
    {
        private readonly List<string> _parts = new();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");

            foreach (var part in _parts)
                Console.WriteLine(part);
        }
    }
}