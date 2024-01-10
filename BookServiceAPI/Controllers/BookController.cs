using BookServiceAPI.Repository;
using BookServiceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookReposiotry bookRepo;

        public BookController()
        {
           bookRepo = new BookRepository();
        }

        //get all books
        [HttpGet, Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> book = bookRepo.GetAllBooks();

                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Add books

        [HttpPost, Route("AddBook")]
        public IActionResult AddBook(Book book)
        {
            try
            {
                bookRepo.AddBook(book);
                return StatusCode(200, "book added succesfully");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Delete book
        [HttpDelete, Route("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookRepo.DeleteBook(id);
                return StatusCode(200, "Book deleted successfully");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //get books by author
        [HttpGet,Route("GetBookbyAuthor/{author}")]
        public IActionResult GetBookByAuhtor(string author) 
        {
            
            try
            {
               
                return StatusCode(200, bookRepo.GetBooksByAuthor(author));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //get book by language

        [HttpGet,Route("GetBookByLanguage/{lang}")]
        public IActionResult GetBookByLanguage(string lang)
        {
            try
            {
                return StatusCode(200,bookRepo.GetBooksByLanguage(lang));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //get book by year

        [HttpGet,Route("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            try
            {
                return StatusCode(200, bookRepo.GetBooksByYear(year));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        //update book 
        [HttpPut,Route("Editbook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookRepo.EditBook(book);
                return StatusCode(200, book);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //get book by name
        [HttpGet,Route("GetBookByName/{name}")]
        public IActionResult GetBookByName(string name)
        {
            try
            {
               
                return StatusCode(200, bookRepo.GetBooksByName(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get book by id
        [HttpGet, Route("GetBookById/{id}")]
        public IActionResult GetBookById(int id)
        {
            try
            {

                return StatusCode(200, bookRepo.GetBooksById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
