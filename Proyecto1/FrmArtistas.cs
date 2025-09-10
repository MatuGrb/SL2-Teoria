using Proyecto1.Modelos;

namespace Proyecto1
{
    public partial class FrmArtistas : Form
    {
        public FrmArtistas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // se toman los datos cargados en la UI
            string nombreCompleto = txtNombreCompleto.Text;
            string nombreArtistico = txtNombreArtistico.Text;
            int anioInicio = (int)nupAnioInicio.Value;
            string nacionalidad = String.Empty;
            if (cbxNacionalidad.SelectedItem.ToString() != String.Empty)
            {
                nacionalidad = cbxNacionalidad.SelectedItem.ToString();
            }
            string discografica = String.Empty;
            if (cbxDiscografica.SelectedText.ToString() != String.Empty)
            {
                discografica = cbxDiscografica.SelectedItem.ToString();
            }
            
        }
    }
}
