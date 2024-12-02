using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PatronProductoConsumidor
{
    public class Productor
    {
        private readonly Cola<Pedidos> _cola;

        public Productor(Cola<Pedidos> cola)
        {
            _cola = cola;
        }

        public void CrearPedido(Pedidos pedidos)
        {
            _cola.Agregar(pedidos);
        }
    }
}
