using BookServiceAPI.Models;
namespace BookServiceAPI.Repository
{
    public interface IBookReposiotry
    {
        void AddBook(Book book);

        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByLanguage(string language);
        List<Book> GetBooksByYear(int date);
        List<Book> GetBooksById(int id);
        List<Book> GetBooksByName(string name);

        void EditBook(Book book);

        void DeleteBook(int id);




    }
}
