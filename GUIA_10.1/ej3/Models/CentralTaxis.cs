using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ej3.Models;
public class CentralTaxis
{
    public int CantidadDisponibles
    {
        get
        {
            return movilesDisponibles.Count;
        }
    }
    private Queue<Movil> movilesDisponibles = new Queue<Movil>(new[]
    {
      new Movil(1),
      new Movil(2),
      new Movil(3)
    });
    private LinkedList<Movil> movilesOcupados;
    private Queue<Pedido> pedidos;

    public CentralTaxis()
    {
        this.movilesOcupados = new LinkedList<Movil>();
        this.pedidos = new Queue<Pedido>();
    }
    public Pedido RecibirSolicitud(string direccion, string telefono)
    {
        Pedido nuevoPedido = new Pedido(telefono, direccion);
        pedidos.Enqueue(nuevoPedido);
        return nuevoPedido;
    }
    public Movil AsignarCoche()
    {
        Movil movilOcupado = null;
        if (movilesDisponibles.Count > 0 && pedidos.Count > 0)
        {
            Pedido pedidoAtendido = pedidos.Dequeue();
            movilOcupado = movilesDisponibles.Dequeue();
            if (movilOcupado.Pasajero == null)
            {
                movilOcupado.Pasajero = pedidoAtendido;
                movilesOcupados.AddLast(movilOcupado);
            }
        }
        return movilOcupado;
    }
    public Movil LiberarVehiculo(int numero)
    {
        Movil movilALiberar = null;
        if (movilesOcupados.Count > 0)
        {
            LinkedListNode<Movil> node = movilesOcupados.First;
            while (node != null && movilALiberar == null)
            {
                if (node.Value.Numero == numero)
                {
                    movilALiberar = node.Value;
                }
                node = node.Next;
            }
            if (movilALiberar != null)
            {
                movilALiberar.Pasajero = null;
                movilesOcupados.Remove(movilALiberar);
                movilesDisponibles.Enqueue(movilALiberar);
            }
        }
        return movilALiberar;
    }
    public Movil VerDisponible(int idx)
    {
        if (idx >= 0 && idx < CantidadDisponibles)
        {
           //copio esto de la solución con la propiedad CantidadDisponibles
            return movilesDisponibles.ToArray()[idx];
        }
        return null;
    }
}
