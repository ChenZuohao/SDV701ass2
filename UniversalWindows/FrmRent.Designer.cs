namespace UniversalWindows
{
    partial class FrmRent
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
            this.lblcarname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.btnROrder = new System.Windows.Forms.Button();
            this.btnRBack = new System.Windows.Forms.Button();
            this.txtRcustomer = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblman = new System.Windows.Forms.Label();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.lblRantCar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcarname
            // 
            this.lblcarname.AutoSize = true;
            this.lblcarname.Location = new System.Drawing.Point(22, 25);
            this.lblcarname.Name = "lblcarname";
            this.lblcarname.Size = new System.Drawing.Size(71, 17);
            this.lblcarname.TabIndex = 0;
            this.lblcarname.Text = "Car Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prace/day";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(33, 222);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(109, 17);
            this.lblCName.TabIndex = 4;
            this.lblCName.Text = "Customer Name";
            // 
            // btnROrder
            // 
            this.btnROrder.Location = new System.Drawing.Point(494, 219);
            this.btnROrder.Name = "btnROrder";
            this.btnROrder.Size = new System.Drawing.Size(75, 23);
            this.btnROrder.TabIndex = 5;
            this.btnROrder.Text = "Order";
            this.btnROrder.UseVisualStyleBackColor = true;
            // 
            // btnRBack
            // 
            this.btnRBack.Location = new System.Drawing.Point(494, 279);
            this.btnRBack.Name = "btnRBack";
            this.btnRBack.Size = new System.Drawing.Size(75, 23);
            this.btnRBack.TabIndex = 6;
            this.btnRBack.Text = "Back";
            this.btnRBack.UseVisualStyleBackColor = true;
            // 
            // txtRcustomer
            // 
            this.txtRcustomer.Location = new System.Drawing.Point(193, 219);
            this.txtRcustomer.Name = "txtRcustomer";
            this.txtRcustomer.Size = new System.Drawing.Size(245, 22);
            this.txtRcustomer.TabIndex = 11;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(33, 279);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(95, 17);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "E-amil Adress";
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Location = new System.Drawing.Point(351, 25);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(87, 17);
            this.lblman.TabIndex = 14;
            this.lblman.Text = "Manufacture";
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(193, 276);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(245, 22);
            this.txtREmail.TabIndex = 17;
            // 
            // lblRantCar
            // 
            this.lblRantCar.FormattingEnabled = true;
            this.lblRantCar.ItemHeight = 16;
            this.lblRantCar.Location = new System.Drawing.Point(25, 46);
            this.lblRantCar.Name = "lblRantCar";
            this.lblRantCar.Size = new System.Drawing.Size(559, 148);
            this.lblRantCar.TabIndex = 18;
            // 
            // FrmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 331);
            this.Controls.Add(this.lblRantCar);
            this.Controls.Add(this.txtREmail);
            this.Controls.Add(this.lblman);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtRcustomer);
            this.Controls.Add(this.btnRBack);
            this.Controls.Add(this.btnROrder);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcarname);
            this.Name = "FrmRent";
            this.Text = "FrmRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcarname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Button btnROrder;
        private System.Windows.Forms.Button btnRBack;
        private System.Windows.Forms.TextBox txtRcustomer;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblman;
        private System.Windows.Forms.TextBox txtREmail;
        private System.Windows.Forms.ListBox lblRantCar;
    }
}