using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavenkovaME.Sprint6.Task4.V10.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint6.Task4.V10
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

        private void buttonSave_SME_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxResult_SME.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_SME_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SME.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SME.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] res = new double[len];
                res = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_SME.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SME.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SME.Text = "";
                chartFunction_SME.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SME.Series[0].Points.AddXY(startStep, res[i]);
                    textBoxResult_SME.AppendText(res[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИИПб-23-2 Савенкова Мария Евгеньевна", 
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SME_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void panelData_SME_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
