using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavenkovaME.Sprint6.Task3.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrix_SME.RowCount = rows;
            dataGridViewMatrix_SME.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SME.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SME.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
                
            }
            
        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студент группы ИИПб-23-2 Савенкова М. Е.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
