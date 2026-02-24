using System;

namespace ConsoleApp1
{
	public abstract class EducationalMaterial
	{
		private string _title;
		protected string _author;

		public string title
		{
			get => _title;
			set => _title = value;
		}

		public string author
		{
			get => _author;
			set => _author = value;
		}

		protected EducationalMaterial(string title, string author)
		{
			_title = title;
			_author = author;
		}

		public virtual void print()
		{
			Console.WriteLine($"title: {title}");
			Console.WriteLine($"author: {author}");
		}

		public abstract void DisplayContent();
	}
}