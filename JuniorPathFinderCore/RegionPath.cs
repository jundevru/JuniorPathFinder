// Найденный путь
using System.Collections;
using System.Collections.Generic;


namespace JuniorPathFinderCore
{
    public class RegionPath : IEnumerable
    {
        private List<PathItem>  list    =   new List<PathItem>();
        public int              Count   =>  list.Count;

        public void Add(PathItem item)
        {
            list.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (PathItem item in list)
                yield return item;
        }
    }
}
