namespace DesignPattern.Behavioral.State
{
    internal abstract class BankAccountState
    {
        protected BankAccount BankAccount { get; init; } = null!;
        protected decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
}