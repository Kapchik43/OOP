using ConsoleApp1;

string isbn = "0121234324", title = "OOP", author = "Amankulov";
int year = 2026;
bool status = true;

Book b = new Book(isbn, title, author, year, status);
b.print();
b.Borrow();
b.print();
b.Return();
b.print();