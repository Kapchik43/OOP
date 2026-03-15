using System;

namespace ConsoleApp1
{
    public abstract class EducationalMaterial
    {
        private string _title;
        private string _author;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        protected EducationalMaterial(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
        }

        public abstract void DisplayContent();
    }
}
