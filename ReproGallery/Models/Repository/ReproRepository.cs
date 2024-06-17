using Microsoft.EntityFrameworkCore;

namespace ReproGallery.Models;

public class ReproRepository : IReproRepository
{
    private readonly ReproGalleryContext _context;

    public ReproRepository(ReproGalleryContext context)
    {
        _context = context;
    }

    public IEnumerable<Repro> AllRepros => _context.Repros.Include(a => a.Author).Include(c => c.Category).OrderBy(r => r.Name);

    public Repro? GetReproById(int reproId)
    {
        return _context.Repros.Include(a => a.Author).Include(c => c.Category).FirstOrDefault(r => r.ReproId == reproId);
    }
}
