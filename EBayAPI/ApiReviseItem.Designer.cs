namespace EBayAPI
{
    partial class ApiReviseItem
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
            this.CboEnableBestOffer = new System.Windows.Forms.ComboBox();
            this.GrpDeleteTag = new System.Windows.Forms.GroupBox();
            this.ChkPayPalEmailAddress = new System.Windows.Forms.CheckBox();
            this.ChkApplicationData = new System.Windows.Forms.CheckBox();
            this.TxtReviseItemId = new System.Windows.Forms.TextBox();
            this.LblReviseItemId = new System.Windows.Forms.Label();
            this.LblChangeInstr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboPicDisplay = new System.Windows.Forms.ComboBox();
            this.BtnAddPic = new System.Windows.Forms.Button();
            this.BtnRemovePic = new System.Windows.Forms.Button();
            this.ListPictures = new System.Windows.Forms.ListBox();
            this.LblEnableBestOffer = new System.Windows.Forms.Label();
            this.CboDuration = new System.Windows.Forms.ComboBox();
            this.LblDuration = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtBuyItNowPrice = new System.Windows.Forms.TextBox();
            this.TxtReservePrice = new System.Windows.Forms.TextBox();
            this.OpenFileDialogIMG = new System.Windows.Forms.OpenFileDialog();
            this.TxtStartPrice = new System.Windows.Forms.TextBox();
            this.LblBuyItNowPrice = new System.Windows.Forms.Label();
            this.BtnReviseItem = new System.Windows.Forms.Button();
            this.BtnGetItem = new System.Windows.Forms.Button();
            this.LblItemId = new System.Windows.Forms.Label();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.TxtListingFee = new System.Windows.Forms.TextBox();
            this.LblListingFee = new System.Windows.Forms.Label();
            this.LblStartPrice = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.LblReservePrice = new System.Windows.Forms.Label();
            this.GrpDeleteTag.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboEnableBestOffer
            // 
            this.CboEnableBestOffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEnableBestOffer.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CboEnableBestOffer.Location = new System.Drawing.Point(116, 219);
            this.CboEnableBestOffer.Name = "CboEnableBestOffer";
            this.CboEnableBestOffer.Size = new System.Drawing.Size(80, 21);
            this.CboEnableBestOffer.TabIndex = 109;
            // 
            // GrpDeleteTag
            // 
            this.GrpDeleteTag.Controls.Add(this.ChkPayPalEmailAddress);
            this.GrpDeleteTag.Controls.Add(this.ChkApplicationData);
            this.GrpDeleteTag.Location = new System.Drawing.Point(12, 259);
            this.GrpDeleteTag.Name = "GrpDeleteTag";
            this.GrpDeleteTag.Size = new System.Drawing.Size(456, 88);
            this.GrpDeleteTag.TabIndex = 107;
            this.GrpDeleteTag.TabStop = false;
            this.GrpDeleteTag.Text = "Delete Selected Data";
            // 
            // ChkPayPalEmailAddress
            // 
            this.ChkPayPalEmailAddress.Location = new System.Drawing.Point(24, 56);
            this.ChkPayPalEmailAddress.Name = "ChkPayPalEmailAddress";
            this.ChkPayPalEmailAddress.Size = new System.Drawing.Size(160, 24);
            this.ChkPayPalEmailAddress.TabIndex = 76;
            this.ChkPayPalEmailAddress.Text = "PayPal Email Address";
            // 
            // ChkApplicationData
            // 
            this.ChkApplicationData.Location = new System.Drawing.Point(24, 24);
            this.ChkApplicationData.Name = "ChkApplicationData";
            this.ChkApplicationData.Size = new System.Drawing.Size(160, 24);
            this.ChkApplicationData.TabIndex = 73;
            this.ChkApplicationData.Text = "Application Data";
            // 
            // TxtReviseItemId
            // 
            this.TxtReviseItemId.Location = new System.Drawing.Point(244, 19);
            this.TxtReviseItemId.Name = "TxtReviseItemId";
            this.TxtReviseItemId.Size = new System.Drawing.Size(72, 20);
            this.TxtReviseItemId.TabIndex = 105;
            // 
            // LblReviseItemId
            // 
            this.LblReviseItemId.Location = new System.Drawing.Point(164, 19);
            this.LblReviseItemId.Name = "LblReviseItemId";
            this.LblReviseItemId.Size = new System.Drawing.Size(80, 18);
            this.LblReviseItemId.TabIndex = 106;
            this.LblReviseItemId.Text = "Revise Item Id:";
            // 
            // LblChangeInstr
            // 
            this.LblChangeInstr.Location = new System.Drawing.Point(132, 59);
            this.LblChangeInstr.Name = "LblChangeInstr";
            this.LblChangeInstr.Size = new System.Drawing.Size(280, 18);
            this.LblChangeInstr.TabIndex = 104;
            this.LblChangeInstr.Text = "Change all fields that you want to change for the Item:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboPicDisplay);
            this.groupBox1.Controls.Add(this.BtnAddPic);
            this.groupBox1.Controls.Add(this.BtnRemovePic);
            this.groupBox1.Controls.Add(this.ListPictures);
            this.groupBox1.Location = new System.Drawing.Point(12, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 128);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pictures that you want to host in eBay";
            // 
            // CboPicDisplay
            // 
            this.CboPicDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPicDisplay.ItemHeight = 13;
            this.CboPicDisplay.Location = new System.Drawing.Point(344, 96);
            this.CboPicDisplay.Name = "CboPicDisplay";
            this.CboPicDisplay.Size = new System.Drawing.Size(104, 21);
            this.CboPicDisplay.TabIndex = 57;
            // 
            // BtnAddPic
            // 
            this.BtnAddPic.Location = new System.Drawing.Point(352, 24);
            this.BtnAddPic.Name = "BtnAddPic";
            this.BtnAddPic.Size = new System.Drawing.Size(80, 23);
            this.BtnAddPic.TabIndex = 56;
            this.BtnAddPic.Text = "Add...";
            // 
            // BtnRemovePic
            // 
            this.BtnRemovePic.Location = new System.Drawing.Point(352, 56);
            this.BtnRemovePic.Name = "BtnRemovePic";
            this.BtnRemovePic.Size = new System.Drawing.Size(80, 23);
            this.BtnRemovePic.TabIndex = 55;
            this.BtnRemovePic.Text = "Remove";
            // 
            // ListPictures
            // 
            this.ListPictures.Location = new System.Drawing.Point(8, 32);
            this.ListPictures.Name = "ListPictures";
            this.ListPictures.Size = new System.Drawing.Size(328, 69);
            this.ListPictures.TabIndex = 1;
            // 
            // LblEnableBestOffer
            // 
            this.LblEnableBestOffer.Location = new System.Drawing.Point(12, 219);
            this.LblEnableBestOffer.Name = "LblEnableBestOffer";
            this.LblEnableBestOffer.Size = new System.Drawing.Size(104, 18);
            this.LblEnableBestOffer.TabIndex = 108;
            this.LblEnableBestOffer.Text = "Enable Best Offer:";
            // 
            // CboDuration
            // 
            this.CboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDuration.Location = new System.Drawing.Point(84, 107);
            this.CboDuration.Name = "CboDuration";
            this.CboDuration.Size = new System.Drawing.Size(80, 21);
            this.CboDuration.TabIndex = 103;
            // 
            // LblDuration
            // 
            this.LblDuration.Location = new System.Drawing.Point(12, 107);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(72, 18);
            this.LblDuration.TabIndex = 102;
            this.LblDuration.Text = "Duration:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(84, 83);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(392, 20);
            this.TxtTitle.TabIndex = 90;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(84, 155);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(392, 56);
            this.TxtDescription.TabIndex = 94;
            // 
            // TxtBuyItNowPrice
            // 
            this.TxtBuyItNowPrice.Location = new System.Drawing.Point(412, 131);
            this.TxtBuyItNowPrice.Name = "TxtBuyItNowPrice";
            this.TxtBuyItNowPrice.Size = new System.Drawing.Size(64, 20);
            this.TxtBuyItNowPrice.TabIndex = 93;
            // 
            // TxtReservePrice
            // 
            this.TxtReservePrice.Location = new System.Drawing.Point(260, 131);
            this.TxtReservePrice.Name = "TxtReservePrice";
            this.TxtReservePrice.Size = new System.Drawing.Size(64, 20);
            this.TxtReservePrice.TabIndex = 91;
            // 
            // OpenFileDialogIMG
            // 
            this.OpenFileDialogIMG.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All Files|*.*";
            // 
            // TxtStartPrice
            // 
            this.TxtStartPrice.Location = new System.Drawing.Point(84, 131);
            this.TxtStartPrice.Name = "TxtStartPrice";
            this.TxtStartPrice.Size = new System.Drawing.Size(72, 20);
            this.TxtStartPrice.TabIndex = 92;
            // 
            // LblBuyItNowPrice
            // 
            this.LblBuyItNowPrice.Location = new System.Drawing.Point(340, 131);
            this.LblBuyItNowPrice.Name = "LblBuyItNowPrice";
            this.LblBuyItNowPrice.Size = new System.Drawing.Size(64, 18);
            this.LblBuyItNowPrice.TabIndex = 99;
            this.LblBuyItNowPrice.Text = "BIN Price:";
            // 
            // BtnReviseItem
            // 
            this.BtnReviseItem.Location = new System.Drawing.Point(172, 507);
            this.BtnReviseItem.Name = "BtnReviseItem";
            this.BtnReviseItem.Size = new System.Drawing.Size(120, 26);
            this.BtnReviseItem.TabIndex = 95;
            this.BtnReviseItem.Text = "ReviseItem";
            // 
            // BtnGetItem
            // 
            this.BtnGetItem.Location = new System.Drawing.Point(200, 24);
            this.BtnGetItem.Name = "BtnGetItem";
            this.BtnGetItem.Size = new System.Drawing.Size(72, 26);
            this.BtnGetItem.TabIndex = 37;
            this.BtnGetItem.Text = "GetItem ...";
            this.BtnGetItem.Visible = false;
            // 
            // LblItemId
            // 
            this.LblItemId.Location = new System.Drawing.Point(8, 24);
            this.LblItemId.Name = "LblItemId";
            this.LblItemId.Size = new System.Drawing.Size(48, 23);
            this.LblItemId.TabIndex = 1;
            this.LblItemId.Text = "ItemId:";
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(64, 24);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(120, 20);
            this.TxtItemId.TabIndex = 0;
            // 
            // TxtListingFee
            // 
            this.TxtListingFee.Location = new System.Drawing.Point(376, 24);
            this.TxtListingFee.Name = "TxtListingFee";
            this.TxtListingFee.ReadOnly = true;
            this.TxtListingFee.Size = new System.Drawing.Size(72, 20);
            this.TxtListingFee.TabIndex = 0;
            // 
            // LblListingFee
            // 
            this.LblListingFee.Location = new System.Drawing.Point(328, 24);
            this.LblListingFee.Name = "LblListingFee";
            this.LblListingFee.Size = new System.Drawing.Size(48, 23);
            this.LblListingFee.TabIndex = 1;
            this.LblListingFee.Text = "Fees:";
            // 
            // LblStartPrice
            // 
            this.LblStartPrice.Location = new System.Drawing.Point(12, 131);
            this.LblStartPrice.Name = "LblStartPrice";
            this.LblStartPrice.Size = new System.Drawing.Size(72, 18);
            this.LblStartPrice.TabIndex = 98;
            this.LblStartPrice.Text = "Start Price:";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(12, 155);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(72, 18);
            this.LblDescription.TabIndex = 100;
            this.LblDescription.Text = "Description:";
            // 
            // LblTitle
            // 
            this.LblTitle.Location = new System.Drawing.Point(12, 83);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(72, 18);
            this.LblTitle.TabIndex = 96;
            this.LblTitle.Text = "Title:";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.BtnGetItem);
            this.grpResults.Controls.Add(this.LblItemId);
            this.grpResults.Controls.Add(this.TxtItemId);
            this.grpResults.Controls.Add(this.TxtListingFee);
            this.grpResults.Controls.Add(this.LblListingFee);
            this.grpResults.Location = new System.Drawing.Point(12, 555);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(464, 64);
            this.grpResults.TabIndex = 101;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // LblReservePrice
            // 
            this.LblReservePrice.Location = new System.Drawing.Point(172, 131);
            this.LblReservePrice.Name = "LblReservePrice";
            this.LblReservePrice.Size = new System.Drawing.Size(80, 18);
            this.LblReservePrice.TabIndex = 97;
            this.LblReservePrice.Text = "Reserve Price:";
            // 
            // ApiReviseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 638);
            this.Controls.Add(this.CboEnableBestOffer);
            this.Controls.Add(this.GrpDeleteTag);
            this.Controls.Add(this.TxtReviseItemId);
            this.Controls.Add(this.LblReviseItemId);
            this.Controls.Add(this.LblChangeInstr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEnableBestOffer);
            this.Controls.Add(this.CboDuration);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtBuyItNowPrice);
            this.Controls.Add(this.TxtReservePrice);
            this.Controls.Add(this.TxtStartPrice);
            this.Controls.Add(this.LblBuyItNowPrice);
            this.Controls.Add(this.BtnReviseItem);
            this.Controls.Add(this.LblStartPrice);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.LblReservePrice);
            this.Name = "ApiReviseItem";
            this.Text = "ReviseItem";
            this.GrpDeleteTag.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboEnableBestOffer;
        internal System.Windows.Forms.GroupBox GrpDeleteTag;
        internal System.Windows.Forms.CheckBox ChkPayPalEmailAddress;
        internal System.Windows.Forms.CheckBox ChkApplicationData;
        private System.Windows.Forms.TextBox TxtReviseItemId;
        private System.Windows.Forms.Label LblReviseItemId;
        private System.Windows.Forms.Label LblChangeInstr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboPicDisplay;
        private System.Windows.Forms.Button BtnAddPic;
        private System.Windows.Forms.Button BtnRemovePic;
        private System.Windows.Forms.ListBox ListPictures;
        private System.Windows.Forms.Label LblEnableBestOffer;
        private System.Windows.Forms.ComboBox CboDuration;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtBuyItNowPrice;
        private System.Windows.Forms.TextBox TxtReservePrice;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogIMG;
        private System.Windows.Forms.TextBox TxtStartPrice;
        private System.Windows.Forms.Label LblBuyItNowPrice;
        private System.Windows.Forms.Button BtnReviseItem;
        private System.Windows.Forms.Button BtnGetItem;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.TextBox TxtListingFee;
        private System.Windows.Forms.Label LblListingFee;
        private System.Windows.Forms.Label LblStartPrice;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label LblReservePrice;
    }
}