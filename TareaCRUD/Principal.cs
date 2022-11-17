namespace TareaCRUD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Font fuenteTitulo = new Font("Verdana", 12, FontStyle.Bold);
            tituloPrincipal.Font = fuenteTitulo;
        }

        private void equipoDeFútbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estado = false;

            Futbol formularioFutbol = new Futbol();

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Futbol))
                {
                    estado = true;
                }
            }

            if (estado)
            {
                return;
            }

            
            formularioFutbol.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult deseaSalir = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (deseaSalir == DialogResult.Yes) this.Close();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, usuario", "Saludo");
        }

        private void equipoDeBéisbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beisbol formularioBeisbol = new Beisbol();

            bool estado = false;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Beisbol))
                {
                    estado = true;
                }
            }

            if (estado)
            {
                return;
            }

            formularioBeisbol.Show();
        }
    }
}