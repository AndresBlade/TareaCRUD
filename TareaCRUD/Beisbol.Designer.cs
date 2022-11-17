namespace TareaCRUD
{
    partial class Beisbol
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
            this.nombreEquipoLabel = new System.Windows.Forms.Label();
            this.nombreEquipoTextBox = new System.Windows.Forms.TextBox();
            this.ligaLabel = new System.Windows.Forms.Label();
            this.ligaComboBox = new System.Windows.Forms.ComboBox();
            this.ciudadSedeLabel = new System.Windows.Forms.Label();
            this.juegosGanadosLabel = new System.Windows.Forms.Label();
            this.ganadosNumerico = new System.Windows.Forms.NumericUpDown();
            this.buscarEquipoButton = new System.Windows.Forms.Button();
            this.registrarEquipoButton = new System.Windows.Forms.Button();
            this.actualizarEquipoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ciudadSedeTextBox = new System.Windows.Forms.TextBox();
            this.juegosPerdidosLabel = new System.Windows.Forms.Label();
            this.perdidosNumerico = new System.Windows.Forms.NumericUpDown();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ganadosNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidosNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreEquipoLabel
            // 
            this.nombreEquipoLabel.AutoSize = true;
            this.nombreEquipoLabel.Location = new System.Drawing.Point(35, 50);
            this.nombreEquipoLabel.Name = "nombreEquipoLabel";
            this.nombreEquipoLabel.Size = new System.Drawing.Size(148, 25);
            this.nombreEquipoLabel.TabIndex = 0;
            this.nombreEquipoLabel.Text = "Nombre del Club";
            // 
            // nombreEquipoTextBox
            // 
            this.nombreEquipoTextBox.Location = new System.Drawing.Point(35, 80);
            this.nombreEquipoTextBox.Name = "nombreEquipoTextBox";
            this.nombreEquipoTextBox.Size = new System.Drawing.Size(215, 31);
            this.nombreEquipoTextBox.TabIndex = 1;
            // 
            // ligaLabel
            // 
            this.ligaLabel.AutoSize = true;
            this.ligaLabel.Location = new System.Drawing.Point(35, 121);
            this.ligaLabel.Name = "ligaLabel";
            this.ligaLabel.Size = new System.Drawing.Size(44, 25);
            this.ligaLabel.TabIndex = 2;
            this.ligaLabel.Text = "Liga";
            // 
            // ligaComboBox
            // 
            this.ligaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ligaComboBox.FormattingEnabled = true;
            this.ligaComboBox.Items.AddRange(new object[] {
            "Nacional",
            "Americana"});
            this.ligaComboBox.Location = new System.Drawing.Point(35, 151);
            this.ligaComboBox.Name = "ligaComboBox";
            this.ligaComboBox.Size = new System.Drawing.Size(215, 33);
            this.ligaComboBox.TabIndex = 3;
            // 
            // ciudadSedeLabel
            // 
            this.ciudadSedeLabel.AutoSize = true;
            this.ciudadSedeLabel.Location = new System.Drawing.Point(35, 189);
            this.ciudadSedeLabel.Name = "ciudadSedeLabel";
            this.ciudadSedeLabel.Size = new System.Drawing.Size(112, 25);
            this.ciudadSedeLabel.TabIndex = 5;
            this.ciudadSedeLabel.Text = "Ciudad Sede";
            // 
            // juegosGanadosLabel
            // 
            this.juegosGanadosLabel.AutoSize = true;
            this.juegosGanadosLabel.Location = new System.Drawing.Point(35, 260);
            this.juegosGanadosLabel.Name = "juegosGanadosLabel";
            this.juegosGanadosLabel.Size = new System.Drawing.Size(142, 25);
            this.juegosGanadosLabel.TabIndex = 7;
            this.juegosGanadosLabel.Text = "Juegos Ganados";
            // 
            // ganadosNumerico
            // 
            this.ganadosNumerico.Location = new System.Drawing.Point(35, 290);
            this.ganadosNumerico.Name = "ganadosNumerico";
            this.ganadosNumerico.Size = new System.Drawing.Size(181, 31);
            this.ganadosNumerico.TabIndex = 6;
            // 
            // buscarEquipoButton
            // 
            this.buscarEquipoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buscarEquipoButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.buscarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buscarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarEquipoButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarEquipoButton.Location = new System.Drawing.Point(267, 50);
            this.buscarEquipoButton.Name = "buscarEquipoButton";
            this.buscarEquipoButton.Size = new System.Drawing.Size(65, 65);
            this.buscarEquipoButton.TabIndex = 8;
            this.buscarEquipoButton.Text = "?";
            this.buscarEquipoButton.UseVisualStyleBackColor = false;
            this.buscarEquipoButton.Click += new System.EventHandler(this.buscarEquipoButton_Click);
            // 
            // registrarEquipoButton
            // 
            this.registrarEquipoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registrarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.registrarEquipoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.registrarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarEquipoButton.Location = new System.Drawing.Point(334, 393);
            this.registrarEquipoButton.Name = "registrarEquipoButton";
            this.registrarEquipoButton.Size = new System.Drawing.Size(115, 34);
            this.registrarEquipoButton.TabIndex = 9;
            this.registrarEquipoButton.Text = "Registrar";
            this.registrarEquipoButton.UseVisualStyleBackColor = false;
            this.registrarEquipoButton.Click += new System.EventHandler(this.registrarEquipoButton_Click);
            // 
            // actualizarEquipoButton
            // 
            this.actualizarEquipoButton.BackColor = System.Drawing.Color.Fuchsia;
            this.actualizarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.actualizarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarEquipoButton.Location = new System.Drawing.Point(499, 393);
            this.actualizarEquipoButton.Name = "actualizarEquipoButton";
            this.actualizarEquipoButton.Size = new System.Drawing.Size(115, 34);
            this.actualizarEquipoButton.TabIndex = 10;
            this.actualizarEquipoButton.Text = "Actualizar";
            this.actualizarEquipoButton.UseVisualStyleBackColor = false;
            this.actualizarEquipoButton.Click += new System.EventHandler(this.actualizarEquipoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Maneje los equipos de Béisbol";
            // 
            // ciudadSedeTextBox
            // 
            this.ciudadSedeTextBox.Location = new System.Drawing.Point(35, 219);
            this.ciudadSedeTextBox.Name = "ciudadSedeTextBox";
            this.ciudadSedeTextBox.Size = new System.Drawing.Size(286, 31);
            this.ciudadSedeTextBox.TabIndex = 15;
            // 
            // juegosPerdidosLabel
            // 
            this.juegosPerdidosLabel.AutoSize = true;
            this.juegosPerdidosLabel.Location = new System.Drawing.Point(35, 331);
            this.juegosPerdidosLabel.Name = "juegosPerdidosLabel";
            this.juegosPerdidosLabel.Size = new System.Drawing.Size(141, 25);
            this.juegosPerdidosLabel.TabIndex = 17;
            this.juegosPerdidosLabel.Text = "Juegos Perdidos";
            // 
            // perdidosNumerico
            // 
            this.perdidosNumerico.Location = new System.Drawing.Point(35, 361);
            this.perdidosNumerico.Name = "perdidosNumerico";
            this.perdidosNumerico.Size = new System.Drawing.Size(181, 31);
            this.perdidosNumerico.TabIndex = 16;
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reiniciarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Location = new System.Drawing.Point(664, 393);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(112, 34);
            this.reiniciarButton.TabIndex = 18;
            this.reiniciarButton.Text = "Reiniciar";
            this.reiniciarButton.UseVisualStyleBackColor = false;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TareaCRUD.Properties.Resources.estadioBeisbol;
            this.pictureBox1.Location = new System.Drawing.Point(368, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Beisbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.juegosPerdidosLabel);
            this.Controls.Add(this.perdidosNumerico);
            this.Controls.Add(this.ciudadSedeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actualizarEquipoButton);
            this.Controls.Add(this.registrarEquipoButton);
            this.Controls.Add(this.buscarEquipoButton);
            this.Controls.Add(this.juegosGanadosLabel);
            this.Controls.Add(this.ganadosNumerico);
            this.Controls.Add(this.ciudadSedeLabel);
            this.Controls.Add(this.ligaComboBox);
            this.Controls.Add(this.ligaLabel);
            this.Controls.Add(this.nombreEquipoTextBox);
            this.Controls.Add(this.nombreEquipoLabel);
            this.Name = "Beisbol";
            this.Text = "Equipo de Béisbol";
            ((System.ComponentModel.ISupportInitialize)(this.ganadosNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidosNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreEquipoLabel;
        private TextBox nombreEquipoTextBox;
        private Label ligaLabel;
        private ComboBox ligaComboBox;
        private Label ciudadSedeLabel;
        private Label juegosGanadosLabel;
        private NumericUpDown ganadosNumerico;
        private Button buscarEquipoButton;
        private Button registrarEquipoButton;
        private Button actualizarEquipoButton;
        private Label label1;
        private TextBox ciudadSedeTextBox;
        private Label juegosPerdidosLabel;
        private NumericUpDown perdidosNumerico;
        private Button reiniciarButton;
        private PictureBox pictureBox1;
    }
}