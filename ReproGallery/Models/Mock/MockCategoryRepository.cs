namespace ReproGallery.Models;

public class MockCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories => new List<Category>
    {
        new Category { CategoryId = 1, Name = "Abstract", Description = "Description 1" },
        new Category { CategoryId = 2, Name = "People", Description = "Description 2" },
        new Category { CategoryId = 3, Name = "Landscape", Description = "Description 3" }
    };


    public Category? GetCategoryById(int categoryId)
    {
        return AllCategories.FirstOrDefault(c => c.CategoryId == categoryId);
    }
}
