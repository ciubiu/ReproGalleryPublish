namespace ReproGallery.Models;

public class MockAuthorRepository : IAuthorRepository
{
    public IEnumerable<Author> AllAuthors => new List<Author>
    {
        new Author { AuthorId = 1, Name = "Author 1" },
        new Author { AuthorId = 2, Name = "Author 2" },
        new Author { AuthorId = 3, Name = "Author 3" },
        new Author { AuthorId = 4, Name = "Author 4" },
        new Author { AuthorId = 5, Name = "Author 5" }
    };

    public Author? GetAuthorById(int authorId)
    {
        return AllAuthors.FirstOrDefault(a => a.AuthorId == authorId);
    }
}
