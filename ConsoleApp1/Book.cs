using System;

namespace ConsoleApp1
{
    public class Book : EducationalMaterial
    {
        private int _pages;
        private string _isbn;

        public int Pages
        {
            get => _pages;
            set => _pages = value;
        }

        public string ISBN
        {
            get => _isbn;
            set => _isbn = value;
        }

        public Book(string title, string author, int pages, string isbn)
            : base(title, author)
        {
            _pages = pages;
            _isbn = isbn;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Страницы: {Pages}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine(new string('-', 30));
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"[Book] {Title}, {Author}, {Pages}, {ISBN}");
        }
    }
}
