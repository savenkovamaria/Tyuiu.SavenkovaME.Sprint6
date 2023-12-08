using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavenkovaME.Sprint6.Task6.V14.Lib;
using System.IO;


namespace Tyuiu.SavenkovaME.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        DataService ds = new DataService();
        string openpath;
        private void panelResultFile_SME_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_SME_Click(object sender, EventArgs e)
        {

            openFileDialog_SME.ShowDialog();
            openpath = openFileDialog_SME.FileName;
            textBoxFile_SME.Text = File.ReadAllText(openpath);
            groupBoxInput_SME.Text = groupBoxInput_SME.Text + " " + openFileDialog_SME.FileName;
            buttonDone_SME.Enabled = true;
        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            textBoxResult_SME.Text = ds.CollectTextFromFile(openpath);
        }
        

        private void buttonInfo_SME_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
