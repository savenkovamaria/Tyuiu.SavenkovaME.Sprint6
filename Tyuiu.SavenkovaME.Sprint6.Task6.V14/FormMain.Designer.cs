
namespace Tyuiu.SavenkovaME.Sprint6.Task6.V14
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
            this.panelData_SME = new System.Windows.Forms.Panel();
            this.buttonInfo_SME = new System.Windows.Forms.Button();
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.groupBoxData_SME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.panelOpenFile_SME = new System.Windows.Forms.Panel();
            this.groupBoxInput_SME = new System.Windows.Forms.GroupBox();
            this.textBoxFile_SME = new System.Windows.Forms.TextBox();
            this.panelResultFile_SME = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SME = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SME = new System.Windows.Forms.TextBox();
            this.splitterWindows_SME = new System.Windows.Forms.Splitter();
            this.buttonOpenFile_SME = new System.Windows.Forms.Button();
            this.openFileDialog_SME = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SME = new System.Windows.Forms.ToolTip(this.components);
            this.panelData_SME.SuspendLayout();
            this.groupBoxData_SME.SuspendLayout();
            this.panelOpenFile_SME.SuspendLayout();
            this.groupBoxInput_SME.SuspendLayout();
            this.panelResultFile_SME.SuspendLayout();
            this.groupBoxOutPut_SME.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData_SME
            // 
            this.panelData_SME.Controls.Add(this.buttonOpenFile_SME);
            this.panelData_SME.Controls.Add(this.buttonInfo_SME);
            this.panelData_SME.Controls.Add(this.buttonDone_SME);
            this.panelData_SME.Controls.Add(this.groupBoxData_SME);
            this.panelData_SME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_SME.Location = new System.Drawing.Point(0, 0);
            this.panelData_SME.Name = "panelData_SME";
            this.panelData_SME.Size = new System.Drawing.Size(1147, 188);
            this.panelData_SME.TabIndex = 0;
            // 
            // buttonInfo_SME
            // 
            this.buttonInfo_SME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_SME.Image")));
            this.buttonInfo_SME.Location = new System.Drawing.Point(1038, 12);
            this.buttonInfo_SME.Name = "buttonInfo_SME";
            this.buttonInfo_SME.Size = new System.Drawing.Size(97, 71);
            this.buttonInfo_SME.TabIndex = 1;
            this.toolTip_SME.SetToolTip(this.buttonInfo_SME, "Сведения о программе");
            this.buttonInfo_SME.UseVisualStyleBackColor = true;
            this.buttonInfo_SME.Click += new System.EventHandler(this.buttonInfo_SME_Click);
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SME.Image")));
            this.buttonDone_SME.Location = new System.Drawing.Point(116, 12);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(97, 71);
            this.buttonDone_SME.TabIndex = 1;
            this.toolTip_SME.SetToolTip(this.buttonDone_SME, "Выводит слова в которых встречается \"z\"\r\nи конкатенирует их");
            this.buttonDone_SME.UseVisualStyleBackColor = true;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // groupBoxData_SME
            // 
            this.groupBoxData_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxData_SME.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxData_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_SME.Location = new System.Drawing.Point(0, 97);
            this.groupBoxData_SME.Name = "groupBoxData_SME";
            this.groupBoxData_SME.Size = new System.Drawing.Size(1147, 91);
            this.groupBoxData_SME.TabIndex = 0;
            this.groupBoxData_SME.TabStop = false;
            this.groupBoxData_SME.Text = "Условие";
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(13, 22);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(1109, 63);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = resources.GetString("textBoxTask_SME.Text");
            // 
            // panelOpenFile_SME
            // 
            this.panelOpenFile_SME.Controls.Add(this.groupBoxInput_SME);
            this.panelOpenFile_SME.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpenFile_SME.Location = new System.Drawing.Point(0, 188);
            this.panelOpenFile_SME.Name = "panelOpenFile_SME";
            this.panelOpenFile_SME.Size = new System.Drawing.Size(559, 398);
            this.panelOpenFile_SME.TabIndex = 0;
            // 
            // groupBoxInput_SME
            // 
            this.groupBoxInput_SME.Controls.Add(this.textBoxFile_SME);
            this.groupBoxInput_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_SME.Name = "groupBoxInput_SME";
            this.groupBoxInput_SME.Size = new System.Drawing.Size(559, 398);
            this.groupBoxInput_SME.TabIndex = 0;
            this.groupBoxInput_SME.TabStop = false;
            this.groupBoxInput_SME.Text = "Ввод данных";
            // 
            // textBoxFile_SME
            // 
            this.textBoxFile_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFile_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile_SME.Location = new System.Drawing.Point(14, 33);
            this.textBoxFile_SME.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textBoxFile_SME.Multiline = true;
            this.textBoxFile_SME.Name = "textBoxFile_SME";
            this.textBoxFile_SME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFile_SME.Size = new System.Drawing.Size(542, 362);
            this.textBoxFile_SME.TabIndex = 0;
            // 
            // panelResultFile_SME
            // 
            this.panelResultFile_SME.Controls.Add(this.groupBoxOutPut_SME);
            this.panelResultFile_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultFile_SME.Location = new System.Drawing.Point(559, 188);
            this.panelResultFile_SME.Name = "panelResultFile_SME";
            this.panelResultFile_SME.Size = new System.Drawing.Size(588, 398);
            this.panelResultFile_SME.TabIndex = 0;
            this.panelResultFile_SME.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultFile_SME_Paint);
            // 
            // groupBoxOutPut_SME
            // 
            this.groupBoxOutPut_SME.Controls.Add(this.textBoxResult_SME);
            this.groupBoxOutPut_SME.Controls.Add(this.splitterWindows_SME);
            this.groupBoxOutPut_SME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SME.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SME.Name = "groupBoxOutPut_SME";
            this.groupBoxOutPut_SME.Size = new System.Drawing.Size(588, 398);
            this.groupBoxOutPut_SME.TabIndex = 1;
            this.groupBoxOutPut_SME.TabStop = false;
            this.groupBoxOutPut_SME.Text = "Вывод данных";
            // 
            // textBoxResult_SME
            // 
            this.textBoxResult_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_SME.Location = new System.Drawing.Point(12, 33);
            this.textBoxResult_SME.Multiline = true;
            this.textBoxResult_SME.Name = "textBoxResult_SME";
            this.textBoxResult_SME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SME.Size = new System.Drawing.Size(573, 362);
            this.textBoxResult_SME.TabIndex = 1;
            // 
            // splitterWindows_SME
            // 
            this.splitterWindows_SME.Location = new System.Drawing.Point(3, 20);
            this.splitterWindows_SME.Name = "splitterWindows_SME";
            this.splitterWindows_SME.Size = new System.Drawing.Size(3, 375);
            this.splitterWindows_SME.TabIndex = 0;
            this.splitterWindows_SME.TabStop = false;
            // 
            // buttonOpenFile_SME
            // 
            this.buttonOpenFile_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SME.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SME.Image")));
            this.buttonOpenFile_SME.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SME.Name = "buttonOpenFile_SME";
            this.buttonOpenFile_SME.Size = new System.Drawing.Size(97, 71);
            this.buttonOpenFile_SME.TabIndex = 2;
            this.toolTip_SME.SetToolTip(this.buttonOpenFile_SME, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SME.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SME.Click += new System.EventHandler(this.buttonOpenFile_SME_Click);
            // 
            // openFileDialog_SME
            // 
            this.openFileDialog_SME.FileName = "InPutFileTask6V14";
            // 
            // toolTip_SME
            // 
            this.toolTip_SME.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SME.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 586);
            this.Controls.Add(this.panelResultFile_SME);
            this.Controls.Add(this.panelOpenFile_SME);
            this.Controls.Add(this.panelData_SME);
            this.MinimumSize = new System.Drawing.Size(1165, 633);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Савенкова М. Е.";
            this.panelData_SME.ResumeLayout(false);
            this.groupBoxData_SME.ResumeLayout(false);
            this.groupBoxData_SME.PerformLayout();
            this.panelOpenFile_SME.ResumeLayout(false);
            this.groupBoxInput_SME.ResumeLayout(false);
            this.groupBoxInput_SME.PerformLayout();
            this.panelResultFile_SME.ResumeLayout(false);
            this.groupBoxOutPut_SME.ResumeLayout(false);
            this.groupBoxOutPut_SME.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData_SME;
        private System.Windows.Forms.Panel panelOpenFile_SME;
        private System.Windows.Forms.Panel panelResultFile_SME;
        private System.Windows.Forms.GroupBox groupBoxData_SME;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SME;
        private System.Windows.Forms.Splitter splitterWindows_SME;
        private System.Windows.Forms.GroupBox groupBoxInput_SME;
        private System.Windows.Forms.Button buttonInfo_SME;
        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.TextBox textBoxFile_SME;
        private System.Windows.Forms.TextBox textBoxResult_SME;
        private System.Windows.Forms.Button buttonOpenFile_SME;
        private System.Windows.Forms.ToolTip toolTip_SME;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SME;
    }
}

