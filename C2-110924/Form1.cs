namespace C2_110924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sincronizarListado()
        {
            this.lstProductos.Items.Clear();
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                listaProductos = ProductosController.LeerProductos();
                foreach (var producto in listaProductos)
                {
                    this.lstProductos.Items.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error  en la lectura de productos.");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProducto = this.txtNombre.Text;
            string nombreProducto = this.txtNombre.Text;
            int cantidadInicial = int.Parse(this.nupCantidad.Text);

            Producto unProducto = new Producto(nombreProducto, cantidadInicial);

            ProductosController.GuardarProducto(unProducto);
            sincronizarListado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            sincronizarListado();
        }
    }
}
