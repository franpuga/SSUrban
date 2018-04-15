namespace SSUrban
{
    partial class SplashForm
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
            this.pbSplashForm = new System.Windows.Forms.PictureBox();
            this.lblLoadInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSplashForm
            // 
            this.pbSplashForm.BackColor = System.Drawing.Color.Silver;
            this.pbSplashForm.Image = global::SSUrban.Properties.Resources.S_S___marca_vertital;
            this.pbSplashForm.InitialImage = global::SSUrban.Properties.Resources.S_S___marca_vertital;
            this.pbSplashForm.Location = new System.Drawing.Point(12, 12);
            this.pbSplashForm.Name = "pbSplashForm";
            this.pbSplashForm.Size = new System.Drawing.Size(557, 330);
            this.pbSplashForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplashForm.TabIndex = 0;
            this.pbSplashForm.TabStop = false;
            // 
            // lblLoadInfo
            // 
            this.lblLoadInfo.AutoSize = true;
            this.lblLoadInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoadInfo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadInfo.Location = new System.Drawing.Point(0, 352);
            this.lblLoadInfo.Name = "lblLoadInfo";
            this.lblLoadInfo.Size = new System.Drawing.Size(0, 16);
            this.lblLoadInfo.TabIndex = 1;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(583, 368);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoadInfo);
            this.Controls.Add(this.pbSplashForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplashForm;
        private System.Windows.Forms.Label lblLoadInfo;
    }
}