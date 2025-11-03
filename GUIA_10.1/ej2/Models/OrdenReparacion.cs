using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models;
public class OrdenReparacion
{
    public DateTime Fecha {  get; set; }
    public bool Solucionado {  get; set; } = false;
    public Reclamo reclamo;
    public OrdenReparacion(Reclamo reclamo) { this.reclamo = reclamo;}
    public override string ToString()
    {
        string solText = Solucionado ? "Sí" : "No";
        return $"{this.reclamo.Numero} - {this.reclamo.Nombre} - {solText}";
    }
}
