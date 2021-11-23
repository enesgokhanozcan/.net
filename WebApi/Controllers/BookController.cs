using Microsoft.AspNetCore.Mvc;

namespace WebApi.AddCntrollers
{

    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book{
                Id=1,
                Title="Brave New World",
                GenreId=1,
                PageCount=250,
                PublisDate= new DateTime(2021,01,01)
            },
            new Book{
                Id=2,
                Title="Homo Deus: A Brief History of Tomorrowd",
                GenreId=2,
                PageCount=300,
                PublisDate= new DateTime(2021,01,01)
            },
            new Book{
                Id=3,
                Title="Dune",
                GenreId=3,
                PageCount=700,
                PublisDate= new DateTime(2021,01,01)
            },

        };
        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x=>x.Id).ToList<Book>();
            return bookList;
        }
        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book=>book.Id==id).SingleOrDefault();
            return book;
        }
    }
}