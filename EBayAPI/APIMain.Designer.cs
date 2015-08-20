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
            this.APICallListBox = new System.Windows.Forms.ListBox();
            this.runbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAccountSettings
            // 
            this.BtnAccountSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAccountSettings.Location = new System.Drawing.Point(113, 28);
            this.BtnAccountSettings.Name = "BtnAccountSettings";
            this.BtnAccountSettings.Size = new System.Drawing.Size(192, 24);
            this.BtnAccountSettings.TabIndex = 1;
            this.BtnAccountSettings.Text = "Config API Account";
            this.BtnAccountSettings.Click += new System.EventHandler(this.BtnAccountSettings_Click);
            // 
            // APICallListBox
            // 
            this.APICallListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APICallListBox.Location = new System.Drawing.Point(42, 69);
            this.APICallListBox.Name = "APICallListBox";
            this.APICallListBox.Size = new System.Drawing.Size(336, 186);
            this.APICallListBox.Sorted = true;
            this.APICallListBox.TabIndex = 2;
            this.APICallListBox.DoubleClick += new System.EventHandler(this.APICallListBox_DoubleClick);
            this.APICallListBox.SelectedIndexChanged += new System.EventHandler(this.APICallListBox_SelectedIndexChanged);
            // 
            // runbutton
            // 
            this.runbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.runbutton.Location = new System.Drawing.Point(113, 273);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(192, 24);
            this.runbutton.TabIndex = 3;
            this.runbutton.Text = "Run an eBay API call";
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // APIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 309);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.APICallListBox);
            this.Controls.Add(this.BtnAccountSettings);
            this.Name = "APIMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.APIMain_Load);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button BtnAccountSettings;
        private System.Windows.Forms.ListBox APICallListBox;
        private System.Windows.Forms.Button runbutton;
    }
}

