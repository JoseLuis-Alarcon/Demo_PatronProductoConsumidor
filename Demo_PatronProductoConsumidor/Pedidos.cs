using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PatronProductoConsumidor
{
    public class Pedidos
    {
        public int Id { get; }
        public string Nombre { get; }
        public string ProductoPedido { get; }
        public DateTime Fecha { get; }

        public Pedidos(int id, string nombre, string productoPedido)
        {
            Id = id;
            Nombre = nombre;
            ProductoPedido = productoPedido;
            Fecha = DateTime.Now;
        }
    }
}
