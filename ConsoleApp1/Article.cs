using System;

namespace ConsoleApp1
{
    public class Article : EducationalMaterial
    {
        private string _journal;
        private int _year;

        public string Journal
        {
            get => _journal;
            set => _journal = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public Article(string title, string author, string journal, int year)
            : base(title, author)
        {
            _journal = journal;
            _year = year;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Журнал: {Journal}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine(new string('-', 30));
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"[СТАТЬЯ] {Title} — {Author}, журнал: {Journal}, год: {Year}");
        }
    }
}
