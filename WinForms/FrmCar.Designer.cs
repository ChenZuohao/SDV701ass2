namespace WinForms
{
    partial class FrmCar
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblcarid = new System.Windows.Forms.Label();
            this.lblcarprice = new System.Windows.Forms.Label();
            this.lblman = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblrantp = new System.Windows.Forms.Label();
            this.txtManDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(335, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(24, 18);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(67, 17);
            this.lblCarName.TabIndex = 2;
            this.lblCarName.Text = "CarName";
            // 
            // lblcarid
            // 
            this.lblcarid.AutoSize = true;
            this.lblcarid.Location = new System.Drawing.Point(35, 63);
            this.lblcarid.Name = "lblcarid";
            this.lblcarid.Size = new System.Drawing.Size(47, 17);
            this.lblcarid.TabIndex = 3;
            this.lblcarid.Text = "Car ID";
            // 
            // lblcarprice
            // 
            this.lblcarprice.AutoSize = true;
            this.lblcarprice.Location = new System.Drawing.Point(67, 106);
            this.lblcarprice.Name = "lblcarprice";
            this.lblcarprice.Size = new System.Drawing.Size(0, 17);
            this.lblcarprice.TabIndex = 4;
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Location = new System.Drawing.Point(24, 106);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(87, 17);
            this.lblman.TabIndex = 6;
            this.lblman.Text = "Manufacture";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(168, 15);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 22);
            this.txtname.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(242, 22);
            this.txtid.TabIndex = 11;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(27, 187);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblrantp
            // 
            this.lblrantp.AutoSize = true;
            this.lblrantp.Location = new System.Drawing.Point(64, 145);
            this.lblrantp.Name = "lblrantp";
            this.lblrantp.Size = new System.Drawing.Size(0, 17);
            this.lblrantp.TabIndex = 22;
            // 
            // txtManDate
            // 
            this.txtManDate.Location = new System.Drawing.Point(168, 106);
            this.txtManDate.Name = "txtManDate";
            this.txtManDate.Size = new System.Drawing.Size(242, 22);
            this.txtManDate.TabIndex = 23;
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.txtManDate);
            this.Controls.Add(this.lblrantp);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblman);
            this.Controls.Add(this.lblcarprice);
            this.Controls.Add(this.lblcarid);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmCar";
            this.Text = "FrmCar";
            this.Load += new System.EventHandler(this.FrmCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblcarid;
        private System.Windows.Forms.Label lblcarprice;
        private System.Windows.Forms.Label lblman;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblrantp;
        private System.Windows.Forms.TextBox txtManDate;
    }
}