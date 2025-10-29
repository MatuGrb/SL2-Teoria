using Proyecto1.Modelos;
using Proyecto1.Controladores;

namespace Proyecto1
{
    public partial class FrmArtistas : Form {

        private List<Artista> _listaArtistas = new List<Artista>();

        public FrmArtistas () {
            InitializeComponent();
        }


        private void btnGuardar_Click (object sender, EventArgs e) {
            // se toman los datos cargados en la UI
            string nombreCompleto = txtNombreCompleto.Text;
            string nombreArtistico = txtNombreArtistico.Text;
            int anioInicio = (int)nupAnioInicio.Value;
            string nacionalidad = String.Empty;
            if (cbxNacionalidad.SelectedItem.ToString() != String.Empty) {
                nacionalidad = cbxNacionalidad.SelectedItem.ToString();
            }
            string discografica = String.Empty;
            if (cbxDiscografica.SelectedItem.ToString() != String.Empty) {
                discografica = cbxDiscografica.SelectedItem.ToString();
            }
            ControladorArtistas.GuardarArtista(nombreCompleto, nombreArtistico, anioInicio, nacionalidad, discografica);
            cargarListado();
            limpiarDatosEntrada();
        }

        private void FrmArtistas_Load (object sender, EventArgs e) {
            cargarListado();
            ControladorArtistas.InicializarUltimoID();
        }
        private void cargarListado () {
            // Primero, limpiar la lista
            this.lstArtistas.Items.Clear();
            try {
                _listaArtistas = ControladorArtistas.ObternerArtistas();
                foreach (var artista in _listaArtistas) {
                    int cantidadDiscos = ControladorArtistas.CantidadDiscos(artista.getID());
                    artista.setCantidadDiscos(cantidadDiscos);
                    this.lstArtistas.Items.Add(artista);
                }
            } catch (Exception ex) {
                MessageBox.Show("No hay artistas cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarDatosEntrada () {
            txtNombreCompleto.Clear();
            txtNombreArtistico.Clear();
            nupAnioInicio.Value = 1900;
            cbxNacionalidad.SelectedIndex = -1;
            cbxDiscografica.SelectedIndex = -1;
        }

        private void btnDiscos_Click (object sender, EventArgs e) {
            if (this.lstArtistas.SelectedItems.Count > 0) {
                this.Hide(); //Ocultamos el formulario inicial de 
                FrmDiscos frmDiscos = new FrmDiscos(this); //Instanciamos el próximo formulario
                frmDiscos.setArtista((Artista)lstArtistas.SelectedItem);
                frmDiscos.altaDisco();
                DialogResult resultado = frmDiscos.ShowDialog();
                if (resultado != DialogResult.Abort) {
                    this.Show();// Solo si no se eligió 'salir'
                } else {
                    Application.Exit();// O simplemente no hacer nada
                }
                cargarListado();
                limpiarDatosEntrada();
            } else {
                MessageBox.Show("Debe seleccionar un Artista", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
