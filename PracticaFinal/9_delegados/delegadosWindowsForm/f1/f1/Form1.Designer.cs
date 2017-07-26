namespace f1
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
            this.op1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOp1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOp2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // op1ToolStripMenuItem
            // 
            this.op1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subOp1ToolStripMenuItem,
            this.subOp2ToolStripMenuItem});
            this.op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            this.op1ToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.op1ToolStripMenuItem.Text = "op1";
            // 
            // subOp1ToolStripMenuItem
            // 
            this.subOp1ToolStripMenuItem.Name = "subOp1ToolStripMenuItem";
            this.subOp1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subOp1ToolStripMenuItem.Text = "subOp1";
            this.subOp1ToolStripMenuItem.Click += new System.EventHandler(this.subOp1ToolStripMenuItem_Click);
            // 
            // subOp2ToolStripMenuItem
            // 
            this.subOp2ToolStripMenuItem.Name = "subOp2ToolStripMenuItem";
            this.subOp2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subOp2ToolStripMenuItem.Text = "subOp2";
            this.subOp2ToolStripMenuItem.Click += new System.EventHandler(this.subOp2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem op1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOp1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOp2ToolStripMenuItem;
    }
}

