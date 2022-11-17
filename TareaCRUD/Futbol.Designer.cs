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
            ((System.ComponentModel.ISupportInitialize)(this.numParticipacionesNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federadosNumerico)).BeginInit();
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
            this.buscarEquipoButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.buscarEquipoButton.Location = new System.Drawing.Point(267, 50);
            this.buscarEquipoButton.Name = "buscarEquipoButton";
            this.buscarEquipoButton.Size = new System.Drawing.Size(65, 65);
            this.buscarEquipoButton.TabIndex = 8;
            this.buscarEquipoButton.Text = "?";
            this.buscarEquipoButton.UseVisualStyleBackColor = true;
            this.buscarEquipoButton.Click += new System.EventHandler(this.buscarEquipoButton_Click);
            // 
            // registrarEquipoButton
            // 
            this.registrarEquipoButton.Location = new System.Drawing.Point(106, 252);
            this.registrarEquipoButton.Name = "registrarEquipoButton";
            this.registrarEquipoButton.Size = new System.Drawing.Size(112, 34);
            this.registrarEquipoButton.TabIndex = 9;
            this.registrarEquipoButton.Text = "Registrar";
            this.registrarEquipoButton.UseVisualStyleBackColor = true;
            this.registrarEquipoButton.Click += new System.EventHandler(this.registrarEquipoButton_Click);
            // 
            // actualizarEquipoButton
            // 
            this.actualizarEquipoButton.Location = new System.Drawing.Point(348, 252);
            this.actualizarEquipoButton.Name = "actualizarEquipoButton";
            this.actualizarEquipoButton.Size = new System.Drawing.Size(112, 34);
            this.actualizarEquipoButton.TabIndex = 10;
            this.actualizarEquipoButton.Text = "Actualizar";
            this.actualizarEquipoButton.UseVisualStyleBackColor = true;
            this.actualizarEquipoButton.Click += new System.EventHandler(this.actualizarEquipoButton_Click);
            // 
            // eliminarEquipoButton
            // 
            this.eliminarEquipoButton.Location = new System.Drawing.Point(590, 252);
            this.eliminarEquipoButton.Name = "eliminarEquipoButton";
            this.eliminarEquipoButton.Size = new System.Drawing.Size(112, 34);
            this.eliminarEquipoButton.TabIndex = 11;
            this.eliminarEquipoButton.Text = "Eliminar";
            this.eliminarEquipoButton.UseVisualStyleBackColor = true;
            this.eliminarEquipoButton.Click += new System.EventHandler(this.eliminarEquipoButton_Click);
            // 
            // Futbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}