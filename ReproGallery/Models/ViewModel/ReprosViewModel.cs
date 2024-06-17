namespace ReproGallery.Models;

public class ReprosViewModel
{
    public IEnumerable<Repro> Repros { get; }
    public string? CurrentCategory { get; }
    public IEnumerable<Category> AllCategories { get; set; }

    public ReprosViewModel(IEnumerable<Repro> repros, string? currentCategory)
    {
        Repros = repros;
        CurrentCategory = currentCategory;
        AllCategories = new List<Category>();
    }
}
