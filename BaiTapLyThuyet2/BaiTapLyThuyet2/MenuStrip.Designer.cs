﻿namespace BaiTapLyThuyet2
{
    partial class MenuStrip
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemToolStripMenuItem,
            this.comboboxToolStripMenuItem,
            this.separatorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Text = "Menu Item";
            // 
            // menuItemToolStripMenuItem
            // 
            this.menuItemToolStripMenuItem.Name = "menuItemToolStripMenuItem";
            this.menuItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuItemToolStripMenuItem.Text = "Menu1";
            this.menuItemToolStripMenuItem.Click += new System.EventHandler(this.menuItemToolStripMenuItem_Click);
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboboxToolStripMenuItem.Text = "Menu2";
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.separatorToolStripMenuItem.Text = "Menu3";
            // 
            // MenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MenuStrip";
            this.Text = "MenuStrip";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separatorToolStripMenuItem;
    }
}