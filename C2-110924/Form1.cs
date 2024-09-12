namespace C2_110924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProducto = this.txtNombre.Text;
            int cantidadInicial = int.Parse(this.nupCantidad.Text); 

            Producto unProducto = new Producto(nombreProducto, cantidadInicial);

            ProductosController.GuardarProducto(unProducto);
        }
    }
}
