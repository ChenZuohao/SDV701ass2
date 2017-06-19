namespace WinForms
{
    partial class FrmBrand
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
            this.lblBName = new System.Windows.Forms.Label();
            this.lblBCountry = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBcountry = new System.Windows.Forms.TextBox();
            this.btnBadd = new System.Windows.Forms.Button();
            this.btnBDelete = new System.Windows.Forms.Button();
            this.btnBBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.ItemHeight = 16;
            this.lstBrand.Location = new System.Drawing.Point(46, 144);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(332, 196);
            this.lstBrand.TabIndex = 0;
            this.lstBrand.SelectedIndexChanged += new System.EventHandler(this.lstBrand_SelectedIndexChanged);
            this.lstBrand.DoubleClick += new System.EventHandler(this.lstBrand_DoubleClick);
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Location = new System.Drawing.Point(43, 21);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(87, 17);
            this.lblBName.TabIndex = 1;
            this.lblBName.Text = "Brand Name";
            // 
            // lblBCountry
            // 
            this.lblBCountry.AutoSize = true;
            this.lblBCountry.Location = new System.Drawing.Point(43, 92);
            this.lblBCountry.Name = "lblBCountry";
            this.lblBCountry.Size = new System.Drawing.Size(99, 17);
            this.lblBCountry.TabIndex = 2;
            this.lblBCountry.Text = "Brand Country";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(193, 21);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(185, 22);
            this.txtBName.TabIndex = 5;
            // 
            // txtBcountry
            // 
            this.txtBcountry.Location = new System.Drawing.Point(193, 92);
            this.txtBcountry.Name = "txtBcountry";
            this.txtBcountry.Size = new System.Drawing.Size(185, 22);
            this.txtBcountry.TabIndex = 6;
            // 
            // btnBadd
            // 
            this.btnBadd.Location = new System.Drawing.Point(24, 382);
            this.btnBadd.Name = "btnBadd";
            this.btnBadd.Size = new System.Drawing.Size(106, 35);
            this.btnBadd.TabIndex = 9;
            this.btnBadd.Text = "Add";
            this.btnBadd.UseVisualStyleBackColor = true;
            this.btnBadd.Click += new System.EventHandler(this.btnBadd_Click);
            // 
            // btnBDelete
            // 
            this.btnBDelete.Location = new System.Drawing.Point(149, 382);
            this.btnBDelete.Name = "btnBDelete";
            this.btnBDelete.Size = new System.Drawing.Size(106, 35);
            this.btnBDelete.TabIndex = 10;
            this.btnBDelete.Text = "Delete";
            this.btnBDelete.UseVisualStyleBackColor = true;
            this.btnBDelete.Click += new System.EventHandler(this.btnBDelete_Click);
            // 
            // btnBBack
            // 
            this.btnBBack.Location = new System.Drawing.Point(272, 382);
            this.btnBBack.Name = "btnBBack";
            this.btnBBack.Size = new System.Drawing.Size(106, 35);
            this.btnBBack.TabIndex = 11;
            this.btnBBack.Text = "Quit";
            this.btnBBack.UseVisualStyleBackColor = true;
            this.btnBBack.Click += new System.EventHandler(this.btnBBack_Click);
            // 
            // FrmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 449);
            this.Controls.Add(this.btnBBack);
            this.Controls.Add(this.btnBDelete);
            this.Controls.Add(this.btnBadd);
            this.Controls.Add(this.txtBcountry);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.lblBCountry);
            this.Controls.Add(this.lblBName);
            this.Controls.Add(this.lstBrand);
            this.Name = "FrmBrand";
            this.Text = "FrmBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.Label lblBCountry;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBcountry;
        private System.Windows.Forms.Button btnBadd;
        private System.Windows.Forms.Button btnBDelete;
        private System.Windows.Forms.Button btnBBack;
    }
}