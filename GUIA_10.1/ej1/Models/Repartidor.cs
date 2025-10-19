using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models;
public class Repartidor
{
    private Stack<Paquete> entregas;
    public int Capacidad { get; private set; }
    public int Ocupacion
    {
        get { return entregas.Count; }
    }
    public Repartidor(int capacidad)
    {
        this.Capacidad = capacidad;
        entregas = new Stack<Paquete>();
    }
    public Paquete Revisar()
    {
        if(entregas.Count > 0) { return entregas.Peek(); }
        return null;
    }
    public void Cargar(Paquete entrega)
    {
        if (TieneCapacidadDisponible()) { entregas.Push(entrega); }
    }
    public Paquete Descargar()
    {
        if(entregas.Count > 0) { return entregas.Pop(); }
        return null;
    }
    public bool TieneCapacidadDisponible()
    {
        return this.Capacidad - this.Ocupacion > 0;
    }
}
