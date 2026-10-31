namespace GunTools
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_12 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_XmlTools = new System.Windows.Forms.Button();
            this.btnReqTools = new System.Windows.Forms.Button();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 69);
            this.panel1.TabIndex = 0;
            // 
            // panel_12
            // 
            this.panel_12.Controls.Add(this.panel_Control);
            this.panel_12.Controls.Add(this.panel2);
            this.panel_12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_12.Location = new System.Drawing.Point(2, 71);
            this.panel_12.Name = "panel_12";
            this.panel_12.Size = new System.Drawing.Size(881, 466);
            this.panel_12.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 69);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(217, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 69);
            this.panel4.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_XmlTools);
            this.flowLayoutPanel1.Controls.Add(this.btnReqTools);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(664, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_XmlTools
            // 
            this.btn_XmlTools.Location = new System.Drawing.Point(3, 3);
            this.btn_XmlTools.Name = "btn_XmlTools";
            this.btn_XmlTools.Size = new System.Drawing.Size(75, 23);
            this.btn_XmlTools.TabIndex = 0;
            this.btn_XmlTools.Text = "XML Tools";
            this.btn_XmlTools.UseVisualStyleBackColor = true;
            this.btn_XmlTools.Click += new System.EventHandler(this.btn_XmlTools_Click);
            // 
            // btnReqTools
            // 
            this.btnReqTools.Location = new System.Drawing.Point(84, 3);
            this.btnReqTools.Name = "btnReqTools";
            this.btnReqTools.Size = new System.Drawing.Size(105, 23);
            this.btnReqTools.TabIndex = 1;
            this.btnReqTools.Text = "Request Tools";
            this.btnReqTools.UseVisualStyleBackColor = true;
            this.btnReqTools.Click += new System.EventHandler(this.btnReqTools_Click);
            // 
            // panel_Control
            // 
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Control.Location = new System.Drawing.Point(0, 1);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Control.Size = new System.Drawing.Size(881, 465);
            this.panel_Control.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 1);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 539);
            this.Controls.Add(this.panel_12);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunTools";
            this.panel1.ResumeLayout(false);
            this.panel_12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_XmlTools;
        private System.Windows.Forms.Button btnReqTools;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel2;
    }
}

