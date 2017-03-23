namespace G1_Mobsters.Payables
{
    public interface IPayable
    {
        int Balance { get; }

        int Withdraw(int ammount);

        void Deposit(int ammount);
    }
}