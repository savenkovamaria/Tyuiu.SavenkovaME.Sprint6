
namespace Tyuiu.SavenkovaME.Sprint6.Task0.V20
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
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.buttonHelp_SME = new System.Windows.Forms.Button();
            this.groupBoxCondition_SME = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SME = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_SME = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_SME = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_SME = new System.Windows.Forms.TextBox();
            this.labelVarX_SME = new System.Windows.Forms.Label();
            this.groupBoxResult_SME = new System.Windows.Forms.GroupBox();
            this.labelResult_SME = new System.Windows.Forms.Label();
            this.textBoxResult_SME = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SME)).BeginInit();
            this.groupBoxInfo_SME.SuspendLayout();
            this.groupBoxResult_SME.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SME.Location = new System.Drawing.Point(707, 375);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(157, 63);
            this.buttonDone_SME.TabIndex = 0;
            this.buttonDone_SME.Text = "Выполнить";
            this.buttonDone_SME.UseVisualStyleBackColor = true;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // buttonHelp_SME
            // 
            this.buttonHelp_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SME.Location = new System.Drawing.Point(638, 375);
            this.buttonHelp_SME.Name = "buttonHelp_SME";
            this.buttonHelp_SME.Size = new System.Drawing.Size(63, 63);
            this.buttonHelp_SME.TabIndex = 1;
            this.buttonHelp_SME.Text = "?";
            this.buttonHelp_SME.UseVisualStyleBackColor = true;
            this.buttonHelp_SME.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // groupBoxCondition_SME
            // 
            this.groupBoxCondition_SME.Controls.Add(this.pictureBoxFormula_SME);
            this.groupBoxCondition_SME.Controls.Add(this.textBoxCondition_SME);
            this.groupBoxCondition_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SME.Location = new System.Drawing.Point(21, 32);
            this.groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            this.groupBoxCondition_SME.Size = new System.Drawing.Size(843, 208);
            this.groupBoxCondition_SME.TabIndex = 2;
            this.groupBoxCondition_SME.TabStop = false;
            this.groupBoxCondition_SME.Text = "Условие";
            this.groupBoxCondition_SME.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxFormula_SME
            // 
            this.pictureBoxFormula_SME.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SME.Image")));
            this.pictureBoxFormula_SME.InitialImage = null;
            this.pictureBoxFormula_SME.Location = new System.Drawing.Point(602, 32);
            this.pictureBoxFormula_SME.Name = "pictureBoxFormula_SME";
            this.pictureBoxFormula_SME.Size = new System.Drawing.Size(215, 100);
            this.pictureBoxFormula_SME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_SME.TabIndex = 3;
            this.pictureBoxFormula_SME.TabStop = false;
            this.pictureBoxFormula_SME.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxCondition_SME
            // 
            this.textBoxCondition_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_SME.Location = new System.Drawing.Point(12, 32);
            this.textBoxCondition_SME.Multiline = true;
            this.textBoxCondition_SME.Name = "textBoxCondition_SME";
            this.textBoxCondition_SME.Size = new System.Drawing.Size(598, 161);
            this.textBoxCondition_SME.TabIndex = 0;
            this.textBoxCondition_SME.Text = "Вычислить выражение по формуле";
            this.textBoxCondition_SME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxInfo_SME
            // 
            this.groupBoxInfo_SME.Controls.Add(this.textBoxVarX_SME);
            this.groupBoxInfo_SME.Controls.Add(this.labelVarX_SME);
            this.groupBoxInfo_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfo_SME.Location = new System.Drawing.Point(21, 246);
            this.groupBoxInfo_SME.Name = "groupBoxInfo_SME";
            this.groupBoxInfo_SME.Size = new System.Drawing.Size(585, 114);
            this.groupBoxInfo_SME.TabIndex = 3;
            this.groupBoxInfo_SME.TabStop = false;
            this.groupBoxInfo_SME.Text = "Ввод данных";
            // 
            // textBoxVarX_SME
            // 
            this.textBoxVarX_SME.Location = new System.Drawing.Point(17, 58);
            this.textBoxVarX_SME.Name = "textBoxVarX_SME";
            this.textBoxVarX_SME.Size = new System.Drawing.Size(131, 27);
            this.textBoxVarX_SME.TabIndex = 2;
            this.textBoxVarX_SME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SME_KeyPress);
            // 
            // labelVarX_SME
            // 
            this.labelVarX_SME.AutoSize = true;
            this.labelVarX_SME.Location = new System.Drawing.Point(13, 35);
            this.labelVarX_SME.Name = "labelVarX_SME";
            this.labelVarX_SME.Size = new System.Drawing.Size(135, 20);
            this.labelVarX_SME.TabIndex = 1;
            this.labelVarX_SME.Text = "Переменная X:";
            this.labelVarX_SME.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxResult_SME
            // 
            this.groupBoxResult_SME.Controls.Add(this.labelResult_SME);
            this.groupBoxResult_SME.Controls.Add(this.textBoxResult_SME);
            this.groupBoxResult_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SME.Location = new System.Drawing.Point(612, 246);
            this.groupBoxResult_SME.Name = "groupBoxResult_SME";
            this.groupBoxResult_SME.Size = new System.Drawing.Size(252, 111);
            this.groupBoxResult_SME.TabIndex = 4;
            this.groupBoxResult_SME.TabStop = false;
            this.groupBoxResult_SME.Text = "Вывод данных";
            // 
            // labelResult_SME
            // 
            this.labelResult_SME.AutoSize = true;
            this.labelResult_SME.Location = new System.Drawing.Point(11, 35);
            this.labelResult_SME.Name = "labelResult_SME";
            this.labelResult_SME.Size = new System.Drawing.Size(102, 20);
            this.labelResult_SME.TabIndex = 1;
            this.labelResult_SME.Text = "Результат:";
            this.labelResult_SME.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResult_SME
            // 
            this.textBoxResult_SME.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_SME.Location = new System.Drawing.Point(15, 58);
            this.textBoxResult_SME.Name = "textBoxResult_SME";
            this.textBoxResult_SME.ReadOnly = true;
            this.textBoxResult_SME.Size = new System.Drawing.Size(151, 27);
            this.textBoxResult_SME.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.groupBoxResult_SME);
            this.Controls.Add(this.groupBoxInfo_SME);
            this.Controls.Add(this.groupBoxCondition_SME);
            this.Controls.Add(this.buttonHelp_SME);
            this.Controls.Add(this.buttonDone_SME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Савенкова М. Е.";
            this.groupBoxCondition_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SME)).EndInit();
            this.groupBoxInfo_SME.ResumeLayout(false);
            this.groupBoxInfo_SME.PerformLayout();
            this.groupBoxResult_SME.ResumeLayout(false);
            this.groupBoxResult_SME.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.Button buttonHelp_SME;
        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.TextBox textBoxCondition_SME;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SME;
        private System.Windows.Forms.GroupBox groupBoxInfo_SME;
        private System.Windows.Forms.Label labelVarX_SME;
        private System.Windows.Forms.GroupBox groupBoxResult_SME;
        private System.Windows.Forms.Label labelResult_SME;
        private System.Windows.Forms.TextBox textBoxResult_SME;
        private System.Windows.Forms.TextBox textBoxVarX_SME;
    }
}

