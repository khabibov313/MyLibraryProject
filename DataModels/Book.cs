using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryProject.DataModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public List<string> Genres { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
    }
}
