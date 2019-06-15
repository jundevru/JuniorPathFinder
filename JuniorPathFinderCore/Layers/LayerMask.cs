// Маска слоев, аналог в Unity
namespace JuniorPathFinderCore
{
    public sealed class LayerMask
    {
        public static readonly LayerMask Empty = new LayerMask();

        int value = 0;
        /// <summary>
        /// Get value
        /// </summary>
        public int Value => value;

        public LayerMask() { value = 0; }

        /// <summary>
        /// Проверяет вхождение слоя в маску
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Contains(Layers layer)
        {
            return ((value & (1 << (int)layer)) != 0);
        }

        /// <summary>
        /// Добавляет слой в маску
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Add(Layers layer)
        {
            if (Contains(layer))
                return false;
            value = value | (1 << (int)layer);
            return true;
        }

        /// <summary>
        /// Удаляет слой из маски
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Remove(Layers layer)
        {
            if (!Contains(layer)) return false;
            value = value ^ (1 << (int)layer);
            return true;
        }
    }
}
