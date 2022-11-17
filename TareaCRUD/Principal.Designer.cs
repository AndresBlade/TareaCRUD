namespace TareaCRUD
{
    public partial class Principal : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoDeFútbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoDeBéisbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saludoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Location = new System.Drawing.Point(78, 210);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(366, 25);
            this.tituloPrincipal.TabIndex = 0;
            this.tituloPrincipal.Text = "Bienvenido al sistema manejador de equipos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoDeFútbolToolStripMenuItem,
            this.equipoDeBéisbolToolStripMenuItem,
            this.saludoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // equipoDeFútbolToolStripMenuItem
            // 
            this.equipoDeFútbolToolStripMenuItem.Name = "equipoDeFútbolToolStripMenuItem";
            this.equipoDeFútbolToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.equipoDeFútbolToolStripMenuItem.Text = "Equipo de Fútbol";
            this.equipoDeFútbolToolStripMenuItem.Click += new System.EventHandler(this.equipoDeFútbolToolStripMenuItem_Click);
            // 
            // equipoDeBéisbolToolStripMenuItem
            // 
            this.equipoDeBéisbolToolStripMenuItem.Name = "equipoDeBéisbolToolStripMenuItem";
            this.equipoDeBéisbolToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.equipoDeBéisbolToolStripMenuItem.Text = "Equipo de Béisbol";
            this.equipoDeBéisbolToolStripMenuItem.Click += new System.EventHandler(this.equipoDeBéisbolToolStripMenuItem_Click);
            // 
            // saludoToolStripMenuItem
            // 
            this.saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            this.saludoToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.saludoToolStripMenuItem.Text = "Saludo";
            this.saludoToolStripMenuItem.Click += new System.EventHandler(this.saludoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tituloPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Manejador de Equipos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tituloPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem equipoDeFútbolToolStripMenuItem;
        private ToolStripMenuItem equipoDeBéisbolToolStripMenuItem;
        private ToolStripMenuItem saludoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}