
namespace Tyuiu.SavenkovaME.Sprint6.Task2.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_SME = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SME = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultFunc_SME = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartfunc_SME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SME = new System.Windows.Forms.Label();
            this.groupBoxData_SME = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SME = new System.Windows.Forms.Label();
            this.labelStartStep_SME = new System.Windows.Forms.Label();
            this.textBoxStartStep_SME = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SME = new System.Windows.Forms.TextBox();
            this.buttonHelp_SME = new System.Windows.Forms.Button();
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.groupBoxCondition_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            this.groupBoxResult_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultFunc_SME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartfunc_SME)).BeginInit();
            this.groupBoxData_SME.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SME
            // 
            this.groupBoxCondition_SME.Controls.Add(this.pictureBoxTask);
            this.groupBoxCondition_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxCondition_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SME.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            this.groupBoxCondition_SME.Size = new System.Drawing.Size(576, 355);
            this.groupBoxCondition_SME.TabIndex = 0;
            this.groupBoxCondition_SME.TabStop = false;
            this.groupBoxCondition_SME.Text = "Условие";
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask.Image")));
            this.pictureBoxTask.Location = new System.Drawing.Point(11, 73);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(332, 42);
            this.pictureBoxTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTask.TabIndex = 1;
            this.pictureBoxTask.TabStop = false;
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(521, 327);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // groupBoxResult_SME
            // 
            this.groupBoxResult_SME.Controls.Add(this.dataGridViewResultFunc_SME);
            this.groupBoxResult_SME.Controls.Add(this.chartfunc_SME);
            this.groupBoxResult_SME.Controls.Add(this.labelResult_SME);
            this.groupBoxResult_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SME.Location = new System.Drawing.Point(595, 13);
            this.groupBoxResult_SME.Name = "groupBoxResult_SME";
            this.groupBoxResult_SME.Size = new System.Drawing.Size(750, 450);
            this.groupBoxResult_SME.TabIndex = 1;
            this.groupBoxResult_SME.TabStop = false;
            this.groupBoxResult_SME.Text = "Вывод данных";
            // 
            // dataGridViewResultFunc_SME
            // 
            this.dataGridViewResultFunc_SME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultFunc_SME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnF});
            this.dataGridViewResultFunc_SME.Location = new System.Drawing.Point(11, 45);
            this.dataGridViewResultFunc_SME.Name = "dataGridViewResultFunc_SME";
            this.dataGridViewResultFunc_SME.RowHeadersVisible = false;
            this.dataGridViewResultFunc_SME.RowHeadersWidth = 51;
            this.dataGridViewResultFunc_SME.RowTemplate.Height = 24;
            this.dataGridViewResultFunc_SME.Size = new System.Drawing.Size(238, 397);
            this.dataGridViewResultFunc_SME.TabIndex = 2;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 90;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(X)";
            this.ColumnF.MinimumWidth = 6;
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.Width = 90;
            // 
            // chartfunc_SME
            // 
            chartArea5.Name = "ChartArea1";
            this.chartfunc_SME.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartfunc_SME.Legends.Add(legend5);
            this.chartfunc_SME.Location = new System.Drawing.Point(255, 45);
            this.chartfunc_SME.Name = "chartfunc_SME";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartfunc_SME.Series.Add(series5);
            this.chartfunc_SME.Size = new System.Drawing.Size(489, 399);
            this.chartfunc_SME.TabIndex = 1;
            this.chartfunc_SME.Text = "chartfunc";
            this.chartfunc_SME.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelResult_SME
            // 
            this.labelResult_SME.AutoSize = true;
            this.labelResult_SME.Location = new System.Drawing.Point(7, 22);
            this.labelResult_SME.Name = "labelResult_SME";
            this.labelResult_SME.Size = new System.Drawing.Size(97, 20);
            this.labelResult_SME.TabIndex = 0;
            this.labelResult_SME.Text = "Результат";
            // 
            // groupBoxData_SME
            // 
            this.groupBoxData_SME.Controls.Add(this.labelStopStep_SME);
            this.groupBoxData_SME.Controls.Add(this.labelStartStep_SME);
            this.groupBoxData_SME.Controls.Add(this.textBoxStartStep_SME);
            this.groupBoxData_SME.Controls.Add(this.textBoxStopStep_SME);
            this.groupBoxData_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_SME.Location = new System.Drawing.Point(12, 374);
            this.groupBoxData_SME.Name = "groupBoxData_SME";
            this.groupBoxData_SME.Size = new System.Drawing.Size(344, 89);
            this.groupBoxData_SME.TabIndex = 2;
            this.groupBoxData_SME.TabStop = false;
            this.groupBoxData_SME.Text = "Ввод данных";
            // 
            // labelStopStep_SME
            // 
            this.labelStopStep_SME.AutoSize = true;
            this.labelStopStep_SME.Location = new System.Drawing.Point(176, 31);
            this.labelStopStep_SME.Name = "labelStopStep_SME";
            this.labelStopStep_SME.Size = new System.Drawing.Size(112, 20);
            this.labelStopStep_SME.TabIndex = 1;
            this.labelStopStep_SME.Text = "Конец шага:";
            // 
            // labelStartStep_SME
            // 
            this.labelStartStep_SME.AutoSize = true;
            this.labelStartStep_SME.Location = new System.Drawing.Point(8, 31);
            this.labelStartStep_SME.Name = "labelStartStep_SME";
            this.labelStartStep_SME.Size = new System.Drawing.Size(113, 20);
            this.labelStartStep_SME.TabIndex = 1;
            this.labelStartStep_SME.Text = "Старт шага:";
            this.labelStartStep_SME.Click += new System.EventHandler(this.labelStartStep_SME_Click);
            // 
            // textBoxStartStep_SME
            // 
            this.textBoxStartStep_SME.Location = new System.Drawing.Point(8, 54);
            this.textBoxStartStep_SME.Name = "textBoxStartStep_SME";
            this.textBoxStartStep_SME.Size = new System.Drawing.Size(165, 27);
            this.textBoxStartStep_SME.TabIndex = 0;
            // 
            // textBoxStopStep_SME
            // 
            this.textBoxStopStep_SME.Location = new System.Drawing.Point(179, 54);
            this.textBoxStopStep_SME.Name = "textBoxStopStep_SME";
            this.textBoxStopStep_SME.Size = new System.Drawing.Size(159, 27);
            this.textBoxStopStep_SME.TabIndex = 0;
            // 
            // buttonHelp_SME
            // 
            this.buttonHelp_SME.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHelp_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SME.Location = new System.Drawing.Point(362, 384);
            this.buttonHelp_SME.Name = "buttonHelp_SME";
            this.buttonHelp_SME.Size = new System.Drawing.Size(95, 79);
            this.buttonHelp_SME.TabIndex = 3;
            this.buttonHelp_SME.Text = "Справка";
            this.buttonHelp_SME.UseVisualStyleBackColor = false;
            this.buttonHelp_SME.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SME.Location = new System.Drawing.Point(463, 384);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(126, 79);
            this.buttonDone_SME.TabIndex = 4;
            this.buttonDone_SME.Text = "Выполнить";
            this.buttonDone_SME.UseVisualStyleBackColor = false;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            this.buttonDone_SME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SME_MouseDown);
            this.buttonDone_SME.MouseEnter += new System.EventHandler(this.buttonDone_SME_MouseEnter);
            this.buttonDone_SME.MouseLeave += new System.EventHandler(this.buttonDone_SME_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 475);
            this.Controls.Add(this.buttonDone_SME);
            this.Controls.Add(this.groupBoxResult_SME);
            this.Controls.Add(this.buttonHelp_SME);
            this.Controls.Add(this.groupBoxData_SME);
            this.Controls.Add(this.groupBoxCondition_SME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 1 | Савенкова М. Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            this.groupBoxResult_SME.ResumeLayout(false);
            this.groupBoxResult_SME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultFunc_SME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartfunc_SME)).EndInit();
            this.groupBoxData_SME.ResumeLayout(false);
            this.groupBoxData_SME.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.GroupBox groupBoxResult_SME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartfunc_SME;
        private System.Windows.Forms.Label labelResult_SME;
        private System.Windows.Forms.GroupBox groupBoxData_SME;
        private System.Windows.Forms.Label labelStopStep_SME;
        private System.Windows.Forms.Label labelStartStep_SME;
        private System.Windows.Forms.TextBox textBoxStartStep_SME;
        private System.Windows.Forms.TextBox textBoxStopStep_SME;
        private System.Windows.Forms.Button buttonHelp_SME;
        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.DataGridView dataGridViewResultFunc_SME;
        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
    }
}

