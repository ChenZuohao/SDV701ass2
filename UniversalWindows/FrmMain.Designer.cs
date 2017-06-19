namespace UniversalWindows
{
    partial class FrmMain
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
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstBrandlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(129, 18);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(72, 17);
            this.lblCarBrand.TabIndex = 0;
            this.lblCarBrand.Text = "Car Brand";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(312, 385);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lstBrandlist
            // 
            this.lstBrandlist.FormattingEnabled = true;
            this.lstBrandlist.ItemHeight = 16;
            this.lstBrandlist.Location = new System.Drawing.Point(43, 52);
            this.lstBrandlist.Name = "lstBrandlist";
            this.lstBrandlist.Size = new System.Drawing.Size(263, 356);
            this.lstBrandlist.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 437);
            this.Controls.Add(this.lstBrandlist);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCarBrand);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstBrandlist;
    }
}

