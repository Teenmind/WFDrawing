using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsDrawing
{
    partial class Drawing
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
            this.DrawingPanel = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuColorBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSizeSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSizeMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSizeLarge = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPanel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 28);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(786, 412);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.TabStop = false;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripColor,
            this.toolStripSize});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripColor
            // 
            this.toolStripColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuColorBlack,
            this.toolStripMenuColorBlue,
            this.toolStripMenuColorRed});
            this.toolStripColor.Name = "toolStripColor";
            this.toolStripColor.Size = new System.Drawing.Size(57, 24);
            this.toolStripColor.Text = "Color";
            // 
            // toolStripMenuColorBlack
            // 
            this.toolStripMenuColorBlack.Name = "toolStripMenuColorBlack";
            this.toolStripMenuColorBlack.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuColorBlack.Text = "Black";
            this.toolStripMenuColorBlack.Click += new System.EventHandler(this.toolStripMenuColorBlack_Click);
            // 
            // toolStripMenuColorBlue
            // 
            this.toolStripMenuColorBlue.Name = "toolStripMenuColorBlue";
            this.toolStripMenuColorBlue.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuColorBlue.Text = "Blue";
            this.toolStripMenuColorBlue.Click += new System.EventHandler(this.toolStripMenuColorBlue_Click);
            // 
            // toolStripMenuColorRed
            // 
            this.toolStripMenuColorRed.Name = "toolStripMenuColorRed";
            this.toolStripMenuColorRed.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuColorRed.Text = "Red";
            this.toolStripMenuColorRed.Click += new System.EventHandler(this.toolStripMenuRed_Click);
            // 
            // toolStripSize
            // 
            this.toolStripSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSizeSmall,
            this.toolStripMenuSizeMedium,
            this.toolStripMenuSizeLarge});
            this.toolStripSize.Name = "toolStripSize";
            this.toolStripSize.Size = new System.Drawing.Size(48, 24);
            this.toolStripSize.Text = "Size";
            // 
            // toolStripMenuSizeSmall
            // 
            this.toolStripMenuSizeSmall.Name = "toolStripMenuSizeSmall";
            this.toolStripMenuSizeSmall.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuSizeSmall.Text = "Small";
            this.toolStripMenuSizeSmall.Click += new System.EventHandler(this.toolStripMenuSizeSmall_Click);
            // 
            // toolStripMenuSizeMedium
            // 
            this.toolStripMenuSizeMedium.Name = "toolStripMenuSizeMedium";
            this.toolStripMenuSizeMedium.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuSizeMedium.Text = "Medium";
            this.toolStripMenuSizeMedium.Click += new System.EventHandler(this.toolStripMenuSizeMedium_Click);
            // 
            // toolStripMenuSizeLarge
            // 
            this.toolStripMenuSizeLarge.Name = "toolStripMenuSizeLarge";
            this.toolStripMenuSizeLarge.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuSizeLarge.Text = "Large";
            this.toolStripMenuSizeLarge.Click += new System.EventHandler(this.toolStripMenuSizeLarge_Click);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 440);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Drawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPanel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripColor;
        private ToolStripMenuItem toolStripMenuColorBlack;
        private ToolStripMenuItem toolStripMenuColorBlue;
        private ToolStripMenuItem toolStripMenuColorRed;
        private ToolStripMenuItem toolStripSize;
        private ToolStripMenuItem toolStripMenuSizeSmall;
        private ToolStripMenuItem toolStripMenuSizeMedium;
        private ToolStripMenuItem toolStripMenuSizeLarge;
    }
}

