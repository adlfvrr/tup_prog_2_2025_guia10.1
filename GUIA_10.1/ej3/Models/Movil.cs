using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3.Models;
public class Movil : IComparable
{
    public int Numero { get; private set; }
    public Pedido Pasajero;
    public Movil(int numero) { this.Numero = numero; }

    public int CompareTo(Object obj)
    {
        Movil movil = obj as Movil;
        if(movil != null)
        {
            return this.Numero.CompareTo(movil.Numero);
        }
        return -1;
    }
    public override string ToString()
    {
        string hayPasajero = Pasajero!=null ? Pasajero.Direccion : "No asignado";  //Pruebo ternario a partir del ejercicio 2
        return $"Movil N°{this.Numero} - Dirección: {hayPasajero}";
    }
}
