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
        private Disco _DiscoAsociado;
        public FrmCanciones () {
            InitializeComponent();
        }

        public void setDisco (Disco unDisco) {
            try {
                _DiscoAsociado = unDisco;
                txtNombreCancion.Text = _DiscoAsociado.Nombre;
            } catch (Exception ex) {
                throw new Exception("No hay disco asociado");
            }
            
        }
    }
}
