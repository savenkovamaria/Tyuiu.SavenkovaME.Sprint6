using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavenkovaME.Sprint6.Task2.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task2.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelStartStep_SME_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartStep_SME.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep_SME.Text);
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] result = new double[len];
                result = ds.GetMassFunction(StartStep, StopStep);
                this.chartfunc_SME.Titles.Add("График функции F(X)= cos(x) + sin(x) / (2-2x) - 4x");

                this.chartfunc_SME.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartfunc_SME.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResultFunc_SME.Rows.Add(Convert.ToString(StartStep), Convert.ToString(result[i]));
                    this.chartfunc_SME.Series[0].Points.AddXY(StartStep, result[i]);
                    StartStep++;
                }

            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SME.BackColor = Color.Red;
        }

        private void buttonDone_SME_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SME.BackColor = Color.Green;
        }

        private void buttonDone_SME_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SME.BackColor = Color.Blue;
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студент группы ИИПб-23-2 Савенкова М. Е.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
