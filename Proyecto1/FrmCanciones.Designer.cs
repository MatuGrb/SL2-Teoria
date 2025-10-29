namespace Proyecto1 {
    partial class FrmCanciones {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nupDuracionSeg = new NumericUpDown();
            label7 = new Label();
            btnGuardar = new Button();
            nupAnioPublicacion = new NumericUpDown();
            txtNombreCancion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            txtDisco = new TextBox();
            lstCanciones = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupDuracionSeg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAnioPublicacion).BeginInit();
            SuspendLayout();
            // 
            // nupDuracionSeg
            // 
            nupDuracionSeg.Location = new Point(291, 217);
            nupDuracionSeg.Margin = new Padding(3, 4, 3, 4);
            nupDuracionSeg.Maximum = new decimal(new int[] { 5400, 0, 0, 0 });
            nupDuracionSeg.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            nupDuracionSeg.Name = "nupDuracionSeg";
            nupDuracionSeg.Size = new Size(158, 27);
            nupDuracionSeg.TabIndex = 63;
            nupDuracionSeg.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 220);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 62;
            label7.Text = "Duración total:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(482, 316);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 47);
            btnGuardar.TabIndex = 59;
            btnGuardar.Text = "&Cargar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nupAnioPublicacion
            // 
            nupAnioPublicacion.Location = new Point(291, 165);
            nupAnioPublicacion.Margin = new Padding(3, 4, 3, 4);
            nupAnioPublicacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nupAnioPublicacion.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nupAnioPublicacion.Name = "nupAnioPublicacion";
            nupAnioPublicacion.Size = new Size(158, 27);
            nupAnioPublicacion.TabIndex = 57;
            nupAnioPublicacion.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // txtNombreCancion
            // 
            txtNombreCancion.Location = new Point(291, 113);
            txtNombreCancion.Margin = new Padding(3, 4, 3, 4);
            txtNombreCancion.Name = "txtNombreCancion";
            txtNombreCancion.Size = new Size(383, 27);
            txtNombreCancion.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 273);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 54;
            label6.Text = "Disco relacionado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 168);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 53;
            label5.Text = "Año de publicación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 117);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 52;
            label4.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(205, 20);
            label2.TabIndex = 50;
            label2.Text = "Carga de datos de Canciones:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 24);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 49;
            label9.Text = "Escuchify 1.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(456, 220);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 64;
            label1.Text = "(Segundos)";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(282, 317);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(193, 47);
            btnVolver.TabIndex = 65;
            btnVolver.Text = "&Regresar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDisco
            // 
            txtDisco.Location = new Point(291, 263);
            txtDisco.Margin = new Padding(3, 4, 3, 4);
            txtDisco.Name = "txtDisco";
            txtDisco.ReadOnly = true;
            txtDisco.Size = new Size(383, 27);
            txtDisco.TabIndex = 66;
            // 
            // lstCanciones
            // 
            lstCanciones.FormattingEnabled = true;
            lstCanciones.Location = new Point(81, 412);
            lstCanciones.Name = "lstCanciones";
            lstCanciones.Size = new Size(577, 104);
            lstCanciones.TabIndex = 67;
            lstCanciones.SelectedIndexChanged += lstCanciones_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 389);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 68;
            label3.Text = "Lista de Canciones cargadas:";
            // 
            // FrmCanciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 534);
            Controls.Add(label3);
            Controls.Add(lstCanciones);
            Controls.Add(txtDisco);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(nupDuracionSeg);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(nupAnioPublicacion);
            Controls.Add(txtNombreCancion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCanciones";
            Text = "FrmCanciones";
            Load += FrmCanciones_Load;
            ((System.ComponentModel.ISupportInitialize)nupDuracionSeg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAnioPublicacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nupDuracionSeg;
        private Label label7;
        private Button btnGuardar;
        private NumericUpDown nupAnioPublicacion;
        private TextBox txtNombreCancion;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label label1;
        private Button btnVolver;
        private TextBox txtDisco;
        private ListBox lstCanciones;
        private Label label3;
    }
}