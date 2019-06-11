using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore
{
    public class LayersValues
    {
        int[] list = new int[32];

        public void AddValue(Layers layer, int value)
        {
            list[(int)layer] = value;
        }

        public int GetValue(Layers layer)
        {
            return list[(int)layer];
        }

    }
}
