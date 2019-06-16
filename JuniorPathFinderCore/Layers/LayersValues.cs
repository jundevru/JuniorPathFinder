// Содержит веса слоев

namespace JuniorPathFinderCore
{
    public class LayersValues
    {
        private int[]   list        =   new int[32];
        private int     minValue    =   0;
        private int     maxValue    =   0;

        public int MaxValue => maxValue;
        public int MinValue => minValue;

        /// <summary>
        /// Задает вес для указанного слоя
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="value"></param>
        public void AddValue(Layers layer, int value)
        {
            list[(int)layer] = value;
            if (value > maxValue)
                maxValue = value;
            if (value < minValue)
                minValue = value;
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
