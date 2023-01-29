namespace DesignPattern.Behavioral.State
{
    internal class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }

        public BankAccount()
        {
            BankAccountState = new RegularState(200, this);
        }

        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            BankAccountState.Withdraw(amount);
        }
    }
}