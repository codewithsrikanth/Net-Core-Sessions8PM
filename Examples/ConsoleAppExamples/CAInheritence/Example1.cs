using System;

namespace CAInheritence
{
    public class Account
    {
        public string accountNumber;
        public decimal balance;

        public Account(string accNo,decimal openingBal)
        {
            accountNumber = accNo;
            balance = openingBal;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C} Balance: {balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
    public class SavingsAccount : Account
    {
        public decimal interestRate;
        public SavingsAccount(string accNo, decimal openingBal, decimal rate):base(accNo,openingBal)
        {
            interestRate = rate;
        }
        public void ApplyInerest()
        {
            decimal intrs = balance * interestRate / 100;
            Deposit(intrs);
            Console.WriteLine($"Intreset applied :{intrs:C}");
        }
    }
    public class SalaryAccount: SavingsAccount
    {
        public string empName;
        public decimal minBal = 0;
        public SalaryAccount(string accNo, decimal openingBal, decimal rate,string empName) :base(accNo,openingBal,rate)
        {
            this.empName = empName;
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            SalaryAccount s1 = new SalaryAccount("12345", 20000, 12, "Srikanth");
            s1.Deposit(12000);
        }
    }
}
