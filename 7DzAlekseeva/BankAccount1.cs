using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DzAlekseeva
{
    internal class BankAccount1
    {
        public string AccountNumber;
        private decimal Balance;  // приват. поле

        //пополнение счета
        public void Deposit(decimal amount)
        {
            this.Balance = this.Balance + amount;
        }

        //снятие денег
        public void Withdraw(decimal amount)
        {
            if (amount <= this.Balance)  //хватает ли средств
            {
                this.Balance = this.Balance - amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }

        //вывод баланса
        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {this.Balance}р");
        }

        public BankAccount1(string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }
    }
}
