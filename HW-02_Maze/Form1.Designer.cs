
namespace HW_02_Maze
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
            this.mazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Medals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Hearts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mazeToolStripMenuItem,
            this.tsmi_Medals,
            this.tsmi_Hearts});
            this.menuStrip1.Location = new System.Drawing.Point(0, 423);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mazeToolStripMenuItem
            // 
            this.mazeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mazeToolStripMenuItem.Name = "mazeToolStripMenuItem";
            this.mazeToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.mazeToolStripMenuItem.Text = "-=Maze=-";
            // 
            // tsmi_Medals
            // 
            this.tsmi_Medals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_Medals.Name = "tsmi_Medals";
            this.tsmi_Medals.Size = new System.Drawing.Size(101, 22);
            this.tsmi_Medals.Text = " > > 0*★ < <";
            // 
            // tsmi_Hearts
            // 
            this.tsmi_Hearts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_Hearts.Name = "tsmi_Hearts";
            this.tsmi_Hearts.Size = new System.Drawing.Size(115, 22);
            this.tsmi_Hearts.Text = "❤❤❤❤❤";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Medals;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Hearts;
    }
}

