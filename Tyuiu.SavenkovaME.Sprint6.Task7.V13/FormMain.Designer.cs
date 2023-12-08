
namespace Tyuiu.SavenkovaME.Sprint6.Task7.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_SME = new System.Windows.Forms.Panel();
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.buttonInfo_SME = new System.Windows.Forms.Button();
            this.buttonOpen_SME = new System.Windows.Forms.Button();
            this.panelData_SME = new System.Windows.Forms.Panel();
            this.panelMatrixIn_SME = new System.Windows.Forms.Panel();
            this.panelMatrixRes_SME = new System.Windows.Forms.Panel();
            this.splitterWindows_SME = new System.Windows.Forms.Splitter();
            this.buttonSave_SME = new System.Windows.Forms.Button();
            this.groupBoxCondition_SME = new System.Windows.Forms.GroupBox();
            this.groupBoxMtrixIn_SME = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrixRes_SME = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixIn_SME = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixResult_SME = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SME = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SME = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SME = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_SME.SuspendLayout();
            this.panelData_SME.SuspendLayout();
            this.panelMatrixIn_SME.SuspendLayout();
            this.panelMatrixRes_SME.SuspendLayout();
            this.groupBoxCondition_SME.SuspendLayout();
            this.groupBoxMtrixIn_SME.SuspendLayout();
            this.groupBoxMatrixRes_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixIn_SME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_SME)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_SME
            // 
            this.panelButtons_SME.Controls.Add(this.buttonSave_SME);
            this.panelButtons_SME.Controls.Add(this.buttonDone_SME);
            this.panelButtons_SME.Controls.Add(this.buttonInfo_SME);
            this.panelButtons_SME.Controls.Add(this.buttonOpen_SME);
            this.panelButtons_SME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SME.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SME.Name = "panelButtons_SME";
            this.panelButtons_SME.Size = new System.Drawing.Size(1316, 104);
            this.panelButtons_SME.TabIndex = 0;
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SME.Enabled = false;
            this.buttonDone_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SME.Image")));
            this.buttonDone_SME.Location = new System.Drawing.Point(116, 4);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(101, 94);
            this.buttonDone_SME.TabIndex = 0;
            this.toolTip_SME.SetToolTip(this.buttonDone_SME, "Выполнить обработку данных");
            this.buttonDone_SME.UseVisualStyleBackColor = true;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            this.buttonDone_SME.MouseEnter += new System.EventHandler(this.buttonDone_SME_MouseEnter);
            // 
            // buttonInfo_SME
            // 
            this.buttonInfo_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_SME.Image")));
            this.buttonInfo_SME.Location = new System.Drawing.Point(1203, 4);
            this.buttonInfo_SME.Name = "buttonInfo_SME";
            this.buttonInfo_SME.Size = new System.Drawing.Size(101, 94);
            this.buttonInfo_SME.TabIndex = 0;
            this.toolTip_SME.SetToolTip(this.buttonInfo_SME, "Сведения о программе");
            this.buttonInfo_SME.UseVisualStyleBackColor = true;
            this.buttonInfo_SME.Click += new System.EventHandler(this.buttonInfo_SME_Click);
            this.buttonInfo_SME.MouseEnter += new System.EventHandler(this.buttonInfo_SME_MouseEnter);
            // 
            // buttonOpen_SME
            // 
            this.buttonOpen_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SME.Image")));
            this.buttonOpen_SME.Location = new System.Drawing.Point(9, 4);
            this.buttonOpen_SME.Name = "buttonOpen_SME";
            this.buttonOpen_SME.Size = new System.Drawing.Size(101, 94);
            this.buttonOpen_SME.TabIndex = 0;
            this.toolTip_SME.SetToolTip(this.buttonOpen_SME, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpen_SME.UseVisualStyleBackColor = true;
            this.buttonOpen_SME.Click += new System.EventHandler(this.buttonOpen_SME_Click);
            this.buttonOpen_SME.MouseEnter += new System.EventHandler(this.buttonOpen_SME_MouseEnter);
            // 
            // panelData_SME
            // 
            this.panelData_SME.Controls.Add(this.groupBoxCondition_SME);
            this.panelData_SME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_SME.Location = new System.Drawing.Point(0, 104);
            this.panelData_SME.Name = "panelData_SME";
            this.panelData_SME.Size = new System.Drawing.Size(1316, 103);
            this.panelData_SME.TabIndex = 1;
            // 
            // panelMatrixIn_SME
            // 
            this.panelMatrixIn_SME.Controls.Add(this.groupBoxMtrixIn_SME);
            this.panelMatrixIn_SME.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMatrixIn_SME.Location = new System.Drawing.Point(0, 207);
            this.panelMatrixIn_SME.Name = "panelMatrixIn_SME";
            this.panelMatrixIn_SME.Size = new System.Drawing.Size(903, 438);
            this.panelMatrixIn_SME.TabIndex = 2;
            // 
            // panelMatrixRes_SME
            // 
            this.panelMatrixRes_SME.Controls.Add(this.groupBoxMatrixRes_SME);
            this.panelMatrixRes_SME.Controls.Add(this.splitterWindows_SME);
            this.panelMatrixRes_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatrixRes_SME.Location = new System.Drawing.Point(903, 207);
            this.panelMatrixRes_SME.Name = "panelMatrixRes_SME";
            this.panelMatrixRes_SME.Size = new System.Drawing.Size(413, 438);
            this.panelMatrixRes_SME.TabIndex = 3;
            // 
            // splitterWindows_SME
            // 
            this.splitterWindows_SME.Location = new System.Drawing.Point(0, 0);
            this.splitterWindows_SME.Name = "splitterWindows_SME";
            this.splitterWindows_SME.Size = new System.Drawing.Size(3, 438);
            this.splitterWindows_SME.TabIndex = 0;
            this.splitterWindows_SME.TabStop = false;
            // 
            // buttonSave_SME
            // 
            this.buttonSave_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SME.Enabled = false;
            this.buttonSave_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SME.Image")));
            this.buttonSave_SME.Location = new System.Drawing.Point(223, 4);
            this.buttonSave_SME.Name = "buttonSave_SME";
            this.buttonSave_SME.Size = new System.Drawing.Size(101, 94);
            this.buttonSave_SME.TabIndex = 0;
            this.toolTip_SME.SetToolTip(this.buttonSave_SME, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_SME.UseVisualStyleBackColor = true;
            this.buttonSave_SME.Click += new System.EventHandler(this.buttonSave_SME_Click);
            this.buttonSave_SME.MouseEnter += new System.EventHandler(this.buttonSave_SME_MouseEnter);
            // 
            // groupBoxCondition_SME
            // 
            this.groupBoxCondition_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxCondition_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            this.groupBoxCondition_SME.Size = new System.Drawing.Size(1316, 103);
            this.groupBoxCondition_SME.TabIndex = 0;
            this.groupBoxCondition_SME.TabStop = false;
            this.groupBoxCondition_SME.Text = "Условие";
            // 
            // groupBoxMtrixIn_SME
            // 
            this.groupBoxMtrixIn_SME.Controls.Add(this.dataGridViewMatrixIn_SME);
            this.groupBoxMtrixIn_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMtrixIn_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMtrixIn_SME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMtrixIn_SME.Name = "groupBoxMtrixIn_SME";
            this.groupBoxMtrixIn_SME.Size = new System.Drawing.Size(903, 438);
            this.groupBoxMtrixIn_SME.TabIndex = 0;
            this.groupBoxMtrixIn_SME.TabStop = false;
            this.groupBoxMtrixIn_SME.Text = "Ввод данных";
            // 
            // groupBoxMatrixRes_SME
            // 
            this.groupBoxMatrixRes_SME.Controls.Add(this.dataGridViewMatrixResult_SME);
            this.groupBoxMatrixRes_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMatrixRes_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMatrixRes_SME.Location = new System.Drawing.Point(3, 0);
            this.groupBoxMatrixRes_SME.Name = "groupBoxMatrixRes_SME";
            this.groupBoxMatrixRes_SME.Size = new System.Drawing.Size(410, 438);
            this.groupBoxMatrixRes_SME.TabIndex = 1;
            this.groupBoxMatrixRes_SME.TabStop = false;
            this.groupBoxMatrixRes_SME.Text = "Вывод данных";
            // 
            // dataGridViewMatrixIn_SME
            // 
            this.dataGridViewMatrixIn_SME.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrixIn_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrixIn_SME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixIn_SME.ColumnHeadersVisible = false;
            this.dataGridViewMatrixIn_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrixIn_SME.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewMatrixIn_SME.Name = "dataGridViewMatrixIn_SME";
            this.dataGridViewMatrixIn_SME.RowHeadersVisible = false;
            this.dataGridViewMatrixIn_SME.RowHeadersWidth = 51;
            this.dataGridViewMatrixIn_SME.RowTemplate.Height = 24;
            this.dataGridViewMatrixIn_SME.Size = new System.Drawing.Size(897, 412);
            this.dataGridViewMatrixIn_SME.TabIndex = 0;
            // 
            // dataGridViewMatrixResult_SME
            // 
            this.dataGridViewMatrixResult_SME.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrixResult_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrixResult_SME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_SME.ColumnHeadersVisible = false;
            this.dataGridViewMatrixResult_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrixResult_SME.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewMatrixResult_SME.Name = "dataGridViewMatrixResult_SME";
            this.dataGridViewMatrixResult_SME.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_SME.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_SME.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_SME.Size = new System.Drawing.Size(404, 412);
            this.dataGridViewMatrixResult_SME.TabIndex = 1;
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(9, 23);
            this.textBoxTask_SME.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(1286, 79);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = resources.GetString("textBoxTask_SME.Text");
            // 
            // openFileDialogTask_SME
            // 
            this.openFileDialogTask_SME.FileName = "openFileDialog1";
            // 
            // toolTip_SME
            // 
            this.toolTip_SME.IsBalloon = true;
            this.toolTip_SME.Tag = "";
            this.toolTip_SME.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SME.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 645);
            this.Controls.Add(this.panelMatrixRes_SME);
            this.Controls.Add(this.panelMatrixIn_SME);
            this.Controls.Add(this.panelData_SME);
            this.Controls.Add(this.panelButtons_SME);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 7 | Вариант 13 | Савенкова М. Е.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_SME.ResumeLayout(false);
            this.panelData_SME.ResumeLayout(false);
            this.panelMatrixIn_SME.ResumeLayout(false);
            this.panelMatrixRes_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.PerformLayout();
            this.groupBoxMtrixIn_SME.ResumeLayout(false);
            this.groupBoxMatrixRes_SME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixIn_SME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_SME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SME;
        private System.Windows.Forms.Panel panelData_SME;
        private System.Windows.Forms.Panel panelMatrixIn_SME;
        private System.Windows.Forms.Panel panelMatrixRes_SME;
        private System.Windows.Forms.Splitter splitterWindows_SME;
        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.Button buttonInfo_SME;
        private System.Windows.Forms.Button buttonOpen_SME;
        private System.Windows.Forms.Button buttonSave_SME;
        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.GroupBox groupBoxMtrixIn_SME;
        private System.Windows.Forms.DataGridView dataGridViewMatrixIn_SME;
        private System.Windows.Forms.GroupBox groupBoxMatrixRes_SME;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SME;
        private System.Windows.Forms.ToolTip toolTip_SME;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SME;
    }
}

