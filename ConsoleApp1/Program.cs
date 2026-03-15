using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Library<EducationalMaterial> library = new Library<EducationalMaterial>();

            library.AddMaterial(new Book("книга", "автор1", 464, "9785496004879"));
            library.AddMaterial(new VideoCourse("видеокурс", "автор2", 95, "ссылка"));
            library.AddMaterial(new Article("статья", "автор3", "журнал", 2026));

            Console.WriteLine("ShowAllContents():");
            library.ShowAllContents();

            Console.WriteLine("FindByTitle():");
            EducationalMaterial? foundMaterial = library.FindByTitle("книга");

            if (foundMaterial != null)
            {
                foundMaterial.Print();
            }
            else
            {
                Console.WriteLine("материал не найден");
            }

            Console.WriteLine($"всего материалов: {Library<EducationalMaterial>.MaterialsCount}");
        }
    }
}
