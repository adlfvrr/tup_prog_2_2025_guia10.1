using ej1.Models;
namespace ej1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        FormDatoCamion modalDatos;
        Despachador despachador = new Despachador();
        Repartidor camion;
        private void btnRecibirCorrespondencia_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            if (DNI != null && nombre != null && direccion != null)
            {
                lbxVerSectorCarga.Items.Add(despachador.RecibirCorrespondencia(DNI, nombre, direccion));
            }
            tbDNI.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
        }

        private void btnPrepararCamion_Click(object sender, EventArgs e)
        {
            camion = null;
            modalDatos = new FormDatoCamion();
            if (modalDatos.ShowDialog() == DialogResult.OK)
            {
                int capacidad = Convert.ToInt32(modalDatos.nudCapacidad.Value);
                lbxListadoAEntregar.Items.Clear();
                camion = despachador.PrepararCamion(capacidad);
                Paquete paquete = null;
                for (int i = 0; i < capacidad; i++)
                {
                    paquete = despachador.CargarPaqueteAlCamion();
                    if (paquete != null)
                    {
                        lbxVerSectorCarga.Items.Remove(paquete);
                        lbxListadoAEntregar.Items.Add(paquete);
                    }
                }
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            if (this.camion != null)
            {
                Paquete paquete = camion.Revisar();
                lbDNI.Text = paquete.DNIRemitente.ToString();
                lbNombre.Text = paquete.NombreRemitente;
                lbDireccion.Text = paquete.Direccion;
                btnEntregarPaquete.Enabled = true;
                btnIniciarReparto.Enabled = false;
            }
            else { MessageBox.Show("No existe un camión."); }
        }

        private void btnEntregarPaquete_Click(object sender, EventArgs e)
        {
            Paquete paquete = camion.Descargar();
            lbxListadoAEntregar.Items.Remove(paquete);
            lbDNI.Text = "";
            lbNombre.Text = "";
            lbDireccion.Text = "";
            paquete = camion.Revisar();
            if (paquete != null)
            {
                lbDNI.Text = paquete.DNIRemitente.ToString();
                lbNombre.Text = paquete.NombreRemitente;
                lbDireccion.Text = paquete.Direccion;
            }
            else
            {
                btnEntregarPaquete.Enabled = false;
                btnIniciarReparto.Enabled = true;
            }
        }
    }
}
