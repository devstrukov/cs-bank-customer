namespace cs_bank_customer.Interfaces;

public interface ICustomer
{
    public string GetFirstName();
    public string GetSurname();
    public string? GetEmail();
    public int? GetPhone();
    public string? GetAddress();
    public string? GetBirthdate();
    public void SetAddress(string address);
    public void SetEmail(string email);
    public void SetPhone(int phone);
    public List<ICredit> GetCredits();
    public List<ILoan> GetLoans();
    public void SetLoans(List<ILoan> loans);
    public void SetCredits(List<ICredit> credits);
    public bool IsDebtor();
    public void SetBalance(decimal balance);
    public decimal GetBalance();
    public decimal GetMonthlyIncome();
    public string GetFullInfo();
}