using NUnit.Framework;
using Day8_Assignment2;
using System.Linq;

namespace BookTest.UnitTest
{
    public class UnitTest1
    {
        private Library _library = null!;

        [SetUp]
        public void Setup()
        { 
            _library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var book = new Book { Title = "Test Book", Author = "Author", ISBN = "123" };
            _library.AddBook(book);
            Assert.Contains(book, _library.Books);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToLibrary()
        {
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "LIB123" };
            _library.RegisterBorrower(borrower);
            Assert.Contains(borrower, _library.Borrowers);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed_AndAssociateWithBorrower()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "CARD001" };

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);
            _library.BorrowBook("001", "CARD001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable_AndRemoveFromBorrower()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "CARD001" };

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);
            _library.BorrowBook("001", "CARD001");
            _library.ReturnBook("001", "CARD001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.IsFalse(borrower.BorrowedBooks.Contains(book));
        }

        [Test]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var book = new Book { Title = "Book", Author = "Author", ISBN = "001" };
            _library.AddBook(book);
            var books = _library.ViewBooks();
            Assert.Contains(book, books);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "CARD001" };
            _library.RegisterBorrower(borrower);
            var borrowers = _library.ViewBorrowers();
            Assert.Contains(borrower, borrowers);
        }
    }
}