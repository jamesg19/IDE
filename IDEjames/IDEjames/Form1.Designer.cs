namespace IDEjames
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoArchivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LogError = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.SalirMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirMenuItem,
            this.NuevoArchivoMenuItem,
            this.GuardarMenuItem,
            this.toolStripSeparator1});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archiveToolStripMenuItem.Text = "Archivo";
            // 
            // AbrirMenuItem
            // 
            this.AbrirMenuItem.Name = "AbrirMenuItem";
            this.AbrirMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AbrirMenuItem.Text = "Abrir";
            this.AbrirMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // NuevoArchivoMenuItem
            // 
            this.NuevoArchivoMenuItem.Name = "NuevoArchivoMenuItem";
            this.NuevoArchivoMenuItem.Size = new System.Drawing.Size(153, 22);
            this.NuevoArchivoMenuItem.Text = "Nuevo Archivo";
            this.NuevoArchivoMenuItem.Click += new System.EventHandler(this.NuevoArchivoToolStripMenuItem_Click);
            // 
            // GuardarMenuItem
            // 
            this.GuardarMenuItem.Name = "GuardarMenuItem";
            this.GuardarMenuItem.Size = new System.Drawing.Size(153, 22);
            this.GuardarMenuItem.Text = "Guardar";
            this.GuardarMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // SalirMenuItem1
            // 
            this.SalirMenuItem1.Name = "SalirMenuItem1";
            this.SalirMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.SalirMenuItem1.Text = "Salir";
            this.SalirMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // TextBox
            // 
            this.TextBox.AcceptsTab = true;
            this.TextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(65, 50);
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBox.Size = new System.Drawing.Size(867, 299);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.VScroll += new System.EventHandler(this.TextBox_VScrollChanged);
            this.TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.TextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseMove);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(31, 2);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(17, 19);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 304);
            this.panel1.TabIndex = 2;
            // 
            // LogError
            // 
            this.LogError.AcceptsTab = true;
            this.LogError.Location = new System.Drawing.Point(70, 384);
            this.LogError.Name = "LogError";
            this.LogError.ReadOnly = true;
            this.LogError.Size = new System.Drawing.Size(847, 177);
            this.LogError.TabIndex = 3;
            this.LogError.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(944, 626);
            this.Controls.Add(this.LogError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Compilador de Codigo 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoArchivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem1;
        public System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.RichTextBox LogError;
    }
}

