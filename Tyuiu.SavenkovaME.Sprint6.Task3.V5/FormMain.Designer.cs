
namespace Tyuiu.SavenkovaME.Sprint6.Task3.V5
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
            this.groupBoxCondition_SME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SME = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SME = new System.Windows.Forms.DataGridView();
            this.buttonHelp_SME = new System.Windows.Forms.Button();
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.groupBoxCondition_SME.SuspendLayout();
            this.groupBoxResult_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SME)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SME
            // 
            this.groupBoxCondition_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxCondition_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SME.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            this.groupBoxCondition_SME.Size = new System.Drawing.Size(607, 345);
            this.groupBoxCondition_SME.TabIndex = 0;
            this.groupBoxCondition_SME.TabStop = false;
            this.groupBoxCondition_SME.Text = "Условие";
            this.groupBoxCondition_SME.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(583, 298);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = "Дан массив 5 на 5 элементов. \r\nВыполнить сортировку по возрастанию в третьем стол" +
    "бце.\r\n\r\n30 -20   7   -8    9\r\n32  17 -14  -7   33\r\n9  -19  -13  14 -20\r\n11  30  " +
    "-1    26   6\r\n30 -15 -20  -5   15";
            // 
            // groupBoxResult_SME
            // 
            this.groupBoxResult_SME.Controls.Add(this.dataGridViewMatrix_SME);
            this.groupBoxResult_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SME.Location = new System.Drawing.Point(625, 12);
            this.groupBoxResult_SME.Name = "groupBoxResult_SME";
            this.groupBoxResult_SME.Size = new System.Drawing.Size(283, 275);
            this.groupBoxResult_SME.TabIndex = 0;
            this.groupBoxResult_SME.TabStop = false;
            this.groupBoxResult_SME.Text = "Вывод данных";
            this.groupBoxResult_SME.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewMatrix_SME
            // 
            this.dataGridViewMatrix_SME.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrix_SME.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMatrix_SME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SME.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SME.Location = new System.Drawing.Point(7, 27);
            this.dataGridViewMatrix_SME.Name = "dataGridViewMatrix_SME";
            this.dataGridViewMatrix_SME.ReadOnly = true;
            this.dataGridViewMatrix_SME.RowHeadersVisible = false;
            this.dataGridViewMatrix_SME.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SME.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SME.Size = new System.Drawing.Size(270, 233);
            this.dataGridViewMatrix_SME.TabIndex = 0;
            this.dataGridViewMatrix_SME.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonHelp_SME
            // 
            this.buttonHelp_SME.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonHelp_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SME.Location = new System.Drawing.Point(625, 293);
            this.buttonHelp_SME.Name = "buttonHelp_SME";
            this.buttonHelp_SME.Size = new System.Drawing.Size(68, 64);
            this.buttonHelp_SME.TabIndex = 1;
            this.buttonHelp_SME.Text = "?";
            this.buttonHelp_SME.UseVisualStyleBackColor = false;
            this.buttonHelp_SME.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SME.Location = new System.Drawing.Point(699, 293);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(203, 64);
            this.buttonDone_SME.TabIndex = 1;
            this.buttonDone_SME.Text = "Выполнить";
            this.buttonDone_SME.UseVisualStyleBackColor = false;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 373);
            this.Controls.Add(this.buttonDone_SME);
            this.Controls.Add(this.buttonHelp_SME);
            this.Controls.Add(this.groupBoxResult_SME);
            this.Controls.Add(this.groupBoxCondition_SME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 5 | Савенкова М. Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.PerformLayout();
            this.groupBoxResult_SME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.GroupBox groupBoxResult_SME;
        private System.Windows.Forms.Button buttonHelp_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SME;
        private System.Windows.Forms.Button buttonDone_SME;
    }
}

