using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Library<EducationalMaterial> library = new Library<EducationalMaterial>();

            library.AddMaterial(new Book("Чистый код", "Роберт Мартин", 464, "978-5-496-00487-9"));
            library.AddMaterial(new VideoCourse("Основы C#", "Иван Петров", 95, "https://example.com/csharp-course"));
            library.AddMaterial(new Article("ООП в современных приложениях", "Анна Смирнова", "Программирование сегодня", 2024));

            Console.WriteLine("Содержимое всех материалов:");
            library.ShowAllContents();

            Console.WriteLine();
            Console.WriteLine("Полная информация о материалах:");
            library.PrintAll();

            Console.WriteLine("Поиск материала по названию:");
            EducationalMaterial? foundMaterial = library.FindByTitle("Основы C#");

            if (foundMaterial != null)
            {
                foundMaterial.Print();
            }
            else
            {
                Console.WriteLine("Материал не найден.");
            }

            Console.WriteLine($"Всего материалов: {Library<EducationalMaterial>.MaterialsCount}");
        }
    }
}
