using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models;
public class CentroDeAtencion
{
    private int numeroReclamoGen;
    Queue<Reclamo> reclamosPendientes;
    Queue<OrdenReparacion> trabajosPendientes;
    public CentroDeAtencion()
    {
        this.numeroReclamoGen = 1;
        reclamosPendientes = new Queue<Reclamo>();
        trabajosPendientes = new Queue<OrdenReparacion>();
    }
    public Reclamo RecibirReclamo(string nombrePersona, string motivo)
    {
        Reclamo nuevoReclamo = null;
        nuevoReclamo = new Reclamo(this.numeroReclamoGen++, nombrePersona, motivo);
        reclamosPendientes.Enqueue(nuevoReclamo);
        return nuevoReclamo;
    }
    public OrdenReparacion ResolverReclamo()
    {
        OrdenReparacion nuevaOrden = null;
        Reclamo reclamoAResolver = reclamosPendientes.Dequeue();
        if (reclamoAResolver != null)
        {
            nuevaOrden = new OrdenReparacion(reclamoAResolver);
            DateTime fecha = DateTime.Now;
            nuevaOrden.Fecha = fecha;
            trabajosPendientes.Enqueue(nuevaOrden);
        }
        return nuevaOrden;
    }
    public OrdenReparacion EjecutarOrdenDeTrabajo()
    {
        OrdenReparacion ordenEjecutada = null;
        ordenEjecutada = trabajosPendientes.Dequeue();
        if (ordenEjecutada != null)
        {
            ordenEjecutada.Solucionado = true;
        }
        return ordenEjecutada;
    }
}
