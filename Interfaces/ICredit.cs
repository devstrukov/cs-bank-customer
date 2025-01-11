namespace cs_bank_customer.Interfaces;

public interface ICredit
{
    public decimal GetCreditAmount();
    public string GetDescription();
    public decimal GetRest();
    public decimal GetRate();
    public bool IsFinished();
    public bool IsOverdue();
    public decimal GetMonthlyPayment();
}