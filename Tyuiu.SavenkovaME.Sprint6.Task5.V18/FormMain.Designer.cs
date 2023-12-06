
namespace Tyuiu.SavenkovaME.Sprint6.Task5.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelData_SME = new System.Windows.Forms.Panel();
            this.panelRes_SME = new System.Windows.Forms.Panel();
            this.panelDiagram_SME = new System.Windows.Forms.Panel();
            this.splitterWindows_SME = new System.Windows.Forms.Splitter();
            this.groupBoxData_SME = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_SME = new System.Windows.Forms.GroupBox();
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.buttonOpen_SME = new System.Windows.Forms.Button();
            this.buttonHelp_SME = new System.Windows.Forms.Button();
            this.chartDiagramm_SME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.dataGridViewResult_SME = new System.Windows.Forms.DataGridView();
            this.panelData_SME.SuspendLayout();
            this.panelRes_SME.SuspendLayout();
            this.panelDiagram_SME.SuspendLayout();
            this.groupBoxData_SME.SuspendLayout();
            this.groupBoxResult_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramm_SME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SME)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData_SME
            // 
            this.panelData_SME.Controls.Add(this.buttonHelp_SME);
            this.panelData_SME.Controls.Add(this.buttonOpen_SME);
            this.panelData_SME.Controls.Add(this.buttonDone_SME);
            this.panelData_SME.Controls.Add(this.groupBoxData_SME);
            this.panelData_SME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_SME.Location = new System.Drawing.Point(0, 0);
            this.panelData_SME.Name = "panelData_SME";
            this.panelData_SME.Size = new System.Drawing.Size(1107, 134);
            this.panelData_SME.TabIndex = 0;
            // 
            // panelRes_SME
            // 
            this.panelRes_SME.Controls.Add(this.groupBoxResult_SME);
            this.panelRes_SME.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRes_SME.Location = new System.Drawing.Point(0, 134);
            this.panelRes_SME.Name = "panelRes_SME";
            this.panelRes_SME.Size = new System.Drawing.Size(270, 497);
            this.panelRes_SME.TabIndex = 0;
            // 
            // panelDiagram_SME
            // 
            this.panelDiagram_SME.Controls.Add(this.chartDiagramm_SME);
            this.panelDiagram_SME.Controls.Add(this.splitterWindows_SME);
            this.panelDiagram_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagram_SME.Location = new System.Drawing.Point(270, 134);
            this.panelDiagram_SME.Name = "panelDiagram_SME";
            this.panelDiagram_SME.Size = new System.Drawing.Size(837, 497);
            this.panelDiagram_SME.TabIndex = 0;
            // 
            // splitterWindows_SME
            // 
            this.splitterWindows_SME.Location = new System.Drawing.Point(0, 0);
            this.splitterWindows_SME.Name = "splitterWindows_SME";
            this.splitterWindows_SME.Size = new System.Drawing.Size(3, 497);
            this.splitterWindows_SME.TabIndex = 0;
            this.splitterWindows_SME.TabStop = false;
            // 
            // groupBoxData_SME
            // 
            this.groupBoxData_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxData_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_SME.Location = new System.Drawing.Point(4, 4);
            this.groupBoxData_SME.Name = "groupBoxData_SME";
            this.groupBoxData_SME.Size = new System.Drawing.Size(668, 124);
            this.groupBoxData_SME.TabIndex = 0;
            this.groupBoxData_SME.TabStop = false;
            this.groupBoxData_SME.Text = "Условие";
            this.groupBoxData_SME.Enter += new System.EventHandler(this.groupBoxData_SME_Enter);
            // 
            // groupBoxResult_SME
            // 
            this.groupBoxResult_SME.Controls.Add(this.dataGridViewResult_SME);
            this.groupBoxResult_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SME.Name = "groupBoxResult_SME";
            this.groupBoxResult_SME.Size = new System.Drawing.Size(270, 497);
            this.groupBoxResult_SME.TabIndex = 0;
            this.groupBoxResult_SME.TabStop = false;
            this.groupBoxResult_SME.Text = "Вывод данных";
            this.groupBoxResult_SME.Enter += new System.EventHandler(this.groupBoxResult_SME_Enter);
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_SME.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDone_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SME.Location = new System.Drawing.Point(678, 12);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(135, 115);
            this.buttonDone_SME.TabIndex = 1;
            this.buttonDone_SME.Text = "Выполнить";
            this.buttonDone_SME.UseVisualStyleBackColor = false;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // buttonOpen_SME
            // 
            this.buttonOpen_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_SME.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOpen_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_SME.Location = new System.Drawing.Point(819, 12);
            this.buttonOpen_SME.Name = "buttonOpen_SME";
            this.buttonOpen_SME.Size = new System.Drawing.Size(135, 115);
            this.buttonOpen_SME.TabIndex = 1;
            this.buttonOpen_SME.Text = "Открыть файл";
            this.buttonOpen_SME.UseVisualStyleBackColor = false;
            this.buttonOpen_SME.Click += new System.EventHandler(this.buttonOpen_SME_Click);
            // 
            // buttonHelp_SME
            // 
            this.buttonHelp_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SME.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonHelp_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SME.Location = new System.Drawing.Point(960, 12);
            this.buttonHelp_SME.Name = "buttonHelp_SME";
            this.buttonHelp_SME.Size = new System.Drawing.Size(135, 115);
            this.buttonHelp_SME.TabIndex = 1;
            this.buttonHelp_SME.Text = "Справка";
            this.buttonHelp_SME.UseVisualStyleBackColor = false;
            this.buttonHelp_SME.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // chartDiagramm_SME
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiagramm_SME.ChartAreas.Add(chartArea2);
            this.chartDiagramm_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiagramm_SME.Legends.Add(legend2);
            this.chartDiagramm_SME.Location = new System.Drawing.Point(3, 0);
            this.chartDiagramm_SME.Name = "chartDiagramm_SME";
            this.chartDiagramm_SME.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiagramm_SME.Series.Add(series2);
            this.chartDiagramm_SME.Size = new System.Drawing.Size(834, 497);
            this.chartDiagramm_SME.TabIndex = 1;
            this.chartDiagramm_SME.Text = "chart1";
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(655, 87);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = "Прочитать данные из файла InPutFileTask5V18.txt. Вывести в dataGridView. \r\nВывест" +
    "и все вещественные числа.  Построить диаграмму по этим значениям. ";
            this.textBoxTask_SME.TextChanged += new System.EventHandler(this.textBoxTask_SME_TextChanged);
            // 
            // dataGridViewResult_SME
            // 
            this.dataGridViewResult_SME.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewResult_SME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SME.ColumnHeadersVisible = false;
            this.dataGridViewResult_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SME.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewResult_SME.Name = "dataGridViewResult_SME";
            this.dataGridViewResult_SME.RowHeadersVisible = false;
            this.dataGridViewResult_SME.RowHeadersWidth = 51;
            this.dataGridViewResult_SME.RowTemplate.Height = 24;
            this.dataGridViewResult_SME.Size = new System.Drawing.Size(264, 471);
            this.dataGridViewResult_SME.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 631);
            this.Controls.Add(this.panelDiagram_SME);
            this.Controls.Add(this.panelRes_SME);
            this.Controls.Add(this.panelData_SME);
            this.MinimumSize = new System.Drawing.Size(1125, 678);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 18 | Савенкова М. Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelData_SME.ResumeLayout(false);
            this.panelRes_SME.ResumeLayout(false);
            this.panelDiagram_SME.ResumeLayout(false);
            this.groupBoxData_SME.ResumeLayout(false);
            this.groupBoxData_SME.PerformLayout();
            this.groupBoxResult_SME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramm_SME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData_SME;
        private System.Windows.Forms.Button buttonHelp_SME;
        private System.Windows.Forms.Button buttonOpen_SME;
        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.GroupBox groupBoxData_SME;
        private System.Windows.Forms.Panel panelRes_SME;
        private System.Windows.Forms.GroupBox groupBoxResult_SME;
        private System.Windows.Forms.Panel panelDiagram_SME;
        private System.Windows.Forms.Splitter splitterWindows_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagramm_SME;
        private System.Windows.Forms.DataGridView dataGridViewResult_SME;
    }
}

