using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore.Heuristics
{
    public class Manhatan2D : IHeuristic2D
    {
        public double GetHeuristic(Vector2i from, Vector2i to)
        {
            return Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);
        }
    }
}
