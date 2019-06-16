// Оптимальный поиск пути - сравнитель

namespace JuniorPathFinderCore.Comparers
{
    public class ShortestRegion2DItemsComparer : IRegion2DItemComparer
    {
        public int Compare(RegionItem x, RegionItem y)
        {
            if (x.f > y.f)
                return 1;
            else if (x.f < y.f)
                return -1;
            return 0;
        }
    }
}
