using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Library<EducationalMaterial> library = new Library<EducationalMaterial>();

            Book book1 = new Book("книга 1", "автор1", 464, "9785496004879");
            Book book2 = new Book("книга 2", "автор2", 300, "1234567890123");
            VideoCourse videoCourse = new VideoCourse("видеокурс", "автор1", 95, "ссылка");
            Article article = new Article("статья", "автор3", "журнал", 2026);

            library.AddMaterial(book1);
            library.AddMaterial(book2);
            library.AddMaterial(videoCourse);
            library.AddMaterial(article);

            Console.WriteLine("ShowAllContents():");
            library.ShowAllContents();
            Console.WriteLine();

            Console.WriteLine("FindByTitle():");
            EducationalMaterial? foundMaterial = library.FindByTitle("книга 1");

            if (foundMaterial != null)
            {
                foundMaterial.Print();
            }
            else
            {
                Console.WriteLine("материал не найден");
            }

            Console.WriteLine();

            Console.WriteLine("Сравнение книг по страницам:");
            if (book1 > book2)
            {
                Console.WriteLine($"\"{book1.Title}\" больше, чем \"{book2.Title}\"");
            }
            else
            {
                Console.WriteLine($"\"{book2.Title}\" больше, чем \"{book1.Title}\"");
            }

            Console.WriteLine();

            Console.WriteLine("VideoCourse до ++:");
            videoCourse.Print();

            videoCourse++;

            Console.WriteLine("VideoCourse после ++:");
            videoCourse.Print();

            Console.WriteLine();

            Console.WriteLine("FindByAuthor(\"автор1\"):");
            List<EducationalMaterial> materialsByAuthor = library.FindByAuthor("автор1");

            if (materialsByAuthor.Count > 0)
            {
                foreach (EducationalMaterial material in materialsByAuthor)
                {
                    material.Print();
                }
            }

            Console.WriteLine($"Всего материалов: {Library<EducationalMaterial>.MaterialsCount}");
        }
    }
}