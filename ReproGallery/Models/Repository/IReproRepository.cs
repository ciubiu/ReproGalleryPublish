namespace ReproGallery.Models;

public interface IReproRepository
{
    IEnumerable<Repro> AllRepros { get; }
    Repro? GetReproById(int reproId);
}
