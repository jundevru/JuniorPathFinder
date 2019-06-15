//region element
using System;


namespace JuniorPathFinderCore
{
    [Serializable]
    public class RegionItem
    {
        private byte        xLocalCoordinate    = 0;
        private byte        yLocalCoordinate    = 0;
        private byte        zLocalCoordinate    = 0;
        private Layers      layer               = Layers.Layer0;
        /// <summary>
        /// Предыдущий элемент пути (используется при формировании найденного пути)
        /// </summary>
        [NonSerialized]
        public RegionItem   parent              = null;
        /// <summary>
        /// Флаг нахождения в открытом списке
        /// </summary>
        [NonSerialized]
        public byte         opened              = 0;
        /// <summary>
        /// Флаг нахождения в закрытом списке
        /// </summary>
        [NonSerialized]
        public byte         closed              = 0;
        /// <summary>
        /// Суммарный вес пройденного пути до данной точки
        /// </summary>
        [NonSerialized]
        public int          g                   = 0;
        /// <summary>
        /// Оставшееся расстояние до конечной точки
        /// </summary>
        [NonSerialized]
        public double       f                   = 0;
        
        
        /// <summary>
        /// Возвращает слой элемента
        /// </summary>
        public Layers   Layer               =>  layer;
        /// <summary>
        /// Возвращает локальную координату элемента
        /// </summary>
        public Vector3i LocalCoordinate     =>  new Vector3i(xLocalCoordinate, yLocalCoordinate, zLocalCoordinate);

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

        /// <summary>
        /// Задает слой элемента
        /// </summary>
        /// <param name="layer"></param>
        public void SetLayer(Layers layer)
        {
            this.layer = layer;
        }
        

    }
}
