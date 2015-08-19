namespace EBayAPI
{
    partial class ApiGetOrders
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
            this.ChkStartTo = new System.Windows.Forms.CheckBox();
            this.ChkStartFrom = new System.Windows.Forms.CheckBox();
            this.LblTimeRange = new System.Windows.Forms.Label();
            this.CboRole = new System.Windows.Forms.ComboBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.DatePickStartTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickStartFrom = new System.Windows.Forms.DateTimePicker();
            this.LblStartSep = new System.Windows.Forms.Label();
            this.ClmItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblOrders = new System.Windows.Forms.Label();
            this.LstOrders = new System.Windows.Forms.ListView();
            this.ClmSaved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.BtnGetOrders = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkStartTo
            // 
            this.ChkStartTo.Location = new System.Drawing.Point(280, 58);
            this.ChkStartTo.Name = "ChkStartTo";
            this.ChkStartTo.Size = new System.Drawing.Size(12, 24);
            this.ChkStartTo.TabIndex = 105;
            // 
            // ChkStartFrom
            // 
            this.ChkStartFrom.Location = new System.Drawing.Point(96, 58);
            this.ChkStartFrom.Name = "ChkStartFrom";
            this.ChkStartFrom.Size = new System.Drawing.Size(12, 24);
            this.ChkStartFrom.TabIndex = 104;
            // 
            // LblTimeRange
            // 
            this.LblTimeRange.Location = new System.Drawing.Point(16, 58);
            this.LblTimeRange.Name = "LblTimeRange";
            this.LblTimeRange.Size = new System.Drawing.Size(72, 16);
            this.LblTimeRange.TabIndex = 103;
            this.LblTimeRange.Text = "Time Filter:";
            // 
            // CboRole
            // 
            this.CboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRole.Location = new System.Drawing.Point(96, 34);
            this.CboRole.Name = "CboRole";
            this.CboRole.Size = new System.Drawing.Size(144, 21);
            this.CboRole.TabIndex = 102;
            // 
            // LblRole
            // 
            this.LblRole.Location = new System.Drawing.Point(16, 34);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(80, 18);
            this.LblRole.TabIndex = 101;
            this.LblRole.Text = "Role:";
            // 
            // CboStatus
            // 
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.Location = new System.Drawing.Point(96, 10);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(144, 21);
            this.CboStatus.TabIndex = 100;
            // 
            // DatePickStartTo
            // 
            this.DatePickStartTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickStartTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickStartTo.Location = new System.Drawing.Point(296, 58);
            this.DatePickStartTo.Name = "DatePickStartTo";
            this.DatePickStartTo.Size = new System.Drawing.Size(136, 20);
            this.DatePickStartTo.TabIndex = 98;
            // 
            // DatePickStartFrom
            // 
            this.DatePickStartFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickStartFrom.Location = new System.Drawing.Point(112, 58);
            this.DatePickStartFrom.Name = "DatePickStartFrom";
            this.DatePickStartFrom.Size = new System.Drawing.Size(136, 20);
            this.DatePickStartFrom.TabIndex = 97;
            // 
            // LblStartSep
            // 
            this.LblStartSep.Location = new System.Drawing.Point(256, 58);
            this.LblStartSep.Name = "LblStartSep";
            this.LblStartSep.Size = new System.Drawing.Size(16, 23);
            this.LblStartSep.TabIndex = 96;
            this.LblStartSep.Text = " - ";
            // 
            // ClmItems
            // 
            this.ClmItems.Text = "Items";
            this.ClmItems.Width = 162;
            // 
            // ClmCreator
            // 
            this.ClmCreator.Text = "Creator";
            this.ClmCreator.Width = 84;
            // 
            // ClmStatus
            // 
            this.ClmStatus.Text = "Status";
            this.ClmStatus.Width = 75;
            // 
            // ClmOrderId
            // 
            this.ClmOrderId.Text = "Order Id";
            this.ClmOrderId.Width = 95;
            // 
            // LblOrders
            // 
            this.LblOrders.Location = new System.Drawing.Point(8, 24);
            this.LblOrders.Name = "LblOrders";
            this.LblOrders.Size = new System.Drawing.Size(112, 23);
            this.LblOrders.TabIndex = 12;
            this.LblOrders.Text = "Orders:";
            // 
            // LstOrders
            // 
            this.LstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmOrderId,
            this.ClmStatus,
            this.ClmCreator,
            this.ClmSaved,
            this.ClmItems});
            this.LstOrders.GridLines = true;
            this.LstOrders.Location = new System.Drawing.Point(8, 56);
            this.LstOrders.Name = "LstOrders";
            this.LstOrders.Size = new System.Drawing.Size(520, 168);
            this.LstOrders.TabIndex = 13;
            this.LstOrders.UseCompatibleStateImageBehavior = false;
            this.LstOrders.View = System.Windows.Forms.View.Details;
            // 
            // ClmSaved
            // 
            this.ClmSaved.Text = "Amount Saved";
            this.ClmSaved.Width = 91;
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.LblOrders);
            this.GrpResult.Controls.Add(this.LstOrders);
            this.GrpResult.Location = new System.Drawing.Point(8, 122);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(544, 232);
            this.GrpResult.TabIndex = 95;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(192, 90);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(128, 23);
            this.BtnGetOrders.TabIndex = 94;
            this.BtnGetOrders.Text = "GetOrders";
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetOrders_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(16, 10);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(80, 18);
            this.LblStatus.TabIndex = 99;
            this.LblStatus.Text = "Status:";
            // 
            // ApiGetOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 365);
            this.Controls.Add(this.ChkStartTo);
            this.Controls.Add(this.ChkStartFrom);
            this.Controls.Add(this.LblTimeRange);
            this.Controls.Add(this.CboRole);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.CboStatus);
            this.Controls.Add(this.DatePickStartTo);
            this.Controls.Add(this.DatePickStartFrom);
            this.Controls.Add(this.LblStartSep);
            this.Controls.Add(this.GrpResult);
            this.Controls.Add(this.BtnGetOrders);
            this.Controls.Add(this.LblStatus);
            this.Name = "ApiGetOrders";
            this.Text = "Get Orders";
            this.Load += new System.EventHandler(this.ApiGetOrders_Load);
            this.GrpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkStartTo;
        private System.Windows.Forms.CheckBox ChkStartFrom;
        private System.Windows.Forms.Label LblTimeRange;
        private System.Windows.Forms.ComboBox CboRole;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.DateTimePicker DatePickStartTo;
        private System.Windows.Forms.DateTimePicker DatePickStartFrom;
        private System.Windows.Forms.Label LblStartSep;
        private System.Windows.Forms.ColumnHeader ClmItems;
        private System.Windows.Forms.ColumnHeader ClmCreator;
        private System.Windows.Forms.ColumnHeader ClmStatus;
        private System.Windows.Forms.ColumnHeader ClmOrderId;
        private System.Windows.Forms.Label LblOrders;
        private System.Windows.Forms.ListView LstOrders;
        private System.Windows.Forms.ColumnHeader ClmSaved;
        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.Label LblStatus;
    }
}