using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SavenkovaME.Sprint6.Task5.V18.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task5.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBoxResult_SME_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_SME_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxData_SME_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SME.ColumnCount = 2;
            dataGridViewResult_SME.Columns[0].Width = 40;
            dataGridViewResult_SME.Columns[1].Width = 60;

            this.chartDiagramm_SME.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagramm_SME.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartDiagramm_SME.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_SME.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiagramm_SME.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonOpen_SME_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнила студент группы ИИПб-23-2 Савенкова Мария Евгеньевна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
