using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Book
	{
		private string _isbn;
		private string _title;
		private string _author;
		private int _year;
		private bool _status;

		public string isbn
		{
			get => _isbn;
			set => _isbn = value;
		}
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

		public int year
		{
			get => _year;
			set => _year = value;
		}
		public bool status => _status;
		public Book(string isbn, string title, string author, int year, bool status)
		{
			_isbn = isbn;
			_title = title;
			_author = author;
			_year = year;
			_status = status;
		}
		public bool Borrow()
		{
			if (_status)
			{
				_status = false;
				return true;
			}
			return false;
		}
		public bool Return()
		{
			if (_status == false)
			{
				_status = true;
				return true;
			}
			return false;
		}
		public void print()
		{
			Console.WriteLine($"isbn: {isbn}");
			Console.WriteLine($"title: {title}");
			Console.WriteLine($"author: {author}");
			Console.WriteLine($"year: {year}");
			Console.WriteLine($"status: {status}");
			Console.WriteLine(new string('-', 25));
		}
	}
}
