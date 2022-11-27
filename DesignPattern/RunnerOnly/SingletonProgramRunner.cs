using DesignPattern.Creational.Singleton;

namespace DesignPattern.RunnerOnly
{
    internal class SingletonProgramRunner : IProgramRunner
    {
        public void Run()
        {
            //Singleton
            var instance1 = LoggerSingleton.Instance;
            var instance2 = LoggerSingleton.Instance;

            if (instance1 == instance2 && LoggerSingleton.Instance == instance2)
            {
                Console.WriteLine("Great singleton");
            }

            var instance3 = LoggerSingleton.InstanceThreadSafe;
            var instance4 = LoggerSingleton.InstanceThreadSafe;

            if (instance3 == instance4 && LoggerSingleton.InstanceThreadSafe == instance4)
            {
                Console.WriteLine("Great singleton");
            }

            if (instance1 == instance4)
            {
                Console.WriteLine("Oh NO");
            }
            else
            {
                Console.WriteLine("Great not the same");
            }
        }
    }
}