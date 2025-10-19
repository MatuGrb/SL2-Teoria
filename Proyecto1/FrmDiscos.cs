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
    public partial class FrmDiscos : Form {
        Form formularioAnterior;

        private Artista _artistaCargado;

        public FrmDiscos (Form anterior) {
            InitializeComponent();
            formularioAnterior = anterior;
        }

        public void setArtista (Artista unArtista) {
            _artistaCargado = unArtista;
            txtNombreArtista.Text = _artistaCargado.NombreArtistico;
        }

        private void label2_Click (object sender, EventArgs e) {

        }

        private void btnGuardar_Click (object sender, EventArgs e) {
            string nombre = txtNombreDisco.Text;
            int anioLanzamiento = (int)nupAnioPublicacion.Value;
            int cantidadCanciones = (int)nupCantidadCanciones.Value;
            int duracionTotal = (int)nupDuracionTotal.Value;
            string tipoDisco = cbxTipoDisco.SelectedText;
            ControladorDiscos.GuardarDisco(_artistaCargado, nombre, anioLanzamiento, cantidadCanciones, duracionTotal, tipoDisco);
        }

        private void FrmDiscos_Load (object sender, EventArgs e) {

        }

        private void btnVolver_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
