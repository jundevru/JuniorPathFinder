// Layer mask
namespace JuniorPathFinderCore
{
    public sealed class LayerMask
    {
        public static readonly LayerMask Empty = new LayerMask();

        int value = 0;

        public LayerMask() { value = 0; }

        /// <summary>
        /// Get value
        /// </summary>
        public int Value { get { return value; } }

        /// <summary>
        /// Check the entry of a layer in the mask
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Contains(Layers layer)
        {
            return !((value & (1 << (int)layer)) == 0);
        }

        /// <summary>
        /// Add layer to mask
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Add(Layers layer)
        {
            if (Contains(layer)) return false;
            value = value | (1 << (int)layer);
            return true;
        }

        /// <summary>
        /// Remove Layer from mask
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        public bool Remove(Layers layer)
        {
            if (!Contains(layer)) return false;
            value = value ^ (int)layer;
            return true;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(LayerMask other)
        {
            return (this.value == other.Value);
        }
        */
    }
}
