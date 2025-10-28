using Proyecto1.Controladores;
using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1 {
    public partial class FrmCanciones : Form
    {
        Form formularioAnterior;

        private Disco _discoAsociado;
        private List<Cancion> _listaCancion = new List<Cancion>();
        public FrmCanciones(Form anterior)
        {
            InitializeComponent();
            this.formularioAnterior = anterior;
        }

        public void setDisco(Disco unDisco)
        {
            try
            {
                _discoAsociado = unDisco;
                txtDisco.Text = _discoAsociado.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay disco asociado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;

                // Verificación de campos completos
                if (txtNombreCancion.Text == String.Empty || nupAnioPublicacion.Value == 0 || nupDuracionSeg.Value == 0)
                {
                    MessageBox.Show("Debe completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (nupAnioPublicacion.Value < 1900 || nupAnioPublicacion.Value > DateTime.Now.Year)
                {
                    MessageBox.Show("El año de publicación debe estar entre 1900 y el año actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // se toman los datos cargados en la UI
                string nombreCancion = txtNombreCancion.Text;
                int anioInicio = (int)nupAnioPublicacion.Value;
                int duracion = (int)nupDuracionSeg.Value;

                respuesta = ControladorCanciones.GuardarCancion(nombreCancion, anioInicio, duracion, _discoAsociado);
                if (respuesta == true)
                {
                    MessageBox.Show("Canción guardada correctamente, se ha creado un nuevo archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Canción guardada correctamente, se ha actualizado el archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cargarListado();
                limpiarDatosEntrada();
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al guardar la cancion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cargarListado()
        {
            // Primero, limpiar la lista
            this.lstCanciones.Items.Clear();
            try
            {
                _listaCancion = ControladorCanciones.ObtenerCanciones(_discoAsociado.getID());
                foreach (var cancion in _listaCancion)
                {
                    this.lstCanciones.Items.Add(cancion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay canciones cargadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarDatosEntrada()
        {
            txtNombreCancion.Clear();
            nupAnioPublicacion.Value = 1900;
            nupDuracionSeg.Value = 1500;
            txtNombreCancion.Focus();
        }

        private void FrmCanciones_Load(object sender, EventArgs e)
        {
            ControladorCanciones.InicializarUltimoID();
        }
    }
}
