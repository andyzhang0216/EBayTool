namespace EBayAPI
{
    partial class ApiEndItem
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
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.BtnEndItem = new System.Windows.Forms.Button();
            this.CboReason = new System.Windows.Forms.ComboBox();
            this.LblReason = new System.Windows.Forms.Label();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.LblItemId = new System.Windows.Forms.Label();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.LblStatus);
            this.GrpResult.Controls.Add(this.TxtStatus);
            this.GrpResult.Location = new System.Drawing.Point(8, 94);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(352, 64);
            this.GrpResult.TabIndex = 57;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(16, 24);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(80, 23);
            this.LblStatus.TabIndex = 42;
            this.LblStatus.Text = "Status:";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(96, 24);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.ReadOnly = true;
            this.TxtStatus.Size = new System.Drawing.Size(72, 20);
            this.TxtStatus.TabIndex = 41;
            // 
            // BtnEndItem
            // 
            this.BtnEndItem.Location = new System.Drawing.Point(128, 62);
            this.BtnEndItem.Name = "BtnEndItem";
            this.BtnEndItem.Size = new System.Drawing.Size(120, 23);
            this.BtnEndItem.TabIndex = 56;
            this.BtnEndItem.Text = "EndItem";
            // 
            // CboReason
            // 
            this.CboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboReason.Location = new System.Drawing.Point(152, 30);
            this.CboReason.Name = "CboReason";
            this.CboReason.Size = new System.Drawing.Size(144, 21);
            this.CboReason.TabIndex = 61;
            // 
            // LblReason
            // 
            this.LblReason.Location = new System.Drawing.Point(72, 30);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(80, 18);
            this.LblReason.TabIndex = 60;
            this.LblReason.Text = "Reason:";
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(152, 6);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Size = new System.Drawing.Size(80, 20);
            this.TxtItemId.TabIndex = 58;
            // 
            // LblItemId
            // 
            this.LblItemId.Location = new System.Drawing.Point(72, 6);
            this.LblItemId.Name = "LblItemId";
            this.LblItemId.Size = new System.Drawing.Size(80, 23);
            this.LblItemId.TabIndex = 59;
            this.LblItemId.Text = "Item Id:";
            // 
            // ApiEndItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.GrpResult);
            this.Controls.Add(this.BtnEndItem);
            this.Controls.Add(this.CboReason);
            this.Controls.Add(this.LblReason);
            this.Controls.Add(this.TxtItemId);
            this.Controls.Add(this.LblItemId);
            this.Name = "ApiEndItem";
            this.Text = "EndItem";
            this.GrpResult.ResumeLayout(false);
            this.GrpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Button BtnEndItem;
        private System.Windows.Forms.ComboBox CboReason;
        private System.Windows.Forms.Label LblReason;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.Label LblItemId;
    }
}