using System;

namespace EBayAPI
{
    partial class ApiMain
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
            this.BtnAccountSettings = new System.Windows.Forms.Button();
            this.runbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAccountSettings
            // 
            this.BtnAccountSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAccountSettings.Location = new System.Drawing.Point(28, 24);
            this.BtnAccountSettings.Name = "BtnAccountSettings";
            this.BtnAccountSettings.Size = new System.Drawing.Size(192, 24);
            this.BtnAccountSettings.TabIndex = 1;
            this.BtnAccountSettings.Text = "Config API Account";
            this.BtnAccountSettings.Click += new System.EventHandler(this.BtnAccountSettings_Click);
            // 
            // runbutton
            // 
            this.runbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.runbutton.Location = new System.Drawing.Point(28, 62);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(192, 24);
            this.runbutton.TabIndex = 3;
            this.runbutton.Text = "GetOrders";
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // ApiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 98);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.BtnAccountSettings);
            this.Name = "ApiMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.APIMain_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button BtnAccountSettings;
        private System.Windows.Forms.Button runbutton;
    }
}

