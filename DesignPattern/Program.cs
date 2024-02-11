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

Console.WriteLine();
IProgramRunner runner8 = new BuilderProgramRunner();
runner8.Run();

Console.WriteLine();
IProgramRunner runner9 = new BuilderProgramRunner();
runner9.Run();

Console.WriteLine();
IProgramRunner runner10 = new AdapterProgramRunner();
runner10.Run();

Console.WriteLine();
IProgramRunner runner11 = new DecoratorProgrammerRunner();
runner11.Run();

Console.WriteLine();
IProgramRunner runner12 = new FacadeProgramRunner();
runner12.Run();

Console.WriteLine();
IProgramRunner runner13 = new IteratorProgramRunner();
runner13.Run();

Console.WriteLine();
IProgramRunner runner14 = new StateProgramRunner();
runner14.Run();

Console.WriteLine();
IProgramRunner runner15 = new TemplateProgramRunner();
runner15.Run();