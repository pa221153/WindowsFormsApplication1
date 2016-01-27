namespace WindowsFormsApplication1
{
    partial class Przeglądarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przeglądarka));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pasek = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDalej = new System.Windows.Forms.Button();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.goBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(982, 299);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Pasek
            // 
            this.Pasek.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pasek.Location = new System.Drawing.Point(0, 24);
            this.Pasek.Name = "Pasek";
            this.Pasek.Size = new System.Drawing.Size(982, 20);
            this.Pasek.TabIndex = 2;
            this.Pasek.Text = "http://";
            this.Pasek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDalej);
            this.splitContainer1.Panel2.Controls.Add(this.btnCofnij);
            this.splitContainer1.Panel2.Controls.Add(this.goBtn);
            this.splitContainer1.Size = new System.Drawing.Size(982, 376);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnDalej
            // 
            this.btnDalej.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDalej.Image = ((System.Drawing.Image)(resources.GetObject("btnDalej.Image")));
            this.btnDalej.Location = new System.Drawing.Point(75, 23);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(75, 50);
            this.btnDalej.TabIndex = 5;
            this.btnDalej.UseVisualStyleBackColor = true;
            this.btnDalej.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCofnij
            // 
            this.btnCofnij.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCofnij.Image = ((System.Drawing.Image)(resources.GetObject("btnCofnij.Image")));
            this.btnCofnij.Location = new System.Drawing.Point(0, 23);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(75, 50);
            this.btnCofnij.TabIndex = 4;
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.button1_Click);
            // 
            // goBtn
            // 
            this.goBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.goBtn.Location = new System.Drawing.Point(0, 0);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(982, 23);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "Szukaj";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // Przeglądarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 420);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Pasek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Przeglądarka";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.Przeglądarka_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox Pasek;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button btnDalej;
    }
}

