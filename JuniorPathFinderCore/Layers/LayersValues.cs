// Содержит веса слоев

namespace JuniorPathFinderCore
{
    public class LayersValues
    {
        private int[]   list    =   new int[32];

        /// <summary>
        /// Задает вес для указанного слоя
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="value"></param>
        public void AddValue(Layers layer, int value)
        {
            list[(int)layer] = value;
        }
        /// <summary>
        /// Возвращает вес для указанного слоя
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public int GetValue(Layers layer)
        {
            return list[(int)layer];
        }

    }
}
