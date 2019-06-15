// Оптимальный поиск пути - сравнитель

namespace JuniorPathFinderCore.Comparers
{
    public class OptimalRegion2DItemsComparer : IRegion2DItemComparer
    {
        public int Compare(RegionItem x, RegionItem y)
        {
            if (x.g + x.f > y.g + y.f)
                return 1;
            else if (x.g + x.f < y.g + y.f)
                return -1;
            return 0;
        }
    }
}
