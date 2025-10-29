using Proyecto1.Modelos;
using Proyecto1.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class FrmDiscos : Form
    {
        Form formularioAnterior;

        private Artista _artistaCargado;
        private List<Disco> _listaDiscos = new List<Disco>();

        public FrmDiscos(Form anterior)
        {
            InitializeComponent();
            formularioAnterior = anterior;
        }

        public void setArtista(Artista unArtista)
        {
            _artistaCargado = unArtista;
            txtNombreArtista.Text = _artistaCargado.NombreArtistico;
        }

        public void altaDisco()
        {
            lstDiscos.Hide();
        }

        public void verDiscos()
        {
            lstDiscos.Show();
            limpiarDatosEntrada();
            cargarListado(_artistaCargado.getID());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;
                //Comprobamos que los campos estén completos
                if (txtNombreDisco.Text == String.Empty || nupAnioPublicacion.Value == 0 || nupCantidadCanciones.Value == 0 || nupDuracionTotal.Value == 0 || cbxTipoDisco.SelectedItem == null)
                {
                    MessageBox.Show("Debe completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string nombre = txtNombreDisco.Text;
                int anioLanzamiento = (int)nupAnioPublicacion.Value;
                int cantidadCanciones = (int)nupCantidadCanciones.Value;
                int duracionTotal = (int)nupDuracionTotal.Value;
                string tipoDisco = cbxTipoDisco.SelectedItem.ToString();
                respuesta = ControladorDiscos.GuardarDisco(_artistaCargado, nombre, anioLanzamiento, duracionTotal, tipoDisco);
                if (respuesta)
                {
                    MessageBox.Show("Disco guardado correctamente, se ha creado un nuevo archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Disco guardado correctamente, se ha actualizado el archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiarDatosEntrada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDiscos_Load(object sender, EventArgs e)
        {
            ControladorDiscos.InicializarUltimoID();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarCancion_Click(object sender, EventArgs e)
        {
            if (this.lstDiscos.SelectedItems.Count > 0)
            {
                this.Hide(); //Ocultamos el formulario inicial de 
                FrmCanciones frmCanciones = new FrmCanciones(this); //Instanciamos el próximo formulario
                frmCanciones.setDisco((Disco)lstDiscos.SelectedItem);
                DialogResult resultado = frmCanciones.ShowDialog();
                if (resultado != DialogResult.Abort)
                {
                    this.Show();// Solo si no se eligió 'salir'
                }
                else
                {
                    Application.Exit();// O simplemente no hacer nada
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Disco", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarListado(int idArtista)
        {
            // Primero, limpiar la lista
            this.lstDiscos.Items.Clear();
            try
            {
                _listaDiscos = ControladorDiscos.ObtenerDiscos(idArtista);
                foreach (var disco in _listaDiscos)
                {
                    this.lstDiscos.Items.Add(disco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarDatosEntrada()
        {
            txtNombreDisco.Text = String.Empty;
            nupAnioPublicacion.Value = 1900;
            nupCantidadCanciones.Value = 1;
            nupDuracionTotal.Value = 1;
            cbxTipoDisco.SelectedItem = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
