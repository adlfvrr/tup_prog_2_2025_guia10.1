using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models;
public class Reclamo
{
    public int Numero {  get; private set; }
    public string Nombre {  get; private set; }
    public string Motivo { get; private set; }
    public Reclamo(int numero, string nombre, string motivo)
    {
        this.Nombre = nombre; this.Numero = numero; this.Motivo = motivo;
    }
    public override string ToString()
    {
        return $"{this.Numero} - {this.Nombre}: {this.Motivo}";
    }
}
