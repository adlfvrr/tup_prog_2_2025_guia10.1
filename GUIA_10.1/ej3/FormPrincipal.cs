using ej3.Models;

namespace ej3;
public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }
    CentralTaxis central = new CentralTaxis();
    private void btnAtender_Click(object sender, EventArgs e)
    {
        string dir = tbDireccion.Text;
        string tel = tbTelefono.Text;
        Pedido nuevoPedido = central.RecibirSolicitud(dir, tel);
        if (nuevoPedido != null)
        {
            lbxPedidosEntrantes.Items.Add(nuevoPedido);
        }
        tbDireccion.Clear();
        tbTelefono.Clear();
    }

    private void btnAsignar_Click(object sender, EventArgs e)
    {
        Movil movilAsignado = central.AsignarCoche();
        if (movilAsignado != null)
        {
            lbxDisponibles.Items.Remove(movilAsignado);
            lbxPedidosEntrantes.Items.Remove(movilAsignado.Pasajero);
            lbxOcupados.Items.Add(movilAsignado);
        }
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        for (int idx = 0; idx < central.CantidadDisponibles; idx++)
        {
            lbxDisponibles.Items.Add(central.VerDisponible(idx));
        }
    }

    private void btnLiberar_Click(object sender, EventArgs e)
    {
        Movil movilLiberado = central.LiberarVehiculo(Convert.ToInt32(nupNumeroMovil.Value));
        if(movilLiberado != null)
        {
            lbxOcupados.Items.Remove(movilLiberado);
            lbxDisponibles.Items.Add(movilLiberado);
        }
    }
}
