<Query Kind="Program" />

void Main()
{
	var myAccount = new Account(1000);
	myAccount.Dump();
	myAccount.Deposit(2000);
	myAccount.Dump();
	myAccount.Withdraw(1400);
	myAccount.Dump();
	
//	myAccount.GetBalance().Dump();
//	
//	myAccount.SetBalance(10000);
//	myAccount.GetBalance().Dump();
//	
//	myAccount.SetBalance(-10000);
//	myAccount.GetBalance().Dump();
//	
//	myAccount.SetBalance(myAccount.GetBalance()+1);

	myAccount.Balance.Dump();
	
	myAccount.Balance = 10000;
	myAccount.Balance.Dump();
	
	//myAccount.Balance = -10000;
	myAccount.Balance.Dump();
	
	myAccount.Balance +=1;
	
	myAccount.AccountId.Dump();
}

// Define other methods and classes here
class Account
{
	public Account(int initialBalance){
		_balance = initialBalance;
		AccountId = "account-id";
	}

	private int _balance = 0;
	
	public int Balance {
		get {
			return _balance;
		}
		set {
			if (value < 0)
				throw new Exception("Balance cannot be negative");
			_balance = value;
			AccountId = "account-id";
		}
	}
	
	public string AccountName {get; set;}
	public string AccountId {get; set;}
	
//	public int GetBalance(){
//		return _balance;
//	}
//	
//	public void SetBalance(int newBalance){
//		if (newBalance < 0)
//			throw new Exception("Balance cannot be negative");
//		_balance = newBalance;
//	}
	
	public void Withdraw(int ammount)
	{
		if (_balance < ammount)
			throw new Exception("Unable to withdraw");
		WithdrawImpl(ammount);
	}
	
	private void WithdrawImpl(int ammount)
	{
		_balance -= ammount;
	}
	
	public void Deposit(int ammount)
	{
		_balance += ammount;
	}
		
}
