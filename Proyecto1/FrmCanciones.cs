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
    public partial class FrmCanciones : Form {
        private List<Cancion> _listaCancion = new List<Cancion>();
        private Disco _DiscoAsociado;
        Form formularioAnterior;
        public FrmCanciones (Form anterior) {
            InitializeComponent();
            this.formularioAnterior = anterior;
        }

        public void setDisco (Disco unDisco) {
            try {
                _DiscoAsociado = unDisco;
                txtNombreCancion.Text = _DiscoAsociado.Nombre;
            } catch (Exception ex) {
                MessageBox.Show("No hay disco asociado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnVolver_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardar_Click (object sender, EventArgs e) {
            try {
                // se toman los datos cargados en la UI
                string nombreCancion = txtNombreCancion.Text;
                int anioInicio = (int)nupAnioPublicacion.Value;
                int duracion = (int)nupDuracionSeg.Value;
                ControladorCanciones.GuardarCancion(nombreCancion, anioInicio, duracion, _DiscoAsociado);
                cargarListado();
                limpiarDatosEntrada();
            }catch {
                MessageBox.Show("Ocurrió un error al guardar la cancion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void cargarListado () {
            // Primero, limpiar la lista
            this.lstCanciones.Items.Clear();
            try {
                _listaCancion = ControladorCanciones.ObtenerCanciones();
                foreach (var cancion in _listaCancion) {
                    this.lstCanciones.Items.Add(cancion);
                }
            } catch (Exception ex) {
                MessageBox.Show("No hay canciones cargadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarDatosEntrada () {
            txtNombreCancion.Clear();
            nupAnioPublicacion.Value = 1900;
            nupDuracionSeg.Value = 1500;
        }
    }
}
