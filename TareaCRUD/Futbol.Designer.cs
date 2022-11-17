namespace TareaCRUD
{
    partial class Futbol
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
            this.confederacionLabel = new System.Windows.Forms.Label();
            this.confederacionComboBox = new System.Windows.Forms.ComboBox();
            this.numParticipacionesNumerico = new System.Windows.Forms.NumericUpDown();
            this.numParticipacioneslabel = new System.Windows.Forms.Label();
            this.federadosLabel = new System.Windows.Forms.Label();
            this.federadosNumerico = new System.Windows.Forms.NumericUpDown();
            this.buscarEquipoButton = new System.Windows.Forms.Button();
            this.registrarEquipoButton = new System.Windows.Forms.Button();
            this.actualizarEquipoButton = new System.Windows.Forms.Button();
            this.eliminarEquipoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipacionesNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federadosNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreEquipoLabel
            // 
            this.nombreEquipoLabel.AutoSize = true;
            this.nombreEquipoLabel.Location = new System.Drawing.Point(35, 50);
            this.nombreEquipoLabel.Name = "nombreEquipoLabel";
            this.nombreEquipoLabel.Size = new System.Drawing.Size(215, 25);
            this.nombreEquipoLabel.TabIndex = 0;
            this.nombreEquipoLabel.Text = "Nombre del Equipo (país)";
            // 
            // nombreEquipoTextBox
            // 
            this.nombreEquipoTextBox.Location = new System.Drawing.Point(35, 80);
            this.nombreEquipoTextBox.Name = "nombreEquipoTextBox";
            this.nombreEquipoTextBox.Size = new System.Drawing.Size(215, 31);
            this.nombreEquipoTextBox.TabIndex = 1;
            // 
            // confederacionLabel
            // 
            this.confederacionLabel.AutoSize = true;
            this.confederacionLabel.Location = new System.Drawing.Point(35, 132);
            this.confederacionLabel.Name = "confederacionLabel";
            this.confederacionLabel.Size = new System.Drawing.Size(127, 25);
            this.confederacionLabel.TabIndex = 2;
            this.confederacionLabel.Text = "Confederación";
            // 
            // confederacionComboBox
            // 
            this.confederacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.confederacionComboBox.FormattingEnabled = true;
            this.confederacionComboBox.Items.AddRange(new object[] {
            "AFC",
            "CAF",
            "CONCACAF",
            "CONMEBOL",
            "OFC",
            "UEFA"});
            this.confederacionComboBox.Location = new System.Drawing.Point(35, 162);
            this.confederacionComboBox.Name = "confederacionComboBox";
            this.confederacionComboBox.Size = new System.Drawing.Size(215, 33);
            this.confederacionComboBox.TabIndex = 3;
            // 
            // numParticipacionesNumerico
            // 
            this.numParticipacionesNumerico.Location = new System.Drawing.Point(280, 162);
            this.numParticipacionesNumerico.Name = "numParticipacionesNumerico";
            this.numParticipacionesNumerico.Size = new System.Drawing.Size(286, 31);
            this.numParticipacionesNumerico.TabIndex = 4;
            // 
            // numParticipacioneslabel
            // 
            this.numParticipacioneslabel.AutoSize = true;
            this.numParticipacioneslabel.Location = new System.Drawing.Point(280, 132);
            this.numParticipacioneslabel.Name = "numParticipacioneslabel";
            this.numParticipacioneslabel.Size = new System.Drawing.Size(286, 25);
            this.numParticipacioneslabel.TabIndex = 5;
            this.numParticipacioneslabel.Text = "Num. Participaciones en mundiales";
            // 
            // federadosLabel
            // 
            this.federadosLabel.AutoSize = true;
            this.federadosLabel.Location = new System.Drawing.Point(596, 132);
            this.federadosLabel.Name = "federadosLabel";
            this.federadosLabel.Size = new System.Drawing.Size(181, 25);
            this.federadosLabel.TabIndex = 7;
            this.federadosLabel.Text = "Jugadores Federados";
            // 
            // federadosNumerico
            // 
            this.federadosNumerico.Location = new System.Drawing.Point(596, 162);
            this.federadosNumerico.Name = "federadosNumerico";
            this.federadosNumerico.Size = new System.Drawing.Size(181, 31);
            this.federadosNumerico.TabIndex = 6;
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
            this.registrarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.registrarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarEquipoButton.Location = new System.Drawing.Point(57, 248);
            this.registrarEquipoButton.Name = "registrarEquipoButton";
            this.registrarEquipoButton.Size = new System.Drawing.Size(112, 34);
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
            this.actualizarEquipoButton.Location = new System.Drawing.Point(249, 248);
            this.actualizarEquipoButton.Name = "actualizarEquipoButton";
            this.actualizarEquipoButton.Size = new System.Drawing.Size(112, 34);
            this.actualizarEquipoButton.TabIndex = 10;
            this.actualizarEquipoButton.Text = "Actualizar";
            this.actualizarEquipoButton.UseVisualStyleBackColor = false;
            this.actualizarEquipoButton.Click += new System.EventHandler(this.actualizarEquipoButton_Click);
            // 
            // eliminarEquipoButton
            // 
            this.eliminarEquipoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eliminarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.eliminarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarEquipoButton.Location = new System.Drawing.Point(441, 248);
            this.eliminarEquipoButton.Name = "eliminarEquipoButton";
            this.eliminarEquipoButton.Size = new System.Drawing.Size(112, 34);
            this.eliminarEquipoButton.TabIndex = 11;
            this.eliminarEquipoButton.Text = "Eliminar";
            this.eliminarEquipoButton.UseVisualStyleBackColor = false;
            this.eliminarEquipoButton.Click += new System.EventHandler(this.eliminarEquipoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TareaCRUD.Properties.Resources.messi;
            this.pictureBox1.Location = new System.Drawing.Point(62, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TareaCRUD.Properties.Resources.cristiano;
            this.pictureBox2.Location = new System.Drawing.Point(435, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Maneje los equipos de fútbol";
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reiniciarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Location = new System.Drawing.Point(633, 248);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(112, 34);
            this.reiniciarButton.TabIndex = 15;
            this.reiniciarButton.Text = "Reiniciar";
            this.reiniciarButton.UseVisualStyleBackColor = false;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nota: los campos numéricos reescribirán automáticamente valores negativos, dándol" +
    "es el valor 0\r\n\r\n";
            // 
            // Futbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eliminarEquipoButton);
            this.Controls.Add(this.actualizarEquipoButton);
            this.Controls.Add(this.registrarEquipoButton);
            this.Controls.Add(this.buscarEquipoButton);
            this.Controls.Add(this.federadosLabel);
            this.Controls.Add(this.federadosNumerico);
            this.Controls.Add(this.numParticipacioneslabel);
            this.Controls.Add(this.numParticipacionesNumerico);
            this.Controls.Add(this.confederacionComboBox);
            this.Controls.Add(this.confederacionLabel);
            this.Controls.Add(this.nombreEquipoTextBox);
            this.Controls.Add(this.nombreEquipoLabel);
            this.Name = "Futbol";
            this.Text = "Equipo de Fútbol";
            ((System.ComponentModel.ISupportInitialize)(this.numParticipacionesNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federadosNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreEquipoLabel;
        private TextBox nombreEquipoTextBox;
        private Label confederacionLabel;
        private ComboBox confederacionComboBox;
        private NumericUpDown numParticipacionesNumerico;
        private Label numParticipacioneslabel;
        private Label federadosLabel;
        private NumericUpDown federadosNumerico;
        private Button buscarEquipoButton;
        private Button registrarEquipoButton;
        private Button actualizarEquipoButton;
        private Button eliminarEquipoButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button reiniciarButton;
        private Label label2;
    }
}