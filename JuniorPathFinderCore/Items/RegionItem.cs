//region element
using System;


namespace JuniorPathFinderCore
{
    [Serializable]
    class RegionItem
    {
        /// <summary>
        /// X local horizontal coordinate
        /// </summary>
        public byte xLocalCoordinate;
        /// <summary>
        /// Y or Z local horizontal coordinate
        /// </summary>
        public byte xxLocalCoordinate;
        /// <summary>
        /// Y or Z local vertical coordinate
        /// </summary>
        public int hLocalCoordinate;
        /// <summary>
        /// Layer
        /// </summary>
        public Layers layer;

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
        /// <param name="x">X horizontal coordinate</param>
        /// <param name="xx">Y or Z horizontal coordinate</param>
        /// <param name="h">Y or Z vertical coordinate)</param>
        /// <param name="layer">Layer number</param>
        public RegionItem(byte x, byte xx, int h, Layers layer)
        {
            xLocalCoordinate = x;
            xxLocalCoordinate = xx;
            hLocalCoordinate = h;
            this.layer = layer;
        }
        /// <summary>
        /// Ctor
        /// </summary>
        public RegionItem()
            :this(0,0,0, Layers.Layer0)
        { }

    }
}
