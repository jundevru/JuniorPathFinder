using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore.Heuristics
{
    public interface IHeuristic2D
    {
        double GetHeuristic(Vector2i from, Vector2i to);
    }
}
