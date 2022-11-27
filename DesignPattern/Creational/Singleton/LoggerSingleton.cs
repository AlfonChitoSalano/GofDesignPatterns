namespace DesignPattern.Creational.Singleton
{
    internal class LoggerSingleton
    {
        private static LoggerSingleton? _instance;
        public static LoggerSingleton Instance => _instance ??= new LoggerSingleton();

        private static readonly Lazy<LoggerSingleton> InstanceLazy = new(() => new LoggerSingleton());
        public static LoggerSingleton InstanceThreadSafe => InstanceLazy.Value;

        private LoggerSingleton()
        {
        }
    }
}