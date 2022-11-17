using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaCRUD
{

    
    public partial class Futbol : Form
    {
        ArrayList entradas = new ArrayList();
        List<EquipoFutbol> EquiposFutbol;
        public Futbol()
        {
            InitializeComponent();

            EquiposFutbol = new List<EquipoFutbol>();

            buscarEquipoButton.Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);

            entradas.Add(nombreEquipoTextBox);
            entradas.Add(confederacionComboBox);
            entradas.Add(numParticionesNumerico);
            entradas.Add(federadosNumerico);


        }

        private void registrarEquipoButton_Click(object sender, EventArgs e)
        {

            foreach (Control entrada in entradas)
            {
                if (string.IsNullOrWhiteSpace(entrada.Text))
                {
                    MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
            string confederacion = confederacionComboBox.Text;
            int numParticipacionesMundial = (int)numParticionesNumerico.Value;
            int numJugadoresFederados = (int)federadosNumerico.Value;

            EquipoFutbol nuevoEquipo = new EquipoFutbol(nombreEquipo, confederacion, numParticipacionesMundial, numJugadoresFederados);

            foreach (EquipoFutbol equipoRegistrado in EquiposFutbol)
            {
                if (equipoRegistrado.NombreEquipo == nuevoEquipo.NombreEquipo)
                {
                    MessageBox.Show("Ya existe un equipo con el nombre dado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            EquiposFutbol.Add(nuevoEquipo);

            MessageBox.Show("Equipo Añadido exitosamente");

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
            foreach (EquipoFutbol equipoRegistrado in EquiposFutbol)
            {
                if (equipoRegistrado.NombreEquipo == nombreEquipoTextBox.Text)
                {
                    EquiposFutbol.Remove(equipoRegistrado);
                    string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
                    string confederacion = confederacionComboBox.Text;
                    int numParticipacionesMundial = (int)numParticionesNumerico.Value;
                    int numJugadoresFederados = (int)federadosNumerico.Value;

                    EquipoFutbol nuevoEquipo = new EquipoFutbol(nombreEquipo, confederacion, numParticipacionesMundial, numJugadoresFederados);
                    EquiposFutbol.Add(nuevoEquipo);
                    MessageBox.Show("Equipo actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("No se encontró al equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
