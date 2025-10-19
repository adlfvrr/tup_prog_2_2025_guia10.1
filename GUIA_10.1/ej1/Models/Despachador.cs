using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models;
public class Despachador
{
    Queue<Paquete> depositos;
    Repartidor camion;
    public Despachador()
    {
        depositos = new Queue<Paquete>();
    }
    public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
    {
        Paquete paquete = new Paquete(dni, nombre, direccion);
        depositos.Enqueue(paquete);
        return paquete;
    }
    public Repartidor PrepararCamion(int capacidad)
    {
        if (this.camion == null) { return this.camion = new Repartidor(capacidad); }
        return null;
    }
    public Paquete CargarPaqueteAlCamion()
    {
        Paquete paquete = null;
        if (this.camion.TieneCapacidadDisponible()==true && depositos.Count > 0)
        {
            paquete = depositos.Dequeue();
            camion.Cargar(paquete);
        }
        return paquete;
    }
}
