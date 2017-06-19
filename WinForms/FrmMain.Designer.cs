namespace WinForms
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
            this.BtnManage = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnManage
            // 
            this.BtnManage.Location = new System.Drawing.Point(208, 83);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(119, 28);
            this.BtnManage.TabIndex = 0;
            this.BtnManage.Text = "Manage";
            this.BtnManage.UseVisualStyleBackColor = true;
            this.BtnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(205, 34);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(122, 17);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Car Shop Manage";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(208, 163);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 253);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.BtnManage);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnManage;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOrder;
    }
}

