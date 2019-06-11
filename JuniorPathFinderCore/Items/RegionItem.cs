//region element
using System;


namespace JuniorPathFinderCore
{
    [Serializable]
    public class RegionItem
    {
        private byte xLocalCoordinate;
        private byte yLocalCoordinate;
        private byte zLocalCoordinate;
        private Layers layer;

        public Layers Layer => layer;

        /// <summary>
        /// Local point coordinate in region
        /// </summary>
        public Vector3i LocalCoordinate => new Vector3i(xLocalCoordinate, yLocalCoordinate, zLocalCoordinate);

        [NonSerialized]
        public RegionItem parent = null;
        [NonSerialized]
        public byte opened = 0;
        [NonSerialized]
        public byte closed = 0;

        [NonSerialized]
        public int g = 0;

        [NonSerialized]
        public double f = 0;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="x">X horizontal local coordinate</param>
        /// <param name="y">Y horizontal local coordinate</param>
        /// <param name="z">Z vertical local coordinate)</param>
        /// <param name="layer">Layer number</param>
        public RegionItem(byte x, byte y, byte z, Layers layer)
        {
            xLocalCoordinate = x;
            yLocalCoordinate = y;
            zLocalCoordinate = z;
            this.layer = layer;
        }
        /// <summary>
        /// Ctor
        /// </summary>
        public RegionItem()
            :this(0,0,0, Layers.Layer0)
        { }

        public void SetLayer(Layers layer)
        {
            this.layer = layer;
        }
        

    }
}
