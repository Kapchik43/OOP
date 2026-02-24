using System;

namespace ConsoleApp1
{
	public class Book : EducationalMaterial
	{
		private string _isbn;
		private int _pages;

		public string isbn
		{
			get => _isbn;
			set => _isbn = value;
		}

		public int pages
		{
			get => _pages;
			set => _pages = value;
		}

		public Book(string isbn, string title, string author, int pages) : base(title, author)
		{
			_isbn = isbn;
			_pages = pages;
		}

		public override void print()
		{
			base.print();
			Console.WriteLine($"isbn: {isbn}");
			Console.WriteLine($"pages: {pages}");
			Console.WriteLine(new string('-', 25));
		}

		public override void DisplayContent()
		{
			Console.WriteLine($"[BOOK] {title} by {_author}");
		}
	}
}