using Microsoft.AspNetCore.Mvc;
using ReproGallery.Models;

namespace ReproGallery.Controllers;

public class ReproController : Controller
{
    private readonly IReproRepository _reproRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ReproController(IReproRepository reproRepository, IAuthorRepository authorRepository, ICategoryRepository categoryRepository)
    {
        _reproRepository = reproRepository;
        _authorRepository = authorRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List(string category)
    {
        IEnumerable<Repro> repros;
        ReprosViewModel reprosViewModel;
        ;

        string? selectedCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category)?.Name;

        if (!string.IsNullOrEmpty(category) && selectedCategory != null)
        {
            repros = _reproRepository.AllRepros.Where(r => r.Category.Name == category);
            reprosViewModel = new ReprosViewModel(repros, category);
        }
        else
        {
            reprosViewModel = new ReprosViewModel(_reproRepository.AllRepros, "");
        }

        reprosViewModel.AllCategories = _categoryRepository.AllCategories;

        return View(reprosViewModel);
    }

    public IActionResult Details(int id)
    {
        Repro? repro = _reproRepository.GetReproById(id);

        if (repro == null)
        {
            return NotFound();
        }

        return View(repro);
    }
}
