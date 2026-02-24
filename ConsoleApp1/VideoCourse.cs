using System;

namespace ConsoleApp1
{
	public class VideoCourse : EducationalMaterial
	{
		private int _durationMinutes;
		private string _link;

		public int durationMinutes
		{
			get => _durationMinutes;
			set => _durationMinutes = value;
		}

		public string link
		{
			get => _link;
			set => _link = value;
		}

		public VideoCourse(string title, string author, int durationMinutes, string link)
			: base(title, author)
		{
			_durationMinutes = durationMinutes;
			_link = link;
		}

		public override void print()
		{
			base.print();
			Console.WriteLine($"durationMinutes: {durationMinutes}");
			Console.WriteLine($"link: {link}");
			Console.WriteLine(new string('-', 25));
		}

		public override void DisplayContent()
		{
			Console.WriteLine($"[VIDEO] {title} ({durationMinutes} min) -> {link}");
		}
	}
}