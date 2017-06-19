namespace WinForms
{
    partial class FrmInputBox
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
            this.textCarSelect = new System.Windows.Forms.TextBox();
            this.btnInBack = new System.Windows.Forms.Button();
            this.btnInOK = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCarSelect
            // 
            this.textCarSelect.Location = new System.Drawing.Point(30, 85);
            this.textCarSelect.Name = "textCarSelect";
            this.textCarSelect.Size = new System.Drawing.Size(634, 22);
            this.textCarSelect.TabIndex = 1;
            // 
            // btnInBack
            // 
            this.btnInBack.Location = new System.Drawing.Point(447, 129);
            this.btnInBack.Name = "btnInBack";
            this.btnInBack.Size = new System.Drawing.Size(83, 29);
            this.btnInBack.TabIndex = 2;
            this.btnInBack.Text = "Cancel";
            this.btnInBack.UseVisualStyleBackColor = true;
            this.btnInBack.Click += new System.EventHandler(this.btnInBack_Click);
            // 
            // btnInOK
            // 
            this.btnInOK.Location = new System.Drawing.Point(581, 129);
            this.btnInOK.Name = "btnInOK";
            this.btnInOK.Size = new System.Drawing.Size(83, 29);
            this.btnInOK.TabIndex = 3;
            this.btnInOK.Text = "OK";
            this.btnInOK.UseVisualStyleBackColor = true;
            this.btnInOK.Click += new System.EventHandler(this.btnInOK_Click_1);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(30, 177);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(108, 17);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter S for Sell, R for Rent";
            // 
            // FrmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnInOK);
            this.Controls.Add(this.btnInBack);
            this.Controls.Add(this.textCarSelect);
            this.Name = "FrmInputBox";
            this.Text = "FrmInputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textCarSelect;
        private System.Windows.Forms.Button btnInBack;
        private System.Windows.Forms.Button btnInOK;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}