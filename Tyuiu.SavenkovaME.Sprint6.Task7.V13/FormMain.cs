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
using Tyuiu.SavenkovaME.Sprint6.Task7.V13.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SME.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_SME.Filter =  "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        

        private void buttonOpen_SME_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SME.ShowDialog();
            openFile = openFileDialogTask_SME.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewMatrixIn_SME.RowCount = rows;
            dataGridViewMatrixIn_SME.ColumnCount = columns;
            dataGridViewMatrixResult_SME.RowCount = rows;
            dataGridViewMatrixResult_SME.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixIn_SME.Columns[i].Width = 50;
                dataGridViewMatrixResult_SME.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrixIn_SME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_SME.Enabled = true;

        }

        private void buttonInfo_SME_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonSave_SME_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SME.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SME.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SME.ShowDialog();

            string path = saveFileDialogMatrix_SME.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrixResult_SME.RowCount;
            int columns = dataGridViewMatrixResult_SME.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewMatrixIn_SME.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewMatrixIn_SME.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrixIn_SME.RowCount = 50;
            dataGridViewMatrixResult_SME.RowCount = 50;

            dataGridViewMatrixIn_SME.ColumnCount = 50;
            dataGridViewMatrixResult_SME.ColumnCount = 50;

            panelMatrixIn_SME.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewMatrixIn_SME.Columns[i].Width = 25;
                dataGridViewMatrixResult_SME.Columns[i].Width = 25;
            }
        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrixResult_SME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SME.Enabled = true;
        }

        private void buttonOpen_SME_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SME.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_SME_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SME.ToolTipTitle = "Выполнить";
        }
        private void buttonSave_SME_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SME.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonInfo_SME_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SME.ToolTipTitle = "Справка";
        }
    }
}
