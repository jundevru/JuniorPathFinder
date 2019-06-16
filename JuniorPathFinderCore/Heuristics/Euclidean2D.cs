using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore.Heuristics
{
    public class Euclidean2D : IHeuristic2D
    {
        public double GetHeuristic(Vector2i from, Vector2i to)
        {
            return Math.Sqrt(Math.Pow((from.x - to.x), 2) + Math.Pow((from.y - to.y), 2));
        }
    }
}
