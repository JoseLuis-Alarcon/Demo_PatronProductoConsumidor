using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PatronProductoConsumidor
{
    public class Consumidor
    {
        private readonly Cola<Pedidos> _cola;

        public Consumidor(Cola<Pedidos> cola)
        {
            _cola = cola;
        }

        public Pedidos ProcesarPedido()
        {
            return _cola.Extraer();
        }
    }
}
