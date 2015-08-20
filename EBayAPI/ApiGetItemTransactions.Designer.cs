namespace EBayAPI
{
    partial class ApiGetItemTransactions
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
            this.BtnSendInvoice = new System.Windows.Forms.Button();
            this.LblModified = new System.Windows.Forms.Label();
            this.LblItemId = new System.Windows.Forms.Label();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.DatePickModTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickModFrom = new System.Windows.Forms.DateTimePicker();
            this.LblModSep = new System.Windows.Forms.Label();
            this.BtnGetItemTransactions = new System.Windows.Forms.Button();
            this.ClmBestOfferSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmTransId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblTransactions = new System.Windows.Forms.Label();
            this.LstTransactions = new System.Windows.Forms.ListView();
            this.ClmUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSendInvoice
            // 
            this.BtnSendInvoice.Location = new System.Drawing.Point(324, 78);
            this.BtnSendInvoice.Name = "BtnSendInvoice";
            this.BtnSendInvoice.Size = new System.Drawing.Size(128, 23);
            this.BtnSendInvoice.TabIndex = 83;
            this.BtnSendInvoice.Text = "Send invoice ...";
            this.BtnSendInvoice.Click += new System.EventHandler(this.BtnSendInvoice_Click);
            // 
            // LblModified
            // 
            this.LblModified.Location = new System.Drawing.Point(12, 46);
            this.LblModified.Name = "LblModified";
            this.LblModified.Size = new System.Drawing.Size(104, 16);
            this.LblModified.TabIndex = 82;
            this.LblModified.Text = "Modified Between:";
            // 
            // LblItemId
            // 
            this.LblItemId.Location = new System.Drawing.Point(60, 14);
            this.LblItemId.Name = "LblItemId";
            this.LblItemId.Size = new System.Drawing.Size(56, 16);
            this.LblItemId.TabIndex = 81;
            this.LblItemId.Text = "Item Id:";
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(116, 14);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Size = new System.Drawing.Size(100, 20);
            this.TxtItemId.TabIndex = 80;
            // 
            // DatePickModTo
            // 
            this.DatePickModTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickModTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickModTo.Location = new System.Drawing.Point(284, 46);
            this.DatePickModTo.Name = "DatePickModTo";
            this.DatePickModTo.Size = new System.Drawing.Size(152, 20);
            this.DatePickModTo.TabIndex = 79;
            // 
            // DatePickModFrom
            // 
            this.DatePickModFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickModFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickModFrom.Location = new System.Drawing.Point(116, 46);
            this.DatePickModFrom.Name = "DatePickModFrom";
            this.DatePickModFrom.Size = new System.Drawing.Size(152, 20);
            this.DatePickModFrom.TabIndex = 78;
            // 
            // LblModSep
            // 
            this.LblModSep.Location = new System.Drawing.Point(268, 46);
            this.LblModSep.Name = "LblModSep";
            this.LblModSep.Size = new System.Drawing.Size(16, 23);
            this.LblModSep.TabIndex = 77;
            this.LblModSep.Text = " - ";
            // 
            // BtnGetItemTransactions
            // 
            this.BtnGetItemTransactions.Location = new System.Drawing.Point(156, 78);
            this.BtnGetItemTransactions.Name = "BtnGetItemTransactions";
            this.BtnGetItemTransactions.Size = new System.Drawing.Size(128, 23);
            this.BtnGetItemTransactions.TabIndex = 75;
            this.BtnGetItemTransactions.Text = "GetItemTransactions";
            this.BtnGetItemTransactions.Click += new System.EventHandler(this.BtnGetItemTransactions_Click);
            // 
            // ClmBestOfferSale
            // 
            this.ClmBestOfferSale.Text = "BestOfferSale";
            this.ClmBestOfferSale.Width = 80;
            // 
            // ClmQuantity
            // 
            this.ClmQuantity.Text = "Quantity";
            this.ClmQuantity.Width = 80;
            // 
            // ClmAmount
            // 
            this.ClmAmount.Text = "Amount";
            this.ClmAmount.Width = 66;
            // 
            // ClmPrice
            // 
            this.ClmPrice.Text = "Price";
            // 
            // ClmTransId
            // 
            this.ClmTransId.Text = "Transaction Id";
            this.ClmTransId.Width = 100;
            // 
            // LblTransactions
            // 
            this.LblTransactions.Location = new System.Drawing.Point(24, 24);
            this.LblTransactions.Name = "LblTransactions";
            this.LblTransactions.Size = new System.Drawing.Size(112, 23);
            this.LblTransactions.TabIndex = 15;
            this.LblTransactions.Text = "Item Transactions:";
            // 
            // LstTransactions
            // 
            this.LstTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmTransId,
            this.ClmPrice,
            this.ClmAmount,
            this.ClmQuantity,
            this.ClmUser,
            this.ClmBestOfferSale});
            this.LstTransactions.GridLines = true;
            this.LstTransactions.Location = new System.Drawing.Point(24, 48);
            this.LstTransactions.Name = "LstTransactions";
            this.LstTransactions.Size = new System.Drawing.Size(472, 256);
            this.LstTransactions.TabIndex = 4;
            this.LstTransactions.UseCompatibleStateImageBehavior = false;
            this.LstTransactions.View = System.Windows.Forms.View.Details;
            // 
            // ClmUser
            // 
            this.ClmUser.Text = "User Id";
            this.ClmUser.Width = 80;
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.LblTransactions);
            this.GrpResult.Controls.Add(this.LstTransactions);
            this.GrpResult.Location = new System.Drawing.Point(12, 118);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(520, 320);
            this.GrpResult.TabIndex = 76;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Results";
            // 
            // ApiGetItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 453);
            this.Controls.Add(this.BtnSendInvoice);
            this.Controls.Add(this.LblModified);
            this.Controls.Add(this.LblItemId);
            this.Controls.Add(this.TxtItemId);
            this.Controls.Add(this.DatePickModTo);
            this.Controls.Add(this.DatePickModFrom);
            this.Controls.Add(this.LblModSep);
            this.Controls.Add(this.BtnGetItemTransactions);
            this.Controls.Add(this.GrpResult);
            this.Name = "ApiGetItemTransactions";
            this.Text = "Get Item Transactions";
            this.Load += new System.EventHandler(this.ApiGetItemTransactions_Load);
            this.GrpResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendInvoice;
        private System.Windows.Forms.Label LblModified;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.DateTimePicker DatePickModTo;
        private System.Windows.Forms.DateTimePicker DatePickModFrom;
        private System.Windows.Forms.Label LblModSep;
        private System.Windows.Forms.Button BtnGetItemTransactions;
        private System.Windows.Forms.ColumnHeader ClmBestOfferSale;
        private System.Windows.Forms.ColumnHeader ClmQuantity;
        private System.Windows.Forms.ColumnHeader ClmAmount;
        private System.Windows.Forms.ColumnHeader ClmPrice;
        private System.Windows.Forms.ColumnHeader ClmTransId;
        private System.Windows.Forms.Label LblTransactions;
        private System.Windows.Forms.ListView LstTransactions;
        private System.Windows.Forms.ColumnHeader ClmUser;
        private System.Windows.Forms.GroupBox GrpResult;
    }
}