using MyLibraryProject.İnterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryProject.DataModels
{
    public class BookRepository: IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int currentId = 1;

        public void Add(Book book)
        {
            book.Id = currentId++;
            books.Add(book);
        }

        public void Update(Book book)
        {
            var existingBook = GetById(book.Id);
            existingBook.Name = book.Name;
            existingBook.AuthorId = book.AuthorId;
            existingBook.Genres = book.Genres;
            existingBook.PageCount = book.PageCount;
            existingBook.Price = book.Price;
        }

        public void Delete(int id)
        {
            var book = GetById(id);
            books.Remove(book);
        }

        public Book GetById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public List<Book> FindByName(string name)
        {
            return books.Where(b => b.Name.Contains(name)).ToList();
        }

    }
}
