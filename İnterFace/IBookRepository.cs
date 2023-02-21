using MyLibraryProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryProject.İnterFace
{
    public  interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
        Book GetById(int id);
        List<Book> GetAll();
        List<Book> FindByName(string name);
    }
}
