using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace DSP_v01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonMatrixBuild_Click(object sender, EventArgs e)
        {
            int n;
            int base_n;
            int.TryParse(textBox1.Text, out n);
            int.TryParse(textBox2.Text, out base_n);

            panelMatrix.Visible = true;

            MathCalc obj = new MathCalc();

            //textBox4.Text = (2 * Math.PI / n).ToString();
            
            int[,] arr_out = obj.MatrixGen(n, base_n);

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr_out[i, j].ToString();
                    //dataGridView1.Rows[i].Cells[j].Value = (n*2).ToString();
                }
            }

            double[,] arr_out_F = obj.CalcCore(n, base_n);

            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;

            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = arr_out_F[i, j].ToString();
                }
            }
        }

        private void buttonMatrixClose_Click(object sender, EventArgs e)
        {
            panelMatrix.Visible = false;
        }

        private void buttonParametersClose_Click(object sender, EventArgs e)
        {
            panelParameters.Visible = false;
        }

        private void panelMatrixStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelMatrix.Visible)
            panelMatrix.Visible = true;
        }

        private void panelParametersStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelParameters.Visible)
                panelParameters.Visible = true;
        }

        private void panelPlotStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelPlot.Visible)
                panelPlot.Visible = true;
        }

        private void buttonPlotBuild_Click(object sender, EventArgs e)
        {
            int n;
            int base_n;
            int.TryParse(textBox1.Text, out n);
            int.TryParse(textBox2.Text, out base_n);
            MathCalc obj = new MathCalc();
            
            panelPlot.Visible = true;
            var pm = new PlotModel
            {
                Title = "График функции сигнала",
                Subtitle = "Случайный сигнал",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White
            };
            //pm.Series.Add(new FunctionSeries(Math.Sin, -10, 10, 0.1, "sin(x)"));
            //pm.Series.Add(new FunctionSeries(Math.Cos, -10, 10, 0.1, "cos(x)"));
            //pm.Series.Add(new FunctionSeries(t => 5 * Math.Cos(t), t => 5 * Math.Sin(t), 0, 2 * Math.PI, 0.1, "cos(t),sin(t)"));
            pm.Series.Add(new FunctionSeries(i => obj.GetFunction(i, n, base_n), 0, 10, 0.01, "y(i)")); 
            plot1.Model = pm;
            plot1.Visible = true;
        }

        private void buttonPlotClose_Click(object sender, EventArgs e)
        {
            panelPlot.Visible = false;
        }

        private void windowCustomParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
