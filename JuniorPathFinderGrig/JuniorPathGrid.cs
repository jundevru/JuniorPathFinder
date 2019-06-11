using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuniorPathFinderCore;

namespace JuniorPathFinderGrig
{
    public partial class JuniorPathGrid : UserControl
    {

        #region Данные отображаемой области
        public Region2D Map
        {
            get { return region; }
            set
            {
                region = value;
                this.Invalidate();
            }
        }
        private Region2D region = null;
        #endregion

        #region Данные сетки
        int cellSize = 10;
        private Point start = Point.Empty;
        private Point end = Point.Empty;
        #endregion

        #region Рисование
        public enum Mode
        {
            Start,
            End,
            Layer
        }
        public Mode DrawMode = Mode.Layer;
        public Layers DrawLayer = Layers.Layer0;
        #endregion


        public JuniorPathGrid()
        {
            InitializeComponent();
        }



        #region Переопределения
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (region!= null)
            {
                for (int y = (e.ClipRectangle.Y / cellSize) * cellSize; y <= e.ClipRectangle.Bottom; y += cellSize)
                    for (int x = (e.ClipRectangle.X / cellSize) * cellSize; x <= e.ClipRectangle.Right; x += cellSize)
                    {
                        try
                        {
                            int sx = (x / cellSize);
                            int sy = (y / cellSize);
                            if (sx >= region.ScaleX || sy >= region.ScaleY)
                                continue;
                            // Закрашиваем ячейки сетки
                            Color color = HSVColor.GetRGBColor(region.GetLayer(new Vector2i(sx,sy)));
                            using (SolidBrush brush = new SolidBrush(color))
                                g.FillRectangle(brush, x, y, cellSize, cellSize);

                            // Закрашиваем стартовую точку
                            if (sx == start.X && sy == start.Y)
                                using (SolidBrush brush = new SolidBrush(Color.Green))
                                    g.FillRectangle(brush, x, y, cellSize, cellSize);
                            // Закрашиваем конечную точку
                            if (sx == end.X && sy == end.Y)
                                using (SolidBrush brush = new SolidBrush(Color.Red))
                                    g.FillRectangle(brush, x, y, cellSize, cellSize);
                        }
                        catch (Exception) { }
                    }
            }
            // Рисуем собственно сетку
            Color c = Color.Black;
            using (Pen pen = new Pen(c))
            {
                for (int y = (e.ClipRectangle.Y / cellSize) * cellSize; y <= e.ClipRectangle.Bottom; y += cellSize)
                    g.DrawLine(pen, e.ClipRectangle.X, y, e.ClipRectangle.Right, y);

                for (int x = (e.ClipRectangle.X / cellSize) * cellSize; x <= e.ClipRectangle.Right; x += cellSize)
                    g.DrawLine(pen, x, e.ClipRectangle.Y, x, e.ClipRectangle.Bottom);
            }

            base.OnPaint(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
                return;
            try
            {
                byte x = (byte)(e.X / cellSize);
                byte y = (byte)(e.Y / cellSize);

                switch (DrawMode)
                {
                    case Mode.Start:
                        this.Invalidate(new Rectangle(start.X * cellSize, start.Y * cellSize, cellSize, cellSize));
                        start = new Point(x, y);
                        break;
                    case Mode.End:
                        this.Invalidate(new Rectangle(end.X * cellSize, end.Y * cellSize, cellSize, cellSize));
                        end = new Point(x, y);
                        break;
                    case Mode.Layer:
                        region.SetLayer(new Vector2i(x, y), DrawLayer);
                        break;
                }

                this.Invalidate(new Rectangle(x * cellSize, y * cellSize, cellSize, cellSize));
            }
            catch (Exception) { }
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.OnMouseMove(e);
            base.OnMouseDown(e);
        }
        #endregion

        public void DrawPath(RegionPath path)
        {
            if (path == null || path.Count == 0) return;
            try
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                try
                {
                    Rectangle internalRec;
                    foreach(PathItem item in path)
                    {
                        internalRec = new Rectangle((item.Point.x * cellSize) + 2, (item.Point.y * cellSize) + 2, cellSize - 4, cellSize - 4);
                        using (Brush brush = new SolidBrush(Color.White))
                            g.FillRectangle(brush, internalRec);
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                        using (Font f = new System.Drawing.Font("Verdana", 0.25F * cellSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))
                            g.DrawString(item.Layer.ToString(), f, Brushes.Black, (RectangleF)internalRec);
                    }
                }
                catch (Exception) { }
            }
            catch (Exception) {; }
        }



    }
}
