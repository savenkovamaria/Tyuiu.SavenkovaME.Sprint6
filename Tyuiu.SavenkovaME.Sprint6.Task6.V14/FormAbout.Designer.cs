
namespace Tyuiu.SavenkovaME.Sprint6.Task6.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_SME = new System.Windows.Forms.PictureBox();
            this.buttonClose_SME = new System.Windows.Forms.Button();
            this.labelInfo_SME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SME)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SME
            // 
            this.pictureBoxAvatar_SME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxAvatar_SME.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SME.Image")));
            this.pictureBoxAvatar_SME.Location = new System.Drawing.Point(23, 30);
            this.pictureBoxAvatar_SME.Name = "pictureBoxAvatar_SME";
            this.pictureBoxAvatar_SME.Size = new System.Drawing.Size(177, 229);
            this.pictureBoxAvatar_SME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SME.TabIndex = 0;
            this.pictureBoxAvatar_SME.TabStop = false;
            // 
            // buttonClose_SME
            // 
            this.buttonClose_SME.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose_SME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_SME.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonClose_SME.Location = new System.Drawing.Point(668, 229);
            this.buttonClose_SME.Name = "buttonClose_SME";
            this.buttonClose_SME.Size = new System.Drawing.Size(117, 30);
            this.buttonClose_SME.TabIndex = 1;
            this.buttonClose_SME.Text = "ok";
            this.buttonClose_SME.UseVisualStyleBackColor = false;
            this.buttonClose_SME.Click += new System.EventHandler(this.buttonClose_SME_Click);
            // 
            // labelInfo_SME
            // 
            this.labelInfo_SME.AutoSize = true;
            this.labelInfo_SME.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInfo_SME.Location = new System.Drawing.Point(224, 30);
            this.labelInfo_SME.Name = "labelInfo_SME";
            this.labelInfo_SME.Size = new System.Drawing.Size(460, 180);
            this.labelInfo_SME.TabIndex = 2;
            this.labelInfo_SME.Text = resources.GetString("labelInfo_SME.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(810, 285);
            this.Controls.Add(this.labelInfo_SME);
            this.Controls.Add(this.buttonClose_SME);
            this.Controls.Add(this.pictureBoxAvatar_SME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(771, 332);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SME;
        private System.Windows.Forms.Button buttonClose_SME;
        private System.Windows.Forms.Label labelInfo_SME;
    }
}