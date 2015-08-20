namespace EBayAPI
{
    partial class ApiGetItemShipping
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
            this.CboCountry = new System.Windows.Forms.ComboBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblCountryCode = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.TxtDestination = new System.Windows.Forms.TextBox();
            this.TxtShipZip = new System.Windows.Forms.TextBox();
            this.LblShipZip = new System.Windows.Forms.Label();
            this.LblHandlingCost = new System.Windows.Forms.Label();
            this.TxtHandlingCost = new System.Windows.Forms.TextBox();
            this.TxtShipType = new System.Windows.Forms.TextBox();
            this.LblShipType = new System.Windows.Forms.Label();
            this.ClmShipLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmAddedCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmInsurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.LblPackage = new System.Windows.Forms.Label();
            this.TxtPackage = new System.Windows.Forms.TextBox();
            this.LstShipSvc = new System.Windows.Forms.ListView();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.LblItemId = new System.Windows.Forms.Label();
            this.BtnGetItemShipping = new System.Windows.Forms.Button();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboCountry
            // 
            this.CboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCountry.Location = new System.Drawing.Point(344, 10);
            this.CboCountry.Name = "CboCountry";
            this.CboCountry.Size = new System.Drawing.Size(128, 21);
            this.CboCountry.TabIndex = 66;
            // 
            // LblQuantity
            // 
            this.LblQuantity.Location = new System.Drawing.Point(248, 34);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(96, 16);
            this.LblQuantity.TabIndex = 65;
            this.LblQuantity.Text = "Quantity:";
            // 
            // LblCountryCode
            // 
            this.LblCountryCode.Location = new System.Drawing.Point(248, 10);
            this.LblCountryCode.Name = "LblCountryCode";
            this.LblCountryCode.Size = new System.Drawing.Size(96, 16);
            this.LblCountryCode.TabIndex = 63;
            this.LblCountryCode.Text = "Country Code:";
            // 
            // LblDestination
            // 
            this.LblDestination.Location = new System.Drawing.Point(16, 34);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(88, 16);
            this.LblDestination.TabIndex = 62;
            this.LblDestination.Text = "Destination Zip:";
            // 
            // TxtDestination
            // 
            this.TxtDestination.Location = new System.Drawing.Point(104, 34);
            this.TxtDestination.Name = "TxtDestination";
            this.TxtDestination.Size = new System.Drawing.Size(128, 20);
            this.TxtDestination.TabIndex = 61;
            // 
            // TxtShipZip
            // 
            this.TxtShipZip.Location = new System.Drawing.Point(128, 48);
            this.TxtShipZip.Name = "TxtShipZip";
            this.TxtShipZip.ReadOnly = true;
            this.TxtShipZip.Size = new System.Drawing.Size(120, 20);
            this.TxtShipZip.TabIndex = 73;
            // 
            // LblShipZip
            // 
            this.LblShipZip.Location = new System.Drawing.Point(8, 48);
            this.LblShipZip.Name = "LblShipZip";
            this.LblShipZip.Size = new System.Drawing.Size(120, 23);
            this.LblShipZip.TabIndex = 60;
            this.LblShipZip.Text = "Ship From Zip:";
            // 
            // LblHandlingCost
            // 
            this.LblHandlingCost.Location = new System.Drawing.Point(8, 72);
            this.LblHandlingCost.Name = "LblHandlingCost";
            this.LblHandlingCost.Size = new System.Drawing.Size(120, 23);
            this.LblHandlingCost.TabIndex = 62;
            this.LblHandlingCost.Text = "Handling Cost:";
            // 
            // TxtHandlingCost
            // 
            this.TxtHandlingCost.Location = new System.Drawing.Point(128, 72);
            this.TxtHandlingCost.Name = "TxtHandlingCost";
            this.TxtHandlingCost.ReadOnly = true;
            this.TxtHandlingCost.Size = new System.Drawing.Size(120, 20);
            this.TxtHandlingCost.TabIndex = 69;
            // 
            // TxtShipType
            // 
            this.TxtShipType.Location = new System.Drawing.Point(128, 24);
            this.TxtShipType.Name = "TxtShipType";
            this.TxtShipType.ReadOnly = true;
            this.TxtShipType.Size = new System.Drawing.Size(120, 20);
            this.TxtShipType.TabIndex = 70;
            // 
            // LblShipType
            // 
            this.LblShipType.Location = new System.Drawing.Point(8, 24);
            this.LblShipType.Name = "LblShipType";
            this.LblShipType.Size = new System.Drawing.Size(120, 23);
            this.LblShipType.TabIndex = 54;
            this.LblShipType.Text = "Ship Type:";
            // 
            // ClmShipLocation
            // 
            this.ClmShipLocation.Text = "Locations";
            this.ClmShipLocation.Width = 79;
            // 
            // ClmAddedCost
            // 
            this.ClmAddedCost.Text = "Additional Cost";
            this.ClmAddedCost.Width = 83;
            // 
            // ClmInsurance
            // 
            this.ClmInsurance.Text = "Insurance";
            this.ClmInsurance.Width = 63;
            // 
            // ClmCost
            // 
            this.ClmCost.Text = "Cost";
            this.ClmCost.Width = 61;
            // 
            // ClmService
            // 
            this.ClmService.Text = "Service";
            this.ClmService.Width = 129;
            // 
            // LblWeight
            // 
            this.LblWeight.Location = new System.Drawing.Point(8, 120);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(120, 23);
            this.LblWeight.TabIndex = 79;
            this.LblWeight.Text = "Weight:";
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(128, 120);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.ReadOnly = true;
            this.TxtWeight.Size = new System.Drawing.Size(120, 20);
            this.TxtWeight.TabIndex = 80;
            // 
            // LblPackage
            // 
            this.LblPackage.Location = new System.Drawing.Point(8, 96);
            this.LblPackage.Name = "LblPackage";
            this.LblPackage.Size = new System.Drawing.Size(120, 23);
            this.LblPackage.TabIndex = 77;
            this.LblPackage.Text = "Package:";
            // 
            // TxtPackage
            // 
            this.TxtPackage.Location = new System.Drawing.Point(128, 96);
            this.TxtPackage.Name = "TxtPackage";
            this.TxtPackage.ReadOnly = true;
            this.TxtPackage.Size = new System.Drawing.Size(120, 20);
            this.TxtPackage.TabIndex = 78;
            // 
            // LstShipSvc
            // 
            this.LstShipSvc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmService,
            this.ClmCost,
            this.ClmInsurance,
            this.ClmAddedCost,
            this.ClmShipLocation});
            this.LstShipSvc.GridLines = true;
            this.LstShipSvc.Location = new System.Drawing.Point(8, 168);
            this.LstShipSvc.Name = "LstShipSvc";
            this.LstShipSvc.Size = new System.Drawing.Size(424, 80);
            this.LstShipSvc.TabIndex = 76;
            this.LstShipSvc.UseCompatibleStateImageBehavior = false;
            this.LstShipSvc.View = System.Windows.Forms.View.Details;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(344, 34);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(128, 20);
            this.TxtQuantity.TabIndex = 64;
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(104, 10);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Size = new System.Drawing.Size(128, 20);
            this.TxtItemId.TabIndex = 57;
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.LblWeight);
            this.GrpResult.Controls.Add(this.TxtWeight);
            this.GrpResult.Controls.Add(this.LblPackage);
            this.GrpResult.Controls.Add(this.TxtPackage);
            this.GrpResult.Controls.Add(this.LstShipSvc);
            this.GrpResult.Controls.Add(this.TxtShipZip);
            this.GrpResult.Controls.Add(this.LblShipZip);
            this.GrpResult.Controls.Add(this.LblHandlingCost);
            this.GrpResult.Controls.Add(this.TxtHandlingCost);
            this.GrpResult.Controls.Add(this.TxtShipType);
            this.GrpResult.Controls.Add(this.LblShipType);
            this.GrpResult.Location = new System.Drawing.Point(8, 114);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(464, 264);
            this.GrpResult.TabIndex = 60;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            // 
            // LblItemId
            // 
            this.LblItemId.Location = new System.Drawing.Point(16, 10);
            this.LblItemId.Name = "LblItemId";
            this.LblItemId.Size = new System.Drawing.Size(88, 16);
            this.LblItemId.TabIndex = 59;
            this.LblItemId.Text = "Item Id:";
            // 
            // BtnGetItemShipping
            // 
            this.BtnGetItemShipping.Location = new System.Drawing.Point(192, 82);
            this.BtnGetItemShipping.Name = "BtnGetItemShipping";
            this.BtnGetItemShipping.Size = new System.Drawing.Size(104, 23);
            this.BtnGetItemShipping.TabIndex = 58;
            this.BtnGetItemShipping.Text = "GetItemShipping";
            this.BtnGetItemShipping.Click += new System.EventHandler(this.BtnGetItemShipping_Click);
            // 
            // ApiGetItemShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.CboCountry);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblCountryCode);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.TxtDestination);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtItemId);
            this.Controls.Add(this.GrpResult);
            this.Controls.Add(this.LblItemId);
            this.Controls.Add(this.BtnGetItemShipping);
            this.Name = "ApiGetItemShipping";
            this.Text = "Get Item Shipping";
            this.Load += new System.EventHandler(this.ApiGetItemShipping_Load);
            this.GrpResult.ResumeLayout(false);
            this.GrpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCountry;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblCountryCode;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.TextBox TxtDestination;
        private System.Windows.Forms.TextBox TxtShipZip;
        internal System.Windows.Forms.Label LblShipZip;
        internal System.Windows.Forms.Label LblHandlingCost;
        private System.Windows.Forms.TextBox TxtHandlingCost;
        private System.Windows.Forms.TextBox TxtShipType;
        internal System.Windows.Forms.Label LblShipType;
        private System.Windows.Forms.ColumnHeader ClmShipLocation;
        private System.Windows.Forms.ColumnHeader ClmAddedCost;
        private System.Windows.Forms.ColumnHeader ClmInsurance;
        private System.Windows.Forms.ColumnHeader ClmCost;
        private System.Windows.Forms.ColumnHeader ClmService;
        internal System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TxtWeight;
        internal System.Windows.Forms.Label LblPackage;
        private System.Windows.Forms.TextBox TxtPackage;
        private System.Windows.Forms.ListView LstShipSvc;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.Button BtnGetItemShipping;
    }
}