using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Library<T> where T : EducationalMaterial
    {
        private readonly List<T> _materials = new List<T>();
        private static int _materialsCount;

        public static int MaterialsCount { get => _materialsCount;}

        public void AddMaterial(T material)
        {
            _materials.Add(material);
            _materialsCount++;
        }

        public T? FindByTitle(string title)
        {
            foreach (T material in _materials)
            {
                if (string.Equals(material.Title, title))
                {
                    return material;
                }
            }

            return null;
        }

        public void ShowAllContents()
        {
            foreach (T material in _materials)
            {
                material.DisplayContent();
            }
        }
    }
}
