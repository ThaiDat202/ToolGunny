
namespace GunLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Refesh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ClearCahce = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DevTool = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Refesh,
            this.toolStripButton_ClearCahce,
            this.toolStripButton_DevTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1415, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Refesh
            // 
            this.toolStripButton_Refesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Refesh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Refesh.Image")));
            this.toolStripButton_Refesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refesh.Name = "toolStripButton_Refesh";
            this.toolStripButton_Refesh.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton_Refesh.Text = "Tải lại";
            this.toolStripButton_Refesh.Click += new System.EventHandler(this.toolStripButton_Refesh_Click);
            // 
            // toolStripButton_ClearCahce
            // 
            this.toolStripButton_ClearCahce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_ClearCahce.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ClearCahce.Image")));
            this.toolStripButton_ClearCahce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ClearCahce.Name = "toolStripButton_ClearCahce";
            this.toolStripButton_ClearCahce.Size = new System.Drawing.Size(83, 24);
            this.toolStripButton_ClearCahce.Text = "Xóa Cache";
            this.toolStripButton_ClearCahce.Click += new System.EventHandler(this.toolStripButton_ClearCahce_Click);
            // 
            // toolStripButton_DevTool
            // 
            this.toolStripButton_DevTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_DevTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_DevTool.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DevTool.Image")));
            this.toolStripButton_DevTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DevTool.Name = "toolStripButton_DevTool";
            this.toolStripButton_DevTool.Size = new System.Drawing.Size(100, 24);
            this.toolStripButton_DevTool.Text = "Mở DevTools";
            this.toolStripButton_DevTool.Click += new System.EventHandler(this.toolStripButton_DevTool_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 842);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1415, 869);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunLauncher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton_DevTool;
        private System.Windows.Forms.ToolStripButton toolStripButton_Refesh;
        private System.Windows.Forms.ToolStripButton toolStripButton_ClearCahce;
    }
}

