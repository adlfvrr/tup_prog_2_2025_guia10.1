using ej2.Models;

namespace ej2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }
        CentroDeAtencion centro = new CentroDeAtencion();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = tbNombre.Text;
            string Motivo = tbMotivo.Text;
            Reclamo nuevoReclamo = centro.RecibirReclamo(Nombre, Motivo);
            if (nuevoReclamo != null)
            {
                lbxVerReclamos.Items.Add(nuevoReclamo);
            }
            tbMotivo.Clear();
            tbNombre.Clear();
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion ordenAEjecutar = centro.ResolverReclamo();
            if (ordenAEjecutar != null)
            {
                lbxVerReclamos.Items.Remove(ordenAEjecutar.reclamo);
                lbxVerOrdenAEjecutar.Items.Add(ordenAEjecutar);
            }
        }

        private void btnEjecutarOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion orden = centro.EjecutarOrdenDeTrabajo();
            lbxVerOrdenAEjecutar.Items.Remove(orden);
        }
    }
}
