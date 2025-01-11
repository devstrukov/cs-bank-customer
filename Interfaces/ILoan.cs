namespace cs_bank_customer.Interfaces;

public interface ILoan
{
    public decimal GetLoanAmount();
    public string GetLoanDescription();
    public bool IsExpired();
    public decimal GetMonthlyIncome();
}