using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavenkovaME.Sprint6.Task1.V22.Lib;


namespace Tyuiu.SavenkovaME.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBoxData_SME_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep_SME.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_SME.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_SME.Text = "";
                textBoxResult_SME.AppendText("+------------------------+" + Environment.NewLine);
                textBoxResult_SME.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_SME.AppendText("+------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 7:f2}    |", startstep, func[i]);
                    textBoxResult_SME.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_SME.AppendText("+------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы ИИПб-23-2 Савенкова М. Е.", "Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
