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
            entradas.Add(numParticipacionesNumerico);
            entradas.Add(federadosNumerico);


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
            if (entradaVacia()) MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
            string confederacion = confederacionComboBox.Text;
            int numParticipacionesMundial = (int)numParticipacionesNumerico.Value;
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

            if (entradaVacia()) MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (EquipoFutbol equipoRegistrado in EquiposFutbol)
            {
                string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
                string confederacion = confederacionComboBox.Text;
                int numParticipacionesMundial = (int)numParticipacionesNumerico.Value;
                int numJugadoresFederados = (int)federadosNumerico.Value;

                if (equipoRegistrado.NombreEquipo == nombreEquipo && equipoRegistrado.Confederacion == confederacion && 
                    equipoRegistrado.NumParticipaciones == numParticipacionesMundial && equipoRegistrado.NumFederados == numJugadoresFederados)
                {
                    MessageBox.Show("Los datos previos son los mismos que los datos nuevos. Cambie alguno de los valores de los campos e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (equipoRegistrado.NombreEquipo == nombreEquipo)
                {
                    EquiposFutbol = EquiposFutbol.Where(equipo => equipo.NombreEquipo != nombreEquipo).ToList();
                    

                    EquipoFutbol nuevoEquipo = new EquipoFutbol(nombreEquipo, confederacion, numParticipacionesMundial, numJugadoresFederados);
                    EquiposFutbol.Add(nuevoEquipo);
                    MessageBox.Show("Equipo actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarEntradas();
                    return;
                }
            }

            MessageBox.Show("No se encontró al equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buscarEquipoButton_Click(object sender, EventArgs e)
        {
            string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
            EquipoFutbol equipoBuscado = EquiposFutbol.SingleOrDefault(equipo => equipo.NombreEquipo == nombreEquipo, new EquipoFutbol("", "", 0, 0));

            if (string.IsNullOrWhiteSpace(equipoBuscado.NombreEquipo))
            {
                MessageBox.Show($"El equipo llamado \"{nombreEquipo}\" no pudo ser encontrado");
                return;
            }

            nombreEquipoTextBox.Text = equipoBuscado.NombreEquipo;
            confederacionComboBox.Text = equipoBuscado.Confederacion;
            numParticipacionesNumerico.Text = equipoBuscado.NumParticipaciones.ToString();
            federadosNumerico.Text = equipoBuscado.NumFederados.ToString();
        }

        private void eliminarEquipoButton_Click(object sender, EventArgs e)
        {
            foreach (EquipoFutbol equipoRegistrado in EquiposFutbol)
            {
                string nombreEquipo = nombreEquipoTextBox.Text.ToUpper().Trim();
                if (equipoRegistrado.NombreEquipo == nombreEquipo)
                {
                    EquiposFutbol = EquiposFutbol.Where(equipo => equipo.NombreEquipo != nombreEquipo).ToList();
                    string confederacion = confederacionComboBox.Text;
                    int numParticipacionesMundial = (int)numParticipacionesNumerico.Value;
                    int numJugadoresFederados = (int)federadosNumerico.Value;

                    EquipoFutbol nuevoEquipo = new EquipoFutbol(nombreEquipo, confederacion, numParticipacionesMundial, numJugadoresFederados);
                    MessageBox.Show("Equipo Eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarEntradas();
                    return;
                }
            }

            MessageBox.Show("No se encontró al equipo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
