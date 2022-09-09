
namespace HW_04_ContextMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createAButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.createATextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createACheckboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAButtonToolStripMenuItem,
            this.createATextboxToolStripMenuItem,
            this.createACheckboxToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 70);
            // 
            // createAButtonToolStripMenuItem
            // 
            this.createAButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.toolStripTextBox1});
            this.createAButtonToolStripMenuItem.Name = "createAButtonToolStripMenuItem";
            this.createAButtonToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.createAButtonToolStripMenuItem.Text = "Create a button (3)";
            this.createAButtonToolStripMenuItem.Click += new System.EventHandler(this.createAButtonToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.textToolStripMenuItem.Text = "Text:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // createATextboxToolStripMenuItem
            // 
            this.createATextboxToolStripMenuItem.Name = "createATextboxToolStripMenuItem";
            this.createATextboxToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.createATextboxToolStripMenuItem.Text = "Create a textbox (3)";
            this.createATextboxToolStripMenuItem.Click += new System.EventHandler(this.createATextboxToolStripMenuItem_Click);
            // 
            // createACheckboxToolStripMenuItem
            // 
            this.createACheckboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem1,
            this.toolStripTextBox2});
            this.createACheckboxToolStripMenuItem.Name = "createACheckboxToolStripMenuItem";
            this.createACheckboxToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.createACheckboxToolStripMenuItem.Text = "Create a checkbox (3)";
            this.createACheckboxToolStripMenuItem.Click += new System.EventHandler(this.createACheckboxToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.textToolStripMenuItem1.Text = "Text:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createAButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createATextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createACheckboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}

