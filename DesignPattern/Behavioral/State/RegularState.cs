namespace DesignPattern.Behavioral.State
{
    internal class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;

            if (Balance >= 1000)
            {               
                BankAccount.BankAccountState = new GoldState(Balance, BankAccount);
            }
        }
      
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");          
            Balance -= amount;

            if (Balance < 0)
            {               
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
