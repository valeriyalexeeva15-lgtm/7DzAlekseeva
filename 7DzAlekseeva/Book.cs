using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DzAlekseeva
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public bool IsAvailable;
        public void PrintInfo()
        {
            Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {(IsAvailable ? "Да" : "Нет")}");
        }
        public Book(string title, string author, int year, bool isAvailable)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }
        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестен";
            Year = 0;
            IsAvailable = false;
        }
    }
}

