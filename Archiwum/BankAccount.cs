using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstyBank
{
    class BankAccount
    {
        private List<Transaction> AllTransactions = new List<Transaction>();

        private static UInt32 accountNumberSeed = 23232323;
        public UInt32 Number { get; }
        public string Owner { get; set; }
        private decimal balance;

        public decimal Balance
        {
            get {
                decimal transactionSum = 0;
                foreach (var transaction in AllTransactions)
                {
                    transactionSum += transaction.Amount;
                }
                return transactionSum + balance;
            }
            set { balance = value; }
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed++;
            Console.WriteLine($"Utworzono nowe kontro z saldem: {initialBalance}");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Console.WriteLine($"Dokonano wpłaty o kwtocie: {amount}");
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Nie można wpłacić kwoty ujemnej");
            }

            Transaction deposit = new Transaction(amount, date, note);
            AllTransactions.Add(deposit);
        }

        public void MakeWithdraw(decimal amount, DateTime date, string note)
        {

        }

        public void ListTransactionHistory()
        {

        }

        public void DisplayInfo()
        {

        }

    }
}
