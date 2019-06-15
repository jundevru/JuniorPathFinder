// Интерфейс Эвристик

namespace JuniorPathFinderCore.Heuristics
{
    public interface IHeuristic2D
    {
        double GetHeuristic(Vector2i from, Vector2i to);
    }
}
