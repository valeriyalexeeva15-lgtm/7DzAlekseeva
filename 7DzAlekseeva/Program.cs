namespace _7DzAlekseeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Book book1 = new Book();
            //Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            //book1.PrintInfo();
            //book2.PrintInfo();

            //2
            //BankAccount1 account = new BankAccount1("123456789");

            ////Пополняем 1000₽
            //account.Deposit(1000);

            ////Снимаем 500₽
            //account.Withdraw(500);

            ////Выводим баланс
            //account.PrintBalance();

            //3
            //Car car = new Car("Tesla Model S", 250);

            //car.Accelerate(120);
            //Console.WriteLine($"Модель: {car.Model}, Текущая скорость: {car.Speed} км/ч");

            //car.Brake();
            //Console.WriteLine($"После торможения: {car.Speed} км/ч");

            //4
            //Dice1 dice6 = new Dice1();
            //Dice1 dice12 = new Dice1(12);

            //Console.Write("6-гранный кубик: ");
            //Console.Write($"{dice6.Roll()}, {dice6.Roll()}, {dice6.Roll()}");

            //Console.WriteLine();

            //Console.Write("12-гранный кубик: ");
            //Console.Write($"{dice12.Roll()}, {dice12.Roll()}, {dice12.Roll()}");

            //5
            Character warrior = new Character("Воин", 100, 20);
            Character mage = new Character("Маг", 60, 100);
            Character archer = new Character("Лучник", 80, 50);

            warrior.Attack();
            mage.Attack();
            archer.Attack();
        }
    }
}





