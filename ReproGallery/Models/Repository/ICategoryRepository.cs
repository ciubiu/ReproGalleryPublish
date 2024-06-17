namespace ReproGallery.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
    Category? GetCategoryById(int categoryId);
}
