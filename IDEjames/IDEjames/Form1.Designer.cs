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
            this.GuardarcomoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Posicion = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.Colum = new System.Windows.Forms.Label();
            this.columna = new System.Windows.Forms.Label();
            this.LogError = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem,
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
            this.toolStripSeparator1,
            this.GuardarcomoMenuItem});
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
            // GuardarcomoMenuItem
            // 
            this.GuardarcomoMenuItem.Name = "GuardarcomoMenuItem";
            this.GuardarcomoMenuItem.Size = new System.Drawing.Size(153, 22);
            this.GuardarcomoMenuItem.Text = "Guardar como";
            this.GuardarcomoMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click_1);
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar archivo";
            this.eliminarArchivoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArchivoToolStripMenuItem_Click);
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
            this.TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(65, 27);
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBox.Size = new System.Drawing.Size(867, 342);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.VScroll += new System.EventHandler(this.TextBox_VScrollChanged);
            this.TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.TextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.muestraPosicion);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(31, 2);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(17, 19);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 339);
            this.panel1.TabIndex = 2;
            // 
            // Posicion
            // 
            this.Posicion.AutoSize = true;
            this.Posicion.Location = new System.Drawing.Point(67, 381);
            this.Posicion.Name = "Posicion";
            this.Posicion.Size = new System.Drawing.Size(32, 13);
            this.Posicion.TabIndex = 4;
            this.Posicion.Text = "FILA:";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(115, 381);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(25, 13);
            this.position.TabIndex = 5;
            this.position.Text = "___";
            // 
            // Colum
            // 
            this.Colum.AutoSize = true;
            this.Colum.Location = new System.Drawing.Point(160, 381);
            this.Colum.Name = "Colum";
            this.Colum.Size = new System.Drawing.Size(51, 13);
            this.Colum.TabIndex = 6;
            this.Colum.Text = "Columna:";
            // 
            // columna
            // 
            this.columna.AutoSize = true;
            this.columna.Location = new System.Drawing.Point(227, 381);
            this.columna.Name = "columna";
            this.columna.Size = new System.Drawing.Size(25, 13);
            this.columna.TabIndex = 7;
            this.columna.Text = "___";
            // 
            // LogError
            // 
            this.LogError.AcceptsTab = true;
            this.LogError.Location = new System.Drawing.Point(70, 430);
            this.LogError.Name = "LogError";
            this.LogError.ReadOnly = true;
            this.LogError.Size = new System.Drawing.Size(867, 157);
            this.LogError.TabIndex = 3;
            this.LogError.Text = "";
            this.LogError.TextChanged += new System.EventHandler(this.LogError_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 626);
            this.Controls.Add(this.columna);
            this.Controls.Add(this.Colum);
            this.Controls.Add(this.position);
            this.Controls.Add(this.Posicion);
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
        private System.Windows.Forms.Label Posicion;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label Colum;
        private System.Windows.Forms.Label columna;
        private System.Windows.Forms.ToolStripMenuItem GuardarcomoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox LogError;
    }
}

