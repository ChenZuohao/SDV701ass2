namespace WinForms
{
    partial class FrmOrder
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CarID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 575);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(843, 570);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 50);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Quit";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarID,
            this.CustomerName,
            this.CustomerPhone,
            this.OrderDate,
            this.Type,
            this.Price});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(72, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1088, 456);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CarID
            // 
            this.CarID.Text = "CarID";
            this.CarID.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "CustomerName";
            this.CustomerName.Width = 80;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Text = "CustomerPhone";
            this.CustomerPhone.Width = 100;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "OrderDate";
            this.OrderDate.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 651);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrder";
            this.Text = "Carlist";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader CarID;
        private System.Windows.Forms.ColumnHeader CustomerPhone;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Price;
    }
}