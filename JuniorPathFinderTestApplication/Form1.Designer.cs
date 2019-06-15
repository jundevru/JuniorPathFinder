namespace JuniorPathFinderTestApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYsize = new System.Windows.Forms.TrackBar();
            this.tbXSize = new System.Windows.Forms.TrackBar();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb0 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb17 = new System.Windows.Forms.Label();
            this.lb20 = new System.Windows.Forms.Label();
            this.lb25 = new System.Windows.Forms.Label();
            this.rbLayer = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWalkable = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.pfGrid = new JuniorPathFinderGrig.JuniorPathGrid();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(736, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 564);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rbStart);
            this.groupBox2.Location = new System.Drawing.Point(3, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рисовать";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(127, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "Ячейка";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbStart_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(65, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Конец";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbStart_CheckedChanged);
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Location = new System.Drawing.Point(7, 20);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(54, 17);
            this.rbStart.TabIndex = 0;
            this.rbStart.Tag = "0";
            this.rbStart.Text = "Старт";
            this.rbStart.UseVisualStyleBackColor = true;
            this.rbStart.CheckedChanged += new System.EventHandler(this.rbStart_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbYsize);
            this.groupBox1.Controls.Add(this.tbXSize);
            this.groupBox1.Location = new System.Drawing.Point(41, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая область";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(132, 82);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 7;
            this.btNew.Text = "Создать";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SizeY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SizeX";
            // 
            // tbYsize
            // 
            this.tbYsize.Location = new System.Drawing.Point(6, 31);
            this.tbYsize.Maximum = 40;
            this.tbYsize.Minimum = 10;
            this.tbYsize.Name = "tbYsize";
            this.tbYsize.Size = new System.Drawing.Size(104, 45);
            this.tbYsize.TabIndex = 4;
            this.tbYsize.Value = 20;
            // 
            // tbXSize
            // 
            this.tbXSize.Location = new System.Drawing.Point(112, 31);
            this.tbXSize.Maximum = 40;
            this.tbXSize.Minimum = 10;
            this.tbXSize.Name = "tbXSize";
            this.tbXSize.Size = new System.Drawing.Size(104, 45);
            this.tbXSize.TabIndex = 3;
            this.tbXSize.Value = 20;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(3, 38);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(32, 32);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "S";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(3, 3);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(32, 32);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "L";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.cbWalkable);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.rbLayer);
            this.groupBox3.Controls.Add(this.lb25);
            this.groupBox3.Controls.Add(this.lb20);
            this.groupBox3.Controls.Add(this.lb17);
            this.groupBox3.Controls.Add(this.lb13);
            this.groupBox3.Controls.Add(this.lb7);
            this.groupBox3.Controls.Add(this.lb0);
            this.groupBox3.Location = new System.Drawing.Point(3, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 138);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Слои";
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.Location = new System.Drawing.Point(6, 37);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(41, 13);
            this.lb0.TabIndex = 0;
            this.lb0.Text = "Слой 0";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(6, 54);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(41, 13);
            this.lb7.TabIndex = 1;
            this.lb7.Text = "Слой 7";
            // 
            // lb13
            // 
            this.lb13.AutoSize = true;
            this.lb13.Location = new System.Drawing.Point(6, 70);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(47, 13);
            this.lb13.TabIndex = 2;
            this.lb13.Text = "Слой 13";
            // 
            // lb17
            // 
            this.lb17.AutoSize = true;
            this.lb17.Location = new System.Drawing.Point(6, 86);
            this.lb17.Name = "lb17";
            this.lb17.Size = new System.Drawing.Size(47, 13);
            this.lb17.TabIndex = 3;
            this.lb17.Text = "Слой 17";
            // 
            // lb20
            // 
            this.lb20.AutoSize = true;
            this.lb20.Location = new System.Drawing.Point(6, 101);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(47, 13);
            this.lb20.TabIndex = 4;
            this.lb20.Text = "Слой 20";
            // 
            // lb25
            // 
            this.lb25.AutoSize = true;
            this.lb25.Location = new System.Drawing.Point(6, 118);
            this.lb25.Name = "lb25";
            this.lb25.Size = new System.Drawing.Size(47, 13);
            this.lb25.TabIndex = 5;
            this.lb25.Text = "Слой 25";
            // 
            // rbLayer
            // 
            this.rbLayer.AutoSize = true;
            this.rbLayer.Checked = true;
            this.rbLayer.Location = new System.Drawing.Point(56, 37);
            this.rbLayer.Name = "rbLayer";
            this.rbLayer.Size = new System.Drawing.Size(14, 13);
            this.rbLayer.TabIndex = 6;
            this.rbLayer.TabStop = true;
            this.rbLayer.Tag = "0";
            this.rbLayer.UseVisualStyleBackColor = true;
            this.rbLayer.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(56, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Tag = "7";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(56, 70);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.Tag = "13";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(56, 86);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.Tag = "17";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(56, 101);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 10;
            this.radioButton7.Tag = "20";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(56, 118);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 11;
            this.radioButton8.Tag = "25";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.rbLayer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Текеущий";
            // 
            // cbWalkable
            // 
            this.cbWalkable.AutoSize = true;
            this.cbWalkable.Location = new System.Drawing.Point(109, 36);
            this.cbWalkable.Name = "cbWalkable";
            this.cbWalkable.Size = new System.Drawing.Size(15, 14);
            this.cbWalkable.TabIndex = 13;
            this.cbWalkable.Tag = "0";
            this.cbWalkable.UseVisualStyleBackColor = true;
            this.cbWalkable.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(109, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Tag = "7";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(109, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Tag = "13";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(109, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Tag = "17";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(109, 101);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Tag = "20";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(109, 117);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Tag = "25";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.cbWalkable_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Проходимость";
            // 
            // btFind
            // 
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFind.Location = new System.Drawing.Point(88, 476);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(95, 48);
            this.btFind.TabIndex = 8;
            this.btFind.Text = "Найти путь";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // pfGrid
            // 
            this.pfGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pfGrid.Location = new System.Drawing.Point(0, 0);
            this.pfGrid.Map = null;
            this.pfGrid.Name = "pfGrid";
            this.pfGrid.Path = null;
            this.pfGrid.Size = new System.Drawing.Size(798, 564);
            this.pfGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pfGrid);
            this.Name = "Form1";
            this.Text = "Поиск пути (в потоке GUI)";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JuniorPathFinderGrig.JuniorPathGrid pfGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbYsize;
        private System.Windows.Forms.TrackBar tbXSize;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.Label lb25;
        private System.Windows.Forms.Label lb20;
        private System.Windows.Forms.Label lb17;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbWalkable;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFind;
    }
}

