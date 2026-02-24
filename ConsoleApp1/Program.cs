using System.Collections.Generic;
using ConsoleApp1;

List<EducationalMaterial> materials = new List<EducationalMaterial>();

materials.Add(new Book("0121234324", "OOP Book", "Amankulov", 320));
materials.Add(new VideoCourse("C# Course", "Petrov", 95, "https://example.com"));
materials.Add(new Article("Inheritance vs Composition", "Smirnov", "SE Notes", 2024));

foreach (EducationalMaterial m in materials)
{
	m.DisplayContent();
    m.print();
}