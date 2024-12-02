namespace Demo_PatronProductoConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Pedidos> colaPedidos;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaPedidos = new Cola<Pedidos>(10);
            productor = new Productor(colaPedidos);
            consumidor = new Consumidor(colaPedidos);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            Pedidos nuevoPedido = new Pedidos(
           contadorId++,
           TxtNombreCliente.Text,
           TxtProducto.Text
          );

            ThreadPool.QueueUserWorkItem(
               state =>
               {
                   colaPedidos.Agregar(nuevoPedido);
               }
               );
            TxtNombreCliente.Clear();
            TxtProducto.Clear();

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarPedido);
            hiloConsumidor.Start();
        }
        public void ProcesarPedido()
        {
            Pedidos pedidos = colaPedidos.Extraer();
            AgregarUsuarioADataGrid(pedidos);

        }
        private void AgregarUsuarioADataGrid(Pedidos pedidos)
        {
            if (DgvPedidos.InvokeRequired)
            {
                DgvPedidos.Invoke(new Action(() =>
                {
                    DgvPedidos.Rows.Add(
                        pedidos.Id,
                        pedidos.Nombre,
                        pedidos.ProductoPedido,
                        pedidos.Fecha
                        );
                })
                );
            }
            else
            {
                DgvPedidos.Rows.Add(
                             pedidos.Id,
                        pedidos.Nombre,
                        pedidos.ProductoPedido,
                        pedidos.Fecha
                        );
            }
        }
    }
}
