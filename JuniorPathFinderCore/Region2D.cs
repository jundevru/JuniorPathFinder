// Grid in flat array
// xScale*(yScale-1) ...   xScale*yScale -1
// ...
// 1
// 0  1  2           ...   xScale-1

using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using JuniorPathFinderCore.Collections;
using JuniorPathFinderCore.Comparers;
using JuniorPathFinderCore.Heuristics;

namespace JuniorPathFinderCore
{

    public class Region2D : Storage.IStorageObject
    {
        public static readonly byte minScale            = 2;
        public static readonly byte maxScale            = 255;
        private List<RegionItem>    grid                = new List<RegionItem>();
        private byte                xScale;
        private byte                yScale;
        private Vector3i            position;
        private byte                currentIteration    = 0;
        

        public Vector3i Position    =>  position;
        public byte ScaleX          =>  xScale;
        public byte ScaleY          =>  yScale;

        public Region2D(Vector3i position, byte xScale, byte yScale, Layers defaultLayer = Layers.Layer0)
        {
            this.position = position;
            this.xScale = xScale > minScale ? (xScale < maxScale ? xScale : maxScale) : minScale;
            this.yScale = yScale > minScale ? (yScale < maxScale ? yScale : maxScale) : minScale;
            for (byte y = 0; y < yScale; y++)
                for (byte x = 0; x < xScale; x++)
                    grid.Add(new RegionItem(x, y, 0, defaultLayer));
        }

        /// <summary>
        /// Поиск пути из точки в точку
        /// </summary>
        /// <param name="from">Start local point</param>
        /// <param name="to">End local point</param>
        /// <param name="comparer">Point comparer</param>
        /// <returns>Возвращает путь в глобальных координатах</returns>
        public RegionPath GetPath(Vector2i from, Vector2i to, IRegion2DItemComparer comparer, IHeuristic2D heuristic, LayerMask walkable, LayersValues weights)
        {
            RegionPath path = null;
            RegionItem start = GetItem(from);
            RegionItem end = GetItem(to);
            if (start == null || end == null 
                || !walkable.Contains(start.Layer) || !walkable.Contains(end.Layer))
                return null;
            if (comparer == null)
                comparer = new OptimalRegion2DItemsComparer();
            if (heuristic == null)
                heuristic = new Manhatan2D();

            byte closedvalue = IncrementCurrentIteration;
            sbyte[,] direction = new sbyte[8, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 }, { 1, -1 }, { 1, 1 }, { -1, 1 }, { -1, -1 } };
            TreeQueue<RegionItem> opened = new TreeQueue<RegionItem>(comparer);
            RegionItem parent = null;

            start.g = 0;
            start.f = heuristic.GetHeuristic(from,to);
            start.parent = null;
            opened.Push(start);
            
            int nx;
            int ny;

            while (opened.Count > 0)
            {
                parent = opened.Pop();
                parent.closed = closedvalue;
                parent.opened = 0;   // ???

                if (parent.LocalCoordinate.x == end.LocalCoordinate.x && parent.LocalCoordinate.y == end.LocalCoordinate.y)
                {
                    path = RetracePath(end);
                    break;
                }

                for (int i = 0; i < 8; i++)
                {
                    nx = parent.LocalCoordinate.x + direction[i, 0];
                    ny = parent.LocalCoordinate.y + direction[i, 1];

                    if (nx < 0 || ny < 0 || nx >= xScale || ny >= yScale)
                        continue;
                    RegionItem newnode = GetItem(new Vector2i(nx, ny));

                    // Если поверхность не проходима
                    if (newnode.closed == closedvalue || !walkable.Contains(newnode.Layer))
                        continue;
                    // Базовый штраф поверхности
                    int penalti = weights.GetValue(newnode.Layer);
                    // Вычисляем пройденный путь
                    int g = parent.g + penalti ;
                    if (newnode.opened == closedvalue && newnode.g <= g)
                        continue;

                    // При расчете оптимального пути, считаем в общий путь еще и пройденный
                    double f = heuristic.GetHeuristic(new Vector2i(newnode.LocalCoordinate.x, newnode.LocalCoordinate.y), new Vector2i(end.LocalCoordinate.x, end.LocalCoordinate.y));

                    newnode.g = g;
                    newnode.f = f;
                    newnode.parent = parent;
                    if (newnode.opened != closedvalue)
                    {
                        opened.Push(newnode);
                        newnode.opened = closedvalue;
                    }
                }
            }
            return path;
        }

        #region Get Set point layer
        /// <summary>
        /// Возвращает слой по локальным координатам
        /// </summary>
        /// <param name="localPosition"></param>
        /// <returns></returns>
        public Layers GetLayer(Vector2i localPosition)
        {
            RegionItem item = GetItem(localPosition);
            if (item == null)
                throw new System.IndexOutOfRangeException("Координата не принадлежит области");
            return item.Layer;
        }
        /// <summary>
        /// Задает слой по локальным координатам
        /// </summary>
        /// <param name="localPosition"></param>
        /// <param name="layer"></param>
        public void SetLayer(Vector2i localPosition, Layers layer)
        {
            RegionItem item = GetItem(localPosition);
            if (item == null)
                throw new System.IndexOutOfRangeException("Координата не принадлежит области");
            item.SetLayer(layer);
        }
        #endregion

        #region private metods
        private RegionPath RetracePath(RegionItem end)
        {
            RegionPath path = new RegionPath();
            RegionItem item = end;
            List<RegionItem> res = new List<RegionItem>();
            while (item != null)
            {
                res.Add(item);
                item = item.parent;
            }
            res.Reverse();
            foreach (RegionItem i in res)
                path.Add(new PathItem(Position + i.LocalCoordinate, i.Layer));
            return path;
        }
        private RegionItem GetItem(Vector2i local)
        {
            int index = xScale * local.y + local.x;
            if (index >= grid.Count)
                return null;
            return grid[index];
        }
        private byte IncrementCurrentIteration
        {
            get
            {
                if (currentIteration == 255)
                {
                    currentIteration = 1;
                    for (int i = 0; i < grid.Count; i++)
                    {
                        grid[i].closed = 0;
                        grid[i].opened = 0;
                    }
                }
                else currentIteration++;
                return currentIteration;
            }
        }
        #endregion

        #region IStorageObject
        /// <summary>
        /// Возвращает область в виде массива байтов
        /// </summary>
        /// <returns></returns>
        public byte[] GetBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, grid);
            bf.Serialize(ms, xScale);
            bf.Serialize(ms, yScale);
            bf.Serialize(ms, position);
            return ms.ToArray();
        }
        /// <summary>
        /// Восстанавливает область из массива байтов
        /// </summary>
        /// <param name="data"></param>
        public void SetBytes(byte[] data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(data);
            grid = (List<RegionItem>)bf.Deserialize(ms);
            xScale = (byte)bf.Deserialize(ms);
            yScale = (byte)bf.Deserialize(ms);
            position = (Vector3i)bf.Deserialize(ms);
            ms.Close();
        }
        #endregion
    }
}
