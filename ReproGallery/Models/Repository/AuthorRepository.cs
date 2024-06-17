
namespace ReproGallery.Models;

public class AuthorRepository : IAuthorRepository
{
    private readonly ReproGalleryContext _context;

    public AuthorRepository(ReproGalleryContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Author> AllAuthors => _context.Authors.OrderBy(c => c.Name);

    public Author? GetAuthorById(int authorId)
    {
        return _context.Authors.FirstOrDefault(r => r.AuthorId == authorId);
    }
}
