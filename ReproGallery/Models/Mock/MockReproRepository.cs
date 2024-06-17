namespace ReproGallery.Models;

public class MockReproRepository : IReproRepository
{
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
    private readonly IAuthorRepository _authorRepository = new MockAuthorRepository();

    public IEnumerable<Repro> AllRepros => new List<Repro>
    {
        new Repro { ReproId = 1, Name = "Repro 1", Description = "Description 1", Category = _categoryRepository.AllCategories.ToList()[0], Author = _authorRepository.AllAuthors.ToList()[0] },
        new Repro { ReproId = 2, Name = "Repro 2", Description = "Description 2", Category = _categoryRepository.AllCategories.ToList()[1], Author = _authorRepository.AllAuthors.ToList()[1] },
        new Repro { ReproId = 3, Name = "Repro 3", Description = "Description 3", Category = _categoryRepository.AllCategories.ToList()[2], Author = _authorRepository.AllAuthors.ToList()[2] }
    };

    public Repro? GetReproById(int reproId)
    {
        return AllRepros.FirstOrDefault(r => r.ReproId == reproId);
    }
}
