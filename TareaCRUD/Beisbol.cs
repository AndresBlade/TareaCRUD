using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaCRUD
{


    public partial class Beisbol : Form
    {
        ArrayList entradas = new ArrayList();
        public Beisbol()
        {
            InitializeComponent();

            buscarEquipoButton.Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
            //actualizarEquipoButton.Enabled = false;

            ligaComboBox.SelectedIndex= 0;

            entradas.Add(nombreEquipoTextBox);
            entradas.Add(ligaComboBox);
            entradas.Add(ciudadSedeTextBox);
            entradas.Add(perdidosNumerico);
            entradas.Add(ganadosNumerico);


        }

        private bool entradaVacia()
        {
            foreach (Control entrada in entradas)
            {
                if (string.IsNullOrWhiteSpace(entrada.Text)) return true;
            }

            return false;
        }

        private void registrarEquipoButton_Click(object sender, EventArgs e)
        {
            if (entradaVacia())
            {
                MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
            int valor;

            bool soloNumeros = int.TryParse(nombreEquipo, out valor);

            if (soloNumeros)
            {
                MessageBox.Show("El nombre de un club no puede componerse de solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Club Añadido exitosamente");

            limpiarEntradas();

        }

        private void limpiarEntradas()
        {
            foreach (Control entrada in entradas)
            {
                entrada.Text = "";
            }
        }

        private void actualizarEquipoButton_Click(object sender, EventArgs e)
        {

            if (entradaVacia())
            {
                MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Club actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarEntradas();

            //MessageBox.Show("No se encontró al equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buscarEquipoButton_Click(object sender, EventArgs e)
        {
            string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
            if (string.IsNullOrWhiteSpace(nombreEquipo))
            {
                MessageBox.Show("El nombre del equipo a buscar debe de especificarse");
                return;
            }

            MessageBox.Show("Club conseguido");

            ligaComboBox.SelectedIndex= 0;
            ciudadSedeTextBox.Text = "Texto de relleno";
            ganadosNumerico.Value = 10;
            perdidosNumerico.Value = 10;
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
            MessageBox.Show("Reinicio realizado exitosamente", "Exito");
        }
    }
}
