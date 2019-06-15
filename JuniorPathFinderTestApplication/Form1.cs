using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuniorPathFinderCore;

namespace JuniorPathFinderTestApplication
{
    public partial class Form1 : Form
    {

        private LayerMask walcable = new LayerMask();
        private LayersValues weights = new LayersValues();
        string curDir = System.Environment.CurrentDirectory.TrimEnd("\\"[0]);

        public Form1()
        {
            #region Инициализация формы
            InitializeComponent();
            lb0.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer0);
            lb7.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer7);
            lb13.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer13);
            lb17.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer17);
            lb20.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer20);
            lb25.BackColor = JuniorPathFinderGrig.HSVColor.GetRGBColor(Layers.Layer25);
            #endregion

            #region Инициализация элементов PathFinder
            Region2D region = new Region2D(Vector3i.zero, 20, 20, Layers.Layer0);
            pfGrid.Map = region;
            weights.AddValue(Layers.Layer0, 1);
            weights.AddValue(Layers.Layer7, 8);
            weights.AddValue(Layers.Layer13, 14);
            weights.AddValue(Layers.Layer17, 18);
            weights.AddValue(Layers.Layer20, 21);
            weights.AddValue(Layers.Layer25, 26);
            #endregion

            #region События
            // Новый регион
            btNew.Click += (s, e) =>
            {
                region = new Region2D(Vector3i.zero, (byte)tbXSize.Value, (byte)tbYsize.Value, Layers.Layer0);
                pfGrid.Map = region;
            };
            // Сохранить регион
            btSave.Click += (s, e) => {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = curDir;
                sfd.Filter = "Region file (*.jpfr)|*.jpfr";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                string filename = sfd.FileName;
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    byte[] array = pfGrid.Map.GetBytes();
                    fs.Write(array, 0, array.Length);
                    fs.Close();
                }
            };
            // Загрузить регион
            btLoad.Click += (s, e) =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = curDir;
                ofd.Filter = "Region file (*.jpfr)|*.jpfr";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                string filename = ofd.FileName;
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, (int)fs.Length);
                    fs.Close();
                    pfGrid.Map.SetBytes(array);
                }
                pfGrid.UpdateMap();
            };
            this.ResizeEnd += (s, e) => {
                pfGrid.UpdateMap();
            };
            #endregion
        }
      
        // Выбор режима рисования
        private void rbStart_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            pfGrid.DrawMode = (JuniorPathFinderGrig.JuniorPathGrid.Mode)Convert.ToInt32(rb.Tag);
        }
        // Текущий слой рисования
        private void rbLayer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            pfGrid.DrawLayer = (Layers)Convert.ToInt32(rb.Tag);
        }
        // Задать проходимость ячеек
        private void cbWalkable_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Layers layer = (Layers)Convert.ToInt32(cb.Tag);
            if (cb.Checked)
            {
                walcable.Add(layer);
                if (!walcable.Contains(layer))
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                walcable.Remove(layer);
                if (walcable.Contains(layer))
                {
                    MessageBox.Show("Error");
                }
            }
        }
        // Поиск пути в потоке GUI
        private void btFind_Click(object sender, EventArgs e)
        {
            JuniorPathFinderCore.Comparers.IRegion2DItemComparer comparer = new JuniorPathFinderCore.Comparers.OptimalRegion2DItemsComparer();
            JuniorPathFinderCore.Heuristics.IHeuristic2D heuristic = new JuniorPathFinderCore.Heuristics.Manhatan2D();
            RegionPath path = pfGrid.Map.GetPath(pfGrid.StartPosition, pfGrid.EndPosition, comparer, heuristic, walcable, weights);
            if (path == null)
            {
                MessageBox.Show("Путь не найден");
                return;
            }
            pfGrid.Path = path;
        }
    }
}
