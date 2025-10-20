namespace _7DzAlekseeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            book1.PrintInfo();
            book2.PrintInfo();
        }
    }
}
