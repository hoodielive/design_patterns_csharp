public class SavingsAcctFactory : ICreditUnionFactory
{
	public ISavingsAccount GetSavingsAccount(string acctNo)
	{
		if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
		else 
		if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
		else
			throw new ArgumentException("Invalid Acct Number");
	}
}
