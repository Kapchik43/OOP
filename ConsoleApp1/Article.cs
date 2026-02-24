using System;

namespace ConsoleApp1
{
	public class Article : EducationalMaterial
	{
		private string _journal;
		private int _year;

		public string journal
		{
			get => _journal;
			set => _journal = value;
		}

		public int year
		{
			get => _year;
			set => _year = value;
		}

		public Article(string title, string author, string journal, int year)
			: base(title, author)
		{
			_journal = journal;
			_year = year;
		}

		public override void print()
		{
			base.print();
			Console.WriteLine($"journal: {journal}");
			Console.WriteLine($"year: {year}");
			Console.WriteLine(new string('-', 25));
		}

		public override void DisplayContent()
		{
			Console.WriteLine($"[ARTICLE] {title} ({journal}, {year})");
		}
	}
}