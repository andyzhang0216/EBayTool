namespace EBayAPI
{
    partial class ApiGetOrderTransactions
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
            this.BtnGetOrderTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetOrderTransactions
            // 
            this.BtnGetOrderTransactions.Location = new System.Drawing.Point(57, 215);
            this.BtnGetOrderTransactions.Name = "BtnGetOrderTransactions";
            this.BtnGetOrderTransactions.Size = new System.Drawing.Size(163, 23);
            this.BtnGetOrderTransactions.TabIndex = 0;
            this.BtnGetOrderTransactions.Text = "GetOrderTransactions";
            this.BtnGetOrderTransactions.UseVisualStyleBackColor = true;
            this.BtnGetOrderTransactions.Click += new System.EventHandler(this.BtnGetOrderTransactions_Click);
            // 
            // ApiGetOrderTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnGetOrderTransactions);
            this.Name = "ApiGetOrderTransactions";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetOrderTransactions;
    }
}