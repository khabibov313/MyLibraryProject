using MyLibraryProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryProject.İnterFace
{
    public interface IAuthorRepository
    {
        void Add(Author author);
        void Update(Author author);
        void Delete(int id);
        Author GetById(int id);
        List<Author> GetAll();
        List<Author> FindByName(string name);
    }
}
