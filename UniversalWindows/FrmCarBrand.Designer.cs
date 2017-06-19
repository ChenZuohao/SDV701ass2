namespace UniversalWindows
{
    partial class FrmCarBrand
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
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.btnBBack = new System.Windows.Forms.Button();
            this.btnbNext = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandCountry = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.ItemHeight = 16;
            this.lstBrand.Location = new System.Drawing.Point(43, 157);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(381, 244);
            this.lstBrand.TabIndex = 0;
            // 
            // btnBBack
            // 
            this.btnBBack.Location = new System.Drawing.Point(446, 279);
            this.btnBBack.Name = "btnBBack";
            this.btnBBack.Size = new System.Drawing.Size(75, 23);
            this.btnBBack.TabIndex = 2;
            this.btnBBack.Text = "Back";
            this.btnBBack.UseVisualStyleBackColor = true;
            // 
            // btnbNext
            // 
            this.btnbNext.Location = new System.Drawing.Point(446, 368);
            this.btnbNext.Name = "btnbNext";
            this.btnbNext.Size = new System.Drawing.Size(75, 23);
            this.btnbNext.TabIndex = 3;
            this.btnbNext.Text = "Next";
            this.btnbNext.UseVisualStyleBackColor = true;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(40, 36);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(87, 17);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand Name";
            // 
            // lblBrandCountry
            // 
            this.lblBrandCountry.AutoSize = true;
            this.lblBrandCountry.Location = new System.Drawing.Point(40, 108);
            this.lblBrandCountry.Name = "lblBrandCountry";
            this.lblBrandCountry.Size = new System.Drawing.Size(57, 17);
            this.lblBrandCountry.TabIndex = 5;
            this.lblBrandCountry.Text = "Country";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(143, 36);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(281, 22);
            this.txtBrand.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(143, 102);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(281, 22);
            this.txtCountry.TabIndex = 7;
            // 
            // FrmCarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 418);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrandCountry);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnbNext);
            this.Controls.Add(this.btnBBack);
            this.Controls.Add(this.lstBrand);
            this.Name = "FrmCarBrand";
            this.Text = "FrmBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Button btnBBack;
        private System.Windows.Forms.Button btnbNext;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandCountry;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtCountry;
    }
}