namespace ReproGallery.Models;

public interface IAuthorRepository
{
    IEnumerable<Author> AllAuthors { get; }
    Author? GetAuthorById(int authorId);
}
