using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3.Models;
public class Pedido
{
    public string Telefono { get;private set; }
    public string Direccion { get; private set; }
    public Pedido(string tel, string direccion)
    {
        this.Telefono = tel; this.Direccion = direccion;
    }
    public override string ToString()
    {
        return $"{this.Telefono} - {this.Direccion}";
    }
}
