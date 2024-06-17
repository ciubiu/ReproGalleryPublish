namespace ReproGallery.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly ReproGalleryContext _context;

    public CategoryRepository(ReproGalleryContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> AllCategories => _context.Categories.OrderBy(c => c.Name);

    public Category? GetCategoryById(int categoryId)
    {
        return _context.Categories.FirstOrDefault(r => r.CategoryId == categoryId);
    }
}

