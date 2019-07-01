﻿namespace Sturdevant_s_Application
{
    partial class EoD
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
            this.components = new System.ComponentModel.Container();
            this.tip_Enter_Amounts = new System.Windows.Forms.ToolTip(this.components);
            this.btn_EoDPanel = new System.Windows.Forms.Button();
            this.btn_CppPanel = new System.Windows.Forms.Button();
            this.btn_KeystonePanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eKeystoneOrderSheetMain1 = new Sturdevant_s_Application.eKeystoneOrderSheetMain();
            this.cppOrderSheetMain1 = new Sturdevant_s_Application.CPPOrderSheetMain();
            this.eoDCalculator1 = new Sturdevant_s_Application.EoDCalculator();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EoDPanel
            // 
            this.btn_EoDPanel.Location = new System.Drawing.Point(18, 8);
            this.btn_EoDPanel.Name = "btn_EoDPanel";
            this.btn_EoDPanel.Size = new System.Drawing.Size(235, 45);
            this.btn_EoDPanel.TabIndex = 1;
            this.btn_EoDPanel.Text = "EoD Calculator";
            this.btn_EoDPanel.UseVisualStyleBackColor = true;
            this.btn_EoDPanel.Click += new System.EventHandler(this.Btn_EoDPanel_Click);
            // 
            // btn_CppPanel
            // 
            this.btn_CppPanel.Location = new System.Drawing.Point(259, 8);
            this.btn_CppPanel.Name = "btn_CppPanel";
            this.btn_CppPanel.Size = new System.Drawing.Size(235, 45);
            this.btn_CppPanel.TabIndex = 2;
            this.btn_CppPanel.Text = "CPP Order Sheel";
            this.btn_CppPanel.UseVisualStyleBackColor = true;
            this.btn_CppPanel.Click += new System.EventHandler(this.Btn_CppPanel_Click);
            // 
            // btn_KeystonePanel
            // 
            this.btn_KeystonePanel.Location = new System.Drawing.Point(500, 8);
            this.btn_KeystonePanel.Name = "btn_KeystonePanel";
            this.btn_KeystonePanel.Size = new System.Drawing.Size(235, 45);
            this.btn_KeystonePanel.TabIndex = 3;
            this.btn_KeystonePanel.Text = "E-Keystone Order Sheet";
            this.btn_KeystonePanel.UseVisualStyleBackColor = true;
            this.btn_KeystonePanel.Click += new System.EventHandler(this.Btn_KeystonePanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eKeystoneOrderSheetMain1);
            this.panel1.Controls.Add(this.cppOrderSheetMain1);
            this.panel1.Controls.Add(this.eoDCalculator1);
            this.panel1.Location = new System.Drawing.Point(-1, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 621);
            this.panel1.TabIndex = 43;
            // 
            // eKeystoneOrderSheetMain1
            // 
            this.eKeystoneOrderSheetMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eKeystoneOrderSheetMain1.Location = new System.Drawing.Point(0, 0);
            this.eKeystoneOrderSheetMain1.Name = "eKeystoneOrderSheetMain1";
            this.eKeystoneOrderSheetMain1.Size = new System.Drawing.Size(1186, 621);
            this.eKeystoneOrderSheetMain1.TabIndex = 2;
            // 
            // cppOrderSheetMain1
            // 
            this.cppOrderSheetMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cppOrderSheetMain1.Location = new System.Drawing.Point(0, 0);
            this.cppOrderSheetMain1.Name = "cppOrderSheetMain1";
            this.cppOrderSheetMain1.Size = new System.Drawing.Size(1186, 621);
            this.cppOrderSheetMain1.TabIndex = 1;
            // 
            // eoDCalculator1
            // 
            this.eoDCalculator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eoDCalculator1.Location = new System.Drawing.Point(0, 0);
            this.eoDCalculator1.Name = "eoDCalculator1";
            this.eoDCalculator1.Size = new System.Drawing.Size(1186, 621);
            this.eoDCalculator1.TabIndex = 0;
            // 
            // EoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_KeystonePanel);
            this.Controls.Add(this.btn_CppPanel);
            this.Controls.Add(this.btn_EoDPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EoD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Name Application";
            this.Load += new System.EventHandler(this.EoD_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tip_Enter_Amounts;
        private System.Windows.Forms.Button btn_EoDPanel;
        private System.Windows.Forms.Button btn_CppPanel;
        private System.Windows.Forms.Button btn_KeystonePanel;
        private System.Windows.Forms.Panel panel1;
        private eKeystoneOrderSheetMain eKeystoneOrderSheetMain1;
        private CPPOrderSheetMain cppOrderSheetMain1;
        private EoDCalculator eoDCalculator1;
    }
}

