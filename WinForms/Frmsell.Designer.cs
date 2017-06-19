namespace WinForms
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Price";
            // 
            // txtSprice
            // 
            this.txtSprice.Location = new System.Drawing.Point(168, 152);
            this.txtSprice.Name = "txtSprice";
            this.txtSprice.Size = new System.Drawing.Size(232, 22);
            this.txtSprice.TabIndex = 9;
            // 
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 249);
            this.Controls.Add(this.txtSprice);
            this.Controls.Add(this.label4);
            this.Name = "FrmSell";
            this.Text = "FrmSell";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSprice, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSprice;
    }
}