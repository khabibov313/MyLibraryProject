using MyLibraryProject.İnterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryProject.DataModels
{
    public class AuthorRepository: IAuthorRepository
    {
        private List<Author> authors = new List<Author>();
        private int currentId = 1;

        public void Add(Author author)
        {
            author.Id = currentId++;
            authors.Add(author);
        }

        public void Update(Author author)
        {
            var existingAuthor = GetById(author.Id);
            existingAuthor.Name = author.Name;
            existingAuthor.Surname = author.Surname;
        }

        public void Delete(int id)
        {
            var author = GetById(id);
            authors.Remove(author);
        }

        public Author GetById(int id)
        {
            return authors.FirstOrDefault(a => a.Id == id);
        }

        public List<Author> GetAll()
        {
            return authors;
        }

        public List<Author> FindByName(string name)
        {
            return authors.Where(a => a.Name.Contains(name)).ToList();
        }
    }
}
