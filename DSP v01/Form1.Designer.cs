using OxyPlot.WindowsForms;

namespace DSP_v01
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
            this.components = new System.ComponentModel.Container();
            this.buttonMatrixBuild = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPlotBuild = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelParametersStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMatrixStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlotStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCustomParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonParametersClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.buttonMatrixClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelPlot = new System.Windows.Forms.Panel();
            this.buttonPlotClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelParameters.SuspendLayout();
            this.panelMatrix.SuspendLayout();
            this.panelPlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMatrixBuild
            // 
            this.buttonMatrixBuild.Location = new System.Drawing.Point(141, 135);
            this.buttonMatrixBuild.Name = "buttonMatrixBuild";
            this.buttonMatrixBuild.Size = new System.Drawing.Size(119, 45);
            this.buttonMatrixBuild.TabIndex = 1;
            this.buttonMatrixBuild.Text = "Рассчитать \r\nматрицу";
            this.buttonMatrixBuild.UseVisualStyleBackColor = true;
            this.buttonMatrixBuild.Click += new System.EventHandler(this.buttonMatrixBuild_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Основание системы \r\nсчисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размерность матрицы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 226);
            this.dataGridView1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(434, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(420, 226);
            this.dataGridView2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Матрица МФУ-Пэли";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Матрица ядра Фурье";
            // 
            // buttonPlotBuild
            // 
            this.buttonPlotBuild.Location = new System.Drawing.Point(141, 197);
            this.buttonPlotBuild.Name = "buttonPlotBuild";
            this.buttonPlotBuild.Size = new System.Drawing.Size(119, 45);
            this.buttonPlotBuild.TabIndex = 14;
            this.buttonPlotBuild.Text = "Построить график\r\nфункции сигнала";
            this.buttonPlotBuild.UseVisualStyleBackColor = true;
            this.buttonPlotBuild.Click += new System.EventHandler(this.buttonPlotBuild_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Signal A",
            "Signal B",
            "Signal C"});
            this.listBox1.Location = new System.Drawing.Point(9, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Типовые сигналы";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.видToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelParametersStripMenuItem,
            this.panelMatrixStripMenuItem,
            this.panelPlotStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // panelParametersStripMenuItem
            // 
            this.panelParametersStripMenuItem.Name = "panelParametersStripMenuItem";
            this.panelParametersStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.panelParametersStripMenuItem.Text = "Панель параметров";
            this.panelParametersStripMenuItem.Click += new System.EventHandler(this.panelParametersStripMenuItem_Click);
            // 
            // panelMatrixStripMenuItem
            // 
            this.panelMatrixStripMenuItem.Name = "panelMatrixStripMenuItem";
            this.panelMatrixStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.panelMatrixStripMenuItem.Text = "Панель матрицы";
            this.panelMatrixStripMenuItem.Click += new System.EventHandler(this.panelMatrixStripMenuItem_Click);
            // 
            // panelPlotStripMenuItem
            // 
            this.panelPlotStripMenuItem.Name = "panelPlotStripMenuItem";
            this.panelPlotStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.panelPlotStripMenuItem.Text = "Панель графика";
            this.panelPlotStripMenuItem.Click += new System.EventHandler(this.panelPlotStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowCustomParamsToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // windowCustomParamsToolStripMenuItem
            // 
            this.windowCustomParamsToolStripMenuItem.Name = "windowCustomParamsToolStripMenuItem";
            this.windowCustomParamsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.windowCustomParamsToolStripMenuItem.Text = "Настройка параметров";
            this.windowCustomParamsToolStripMenuItem.Click += new System.EventHandler(this.windowCustomParamsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParameters.Controls.Add(this.label8);
            this.panelParameters.Controls.Add(this.buttonParametersClose);
            this.panelParameters.Controls.Add(this.label7);
            this.panelParameters.Controls.Add(this.label1);
            this.panelParameters.Controls.Add(this.listBox1);
            this.panelParameters.Controls.Add(this.label6);
            this.panelParameters.Controls.Add(this.label2);
            this.panelParameters.Controls.Add(this.buttonMatrixBuild);
            this.panelParameters.Controls.Add(this.buttonPlotBuild);
            this.panelParameters.Controls.Add(this.textBox2);
            this.panelParameters.Controls.Add(this.textBox1);
            this.panelParameters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelParameters.Location = new System.Drawing.Point(0, 27);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(278, 587);
            this.panelParameters.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "____________________________________________";
            // 
            // buttonParametersClose
            // 
            this.buttonParametersClose.Location = new System.Drawing.Point(251, 3);
            this.buttonParametersClose.Name = "buttonParametersClose";
            this.buttonParametersClose.Size = new System.Drawing.Size(22, 22);
            this.buttonParametersClose.TabIndex = 18;
            this.buttonParametersClose.Text = "X";
            this.buttonParametersClose.UseVisualStyleBackColor = true;
            this.buttonParametersClose.Click += new System.EventHandler(this.buttonParametersClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Параметры";
            // 
            // panelMatrix
            // 
            this.panelMatrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrix.Controls.Add(this.buttonMatrixClose);
            this.panelMatrix.Controls.Add(this.label10);
            this.panelMatrix.Controls.Add(this.label5);
            this.panelMatrix.Controls.Add(this.dataGridView1);
            this.panelMatrix.Controls.Add(this.label3);
            this.panelMatrix.Controls.Add(this.dataGridView2);
            this.panelMatrix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMatrix.Location = new System.Drawing.Point(280, 27);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(864, 293);
            this.panelMatrix.TabIndex = 20;
            this.panelMatrix.Visible = false;
            // 
            // buttonMatrixClose
            // 
            this.buttonMatrixClose.Location = new System.Drawing.Point(837, 3);
            this.buttonMatrixClose.Name = "buttonMatrixClose";
            this.buttonMatrixClose.Size = new System.Drawing.Size(22, 22);
            this.buttonMatrixClose.TabIndex = 18;
            this.buttonMatrixClose.Text = "X";
            this.buttonMatrixClose.UseVisualStyleBackColor = true;
            this.buttonMatrixClose.Click += new System.EventHandler(this.buttonMatrixClose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(2, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Матрица";
            // 
            // panelPlot
            // 
            this.panelPlot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlot.Controls.Add(this.buttonPlotClose);
            this.panelPlot.Controls.Add(this.label9);
            this.panelPlot.Controls.Add(this.plot1);
            this.panelPlot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPlot.Location = new System.Drawing.Point(280, 321);
            this.panelPlot.Name = "panelPlot";
            this.panelPlot.Size = new System.Drawing.Size(864, 293);
            this.panelPlot.TabIndex = 21;
            this.panelPlot.Visible = false;
            // 
            // buttonPlotClose
            // 
            this.buttonPlotClose.Location = new System.Drawing.Point(837, 3);
            this.buttonPlotClose.Name = "buttonPlotClose";
            this.buttonPlotClose.Size = new System.Drawing.Size(22, 22);
            this.buttonPlotClose.TabIndex = 18;
            this.buttonPlotClose.Text = "X";
            this.buttonPlotClose.UseVisualStyleBackColor = true;
            this.buttonPlotClose.Click += new System.EventHandler(this.buttonPlotClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(2, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "График";
            // 
            // plot1
            // 
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Margin = new System.Windows.Forms.Padding(0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(862, 291);
            this.plot1.TabIndex = 0;
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1144, 614);
            this.Controls.Add(this.panelPlot);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.panelParameters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программа имитации случайных сигналов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.panelMatrix.ResumeLayout(false);
            this.panelMatrix.PerformLayout();
            this.panelPlot.ResumeLayout(false);
            this.panelPlot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMatrixBuild;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPlotBuild;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelParametersStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelMatrixStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Button buttonParametersClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Button buttonMatrixClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelPlot;
        private System.Windows.Forms.Button buttonPlotClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem panelPlotStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PlotView plot1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem windowCustomParamsToolStripMenuItem;
    }
}

