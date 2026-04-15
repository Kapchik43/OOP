using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class LibraryExtensions
    {
        public static List<EducationalMaterial> FindByAuthor(this Library<EducationalMaterial> library, string author)
        {
            List<EducationalMaterial> result = new List<EducationalMaterial>();

            foreach (EducationalMaterial material in library.GetAllMaterials())
            {
                if (string.Equals(material.Author, author, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(material);
                }
            }

            return result;
        }
    }
}