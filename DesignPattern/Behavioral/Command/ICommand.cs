namespace DesignPattern.Behavioral.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
        bool CanExecute();
    }
}
