using BookServiceAPI.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace BookServiceAPI.Repository
{
    public class BookRepository : IBookReposiotry
    {
        public static List<Book> books = new List<Book>()
        {
            new Book() {BookId = 435 ,BookName = "Aaa" , Author = "aaa" , Language ="English" , price = 233.50 , Publisher = "aaa",Year =1999  },
        };
       
        //add book
        public void AddBook(Book book)
        {
            try
            {
                books.Add(book);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        //delete book
        public void DeleteBook(int id)
        {
            try
            {
                foreach (Book book in books)
                {
                    if (book.BookId == id)
                    {
                        books.Remove(book);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        //update book
        public void EditBook(Book book)
        {
            try
            {
                foreach(Book book1 in books)
                {
                    if(book1.BookId == book.BookId)
                    {
                        book1.BookName = book.BookName;
                        book1.Author = book.Author;
                        book1.price = book.price;
                        book1.Publisher = book.Publisher;
                        break;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public List<Book> GetBooksByAuthor(string author)
        {
            List<Book> booksByAuthor = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.Author == author)
                    {
                        booksByAuthor.Add(book);
                        

                    }
                    
                }
                return booksByAuthor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksById(int id)
        {
            List<Book> booksByLanguage = new List<Book>();

            try
            {
                foreach(var book in books)
                {
                    if(book.BookId == id)
                    {
                        booksByLanguage.Add(book);
                    }
                }
                return booksByLanguage;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByLanguage(string language)
        {
            List<Book> booksByLanguage = new List<Book>();

            try
            {
                foreach (var book in books)
                {
                    if (book.Language == language)
                    {
                        booksByLanguage.Add(book);
                        

                    }
                }
                return booksByLanguage;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get books by name
        public List<Book> GetBooksByName(string name)
        {
            List<Book> booksByName = new List<Book>();

            try
            {
                foreach (var book in books)
                {
                    if (book.BookName == name)
                    {
                        booksByName.Add(book);


                    }
                }
                return booksByName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get boos by year
        public List<Book> GetBooksByYear(int year)
        {
            List<Book> booksByYear = new List<Book>();

            try
            {
                foreach (var book in books)
                {
                    if (book.Year == year)
                    {
                        booksByYear.Add(book);
                    
                    }
                    
                }
                return booksByYear;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
