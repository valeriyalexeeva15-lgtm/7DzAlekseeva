namespace _7DzAlekseeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book();
            //Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            //book1.PrintInfo();
            //book2.PrintInfo();
            BankAccount1 account = new BankAccount1("123456789");

            //Пополняем 1000₽
            account.Deposit(1000);

            //Снимаем 500₽
            account.Withdraw(500);

            //Выводим баланс
            account.PrintBalance();
        }
    }
}


