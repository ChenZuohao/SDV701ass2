namespace UniversalWindows
{
    partial class FrmSell
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSOrder = new System.Windows.Forms.Button();
            this.btnSBack = new System.Windows.Forms.Button();
            this.lisSell = new System.Windows.Forms.ListBox();
            this.lblman = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtsEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Price";
            // 
            // btnSOrder
            // 
            this.btnSOrder.Location = new System.Drawing.Point(525, 258);
            this.btnSOrder.Name = "btnSOrder";
            this.btnSOrder.Size = new System.Drawing.Size(83, 29);
            this.btnSOrder.TabIndex = 15;
            this.btnSOrder.Text = "Order";
            this.btnSOrder.UseVisualStyleBackColor = true;
            // 
            // btnSBack
            // 
            this.btnSBack.Location = new System.Drawing.Point(525, 318);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(83, 29);
            this.btnSBack.TabIndex = 16;
            this.btnSBack.Text = "Back";
            this.btnSBack.UseVisualStyleBackColor = true;
            // 
            // lisSell
            // 
            this.lisSell.FormattingEnabled = true;
            this.lisSell.ItemHeight = 16;
            this.lisSell.Location = new System.Drawing.Point(35, 60);
            this.lisSell.Name = "lisSell";
            this.lisSell.Size = new System.Drawing.Size(597, 180);
            this.lisSell.TabIndex = 17;
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Location = new System.Drawing.Point(355, 26);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(87, 17);
            this.lblman.TabIndex = 18;
            this.lblman.Text = "Manufacture";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(32, 258);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(109, 17);
            this.lblCName.TabIndex = 19;
            this.lblCName.Text = "Customer Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(32, 318);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(95, 17);
            this.lblemail.TabIndex = 20;
            this.lblemail.Text = "E-amil Adress";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(188, 255);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(245, 22);
            this.txtSName.TabIndex = 21;
            // 
            // txtsEmail
            // 
            this.txtsEmail.Location = new System.Drawing.Point(188, 315);
            this.txtsEmail.Name = "txtsEmail";
            this.txtsEmail.Size = new System.Drawing.Size(245, 22);
            this.txtsEmail.TabIndex = 22;
            // 
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 361);
            this.Controls.Add(this.txtsEmail);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblman);
            this.Controls.Add(this.lisSell);
            this.Controls.Add(this.btnSBack);
            this.Controls.Add(this.btnSOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSell";
            this.Text = "Frmsell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSOrder;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.ListBox lisSell;
        private System.Windows.Forms.Label lblman;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtsEmail;
    }
}