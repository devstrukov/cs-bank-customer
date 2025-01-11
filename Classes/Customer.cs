using cs_bank_customer.Interfaces;

namespace cs_bank_customer.Classes;

public class Customer : ICustomer
{
    private string firstname { get; set; }
    private string surname { get; set; }
    private string birthdate { get; set; }
    private string? address { get; set; }
    private string? email { get; set; }
    private int? phone { get; set; }
    private decimal balance { get; set; } = 0;
    private List<ILoan> loans { get; set; } = new List<ILoan>();
    private List<ICredit> credits { get; set; } = new List<ICredit>();

    public Customer(string firstname, string surname, string birthdate)
    {
        this.firstname = firstname;
        this.surname = surname;
        this.birthdate = birthdate;
    }

    public Customer(string firstname, string surname, string birthdate, string address)
    {
        this.firstname = firstname;
        this.surname = surname;
        this.birthdate = birthdate;
        this.address = address;
    }

    public Customer(string firstname, string surname, string birthdate, string address, int phone)
    {
        this.firstname = firstname;
        this.surname = surname;
        this.birthdate = birthdate;
        this.address = address;
        this.phone = phone;
    }

    public string GetFullInfo()
    {
        string fullInfo = "";
        
        fullInfo += $"ФИО: {this.GetFirstName()} {this.GetSurname()} \n";
        fullInfo += $"Дата рождения: {this.GetBirthdate()} \n";
        fullInfo += $"Текущий баланс: {this.GetBalance()} \n";
        fullInfo += $"Ежемесячная прибыль клиента: {this.GetMonthlyIncome()} \n";
        fullInfo += $"Имеется задолженность: {(this.IsDebtor() ? "Да" : "Нет")} \n";

        if (this.GetAddress() != null)
        {
            fullInfo += $"Адрес: {this.GetAddress()} \n";
        }

        if (this.GetPhone() != null)
        {
            fullInfo += $"Телефон: {this.GetPhone()} \n";
        }

        if (this.GetEmail() != null)
        {
            fullInfo += $"Email: {this.GetEmail()} \n";
        }
        
        return fullInfo;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }

    public List<ICredit> GetCredits()
    {
        return credits;
    }

    public List<ILoan> GetLoans()
    {
        return loans;
    }

    public bool IsDebtor()
    {
        foreach (ICredit credit in credits)
        {
            if (credit.IsOverdue()) return true;
        }

        return false;
    }

    public void SetCredits(List<ICredit> credits)
    {
        this.credits = credits;
    }

    public void SetLoans(List<ILoan> loans)
    {
        this.loans = loans;
    }

    public decimal GetMonthlyIncome()
    {
        decimal income = 0;

        foreach (ILoan loan in loans)
        {
            income += loan.GetMonthlyIncome();
        }

        foreach (ICredit credit in credits)
        {
            income += credit.GetMonthlyPayment();
        }
        
        return income;
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetEmail()
    {
        return email;
    }

    public int? GetPhone()
    {
        return phone;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public void SetPhone(int phone)
    {
        this.phone = phone;
    }

    public string GetFirstName()
    {
        return firstname;
    }

    public string GetSurname()
    {
        return surname;
    }

    public string? GetBirthdate()
    {
        return birthdate;
    }
}