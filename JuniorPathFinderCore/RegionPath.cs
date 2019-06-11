using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore
{
    public class RegionPath
    {

        private List<PathItem> list = new List<PathItem>();

        public int Count => list.Count;

        public void Add(PathItem item)
        {
            list.Add(item);
        }



    }
}
