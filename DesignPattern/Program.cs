using DesignPattern.RunnerOnly;

Console.WriteLine("Hello, actual design pattern coding");
IProgramRunner runner1 = new SingletonProgramRunner();
runner1.Run();

Console.WriteLine();
IProgramRunner runner2 = new FactoryProgramRunner();
runner2.Run();

Console.WriteLine();
IProgramRunner runner3 = new AbstractProgramRunner();
runner3.Run();

Console.WriteLine();
IProgramRunner runner4 = new CommandProgramRunner();
runner4.Run();

Console.WriteLine();
IProgramRunner runner5 = new ObserverProgramRunner();
runner5.Run();

Console.WriteLine();
IProgramRunner runner6 = new MediatorProgramRunner();
runner6.Run();

Console.WriteLine();
IProgramRunner runner7 = new ChainOfResponsibilityProgramRunner();
runner7.Run();