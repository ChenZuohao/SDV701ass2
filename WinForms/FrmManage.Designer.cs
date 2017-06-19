namespace WinForms
{
    partial class FrmManage
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lstMange = new System.Windows.Forms.ListBox();
            this.BtnMback = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(81, 9);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 17);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand";
            // 
            // lstMange
            // 
            this.lstMange.FormattingEnabled = true;
            this.lstMange.ItemHeight = 16;
            this.lstMange.Location = new System.Drawing.Point(21, 45);
            this.lstMange.Name = "lstMange";
            this.lstMange.Size = new System.Drawing.Size(201, 212);
            this.lstMange.TabIndex = 1;
            this.lstMange.DoubleClick += new System.EventHandler(this.lstMange_DoubleClick);
            // 
            // BtnMback
            // 
            this.BtnMback.Location = new System.Drawing.Point(228, 258);
            this.BtnMback.Name = "BtnMback";
            this.BtnMback.Size = new System.Drawing.Size(75, 31);
            this.BtnMback.TabIndex = 2;
            this.BtnMback.Text = "Back";
            this.BtnMback.UseVisualStyleBackColor = true;
            this.BtnMback.Click += new System.EventHandler(this.BtnMback_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(228, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 301);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnMback);
            this.Controls.Add(this.lstMange);
            this.Controls.Add(this.lblBrand);
            this.Name = "FrmManage";
            this.Text = "FrmManage";
            this.Load += new System.EventHandler(this.FrmManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ListBox lstMange;
        private System.Windows.Forms.Button BtnMback;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}