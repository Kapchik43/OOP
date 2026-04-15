using System;

namespace ConsoleApp1
{
    public class VideoCourse : EducationalMaterial
    {
        private int _duration;
        private string _link;

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public string Link
        {
            get => _link;
            set => _link = value;
        }

        public VideoCourse(string title, string author, int duration, string link)
            : base(title, author)
        {
            _duration = duration;
            _link = link;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длительность: {Duration} мин.");
            Console.WriteLine($"Ссылка: {Link}");
            Console.WriteLine(new string('-', 30));
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"[VideoCourse] {Title}, {Author}, {Duration}, {Link}");
        }

        public static VideoCourse operator ++(VideoCourse course)
        {
            course.Duration += 10;
            return course;
        }
    }
}