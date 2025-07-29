using System.Collections.Generic;

namespace Day8_2nd_Assignment
{
    public class Library
    {
        public List<Book> Books { get; } = new List<Book>();
        public List<Borrower> Borrowers { get; } = new List<Borrower>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.Find(b => b.ISBN == isbn);
            var borrower = Borrowers.Find(b => b.LibraryCardNumber == libraryCardNumber);
            if (book != null && borrower != null && !book.IsBorrowed)
            {
                book.IsBorrowed = true;
                borrower.BorrowedBooks.Add(book);
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = Books.Find(b => b.ISBN == isbn);
            var borrower = Borrowers.Find(b => b.LibraryCardNumber == libraryCardNumber);
            if (book != null && borrower != null && book.IsBorrowed)
            {
                book.IsBorrowed = false;
                borrower.BorrowedBooks.Remove(book);
            }
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; } = false;
    }

    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<Book> BorrowedBooks { get; } = new List<Book>();
    }
}
