
namespace ventacelular
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bATERÍASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLACASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pANTALLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCESORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISPOSITIVOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNVENTARIOToolStripMenuItem,
            this.aCCESORIOSToolStripMenuItem,
            this.dISPOSITIVOSToolStripMenuItem,
            this.aYUDAToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            this.iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bATERÍASToolStripMenuItem,
            this.pLACASToolStripMenuItem,
            this.pANTALLASToolStripMenuItem});
            this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // bATERÍASToolStripMenuItem
            // 
            this.bATERÍASToolStripMenuItem.Name = "bATERÍASToolStripMenuItem";
            this.bATERÍASToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bATERÍASToolStripMenuItem.Text = "BATERÍAS";
            this.bATERÍASToolStripMenuItem.Click += new System.EventHandler(this.bATERÍASToolStripMenuItem_Click);
            // 
            // pLACASToolStripMenuItem
            // 
            this.pLACASToolStripMenuItem.Name = "pLACASToolStripMenuItem";
            this.pLACASToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pLACASToolStripMenuItem.Text = "PLACAS";
            this.pLACASToolStripMenuItem.Click += new System.EventHandler(this.pLACASToolStripMenuItem_Click);
            // 
            // pANTALLASToolStripMenuItem
            // 
            this.pANTALLASToolStripMenuItem.Name = "pANTALLASToolStripMenuItem";
            this.pANTALLASToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pANTALLASToolStripMenuItem.Text = "PANTALLAS";
            // 
            // aCCESORIOSToolStripMenuItem
            // 
            this.aCCESORIOSToolStripMenuItem.Name = "aCCESORIOSToolStripMenuItem";
            this.aCCESORIOSToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.aCCESORIOSToolStripMenuItem.Text = "ACCESORIOS";
            // 
            // dISPOSITIVOSToolStripMenuItem
            // 
            this.dISPOSITIVOSToolStripMenuItem.Name = "dISPOSITIVOSToolStripMenuItem";
            this.dISPOSITIVOSToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.dISPOSITIVOSToolStripMenuItem.Text = "DISPOSITIVOS";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bATERÍASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLACASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pANTALLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCCESORIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISPOSITIVOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
    }
}