using MyLibraryProject.DataModels;
using MyLibraryProject.İnterFace;

namespace MyLibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create author repository
            IAuthorRepository authorRepository = new AuthorRepository();

            // Add an author
            var author1 = new Author { Name = "John", Surname = "Doe" };
            authorRepository.Add(author1);
            Console.WriteLine($"{author1.Name}{author1.Surname}");
        }
    }
}