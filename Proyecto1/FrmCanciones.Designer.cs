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
        private void InitializeComponent () {
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
            ((System.ComponentModel.ISupportInitialize)nupDuracionSeg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAnioPublicacion).BeginInit();
            SuspendLayout();
            // 
            // nupDuracionSeg
            // 
            nupDuracionSeg.Location = new Point(255, 163);
            nupDuracionSeg.Maximum = new decimal(new int[] { 5400, 0, 0, 0 });
            nupDuracionSeg.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            nupDuracionSeg.Name = "nupDuracionSeg";
            nupDuracionSeg.Size = new Size(138, 23);
            nupDuracionSeg.TabIndex = 63;
            nupDuracionSeg.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 165);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 62;
            label7.Text = "Duración total:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(422, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 35);
            btnGuardar.TabIndex = 59;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nupAnioPublicacion
            // 
            nupAnioPublicacion.Location = new Point(255, 124);
            nupAnioPublicacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nupAnioPublicacion.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nupAnioPublicacion.Name = "nupAnioPublicacion";
            nupAnioPublicacion.Size = new Size(138, 23);
            nupAnioPublicacion.TabIndex = 57;
            nupAnioPublicacion.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // txtNombreCancion
            // 
            txtNombreCancion.Location = new Point(255, 85);
            txtNombreCancion.Name = "txtNombreCancion";
            txtNombreCancion.Size = new Size(336, 23);
            txtNombreCancion.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 205);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 54;
            label6.Text = "Disco relacionado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 126);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 53;
            label5.Text = "Año de publicación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 88);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 52;
            label4.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 50;
            label2.Text = "Carga de datos de Canciones:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 18);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 21);
            label9.TabIndex = 49;
            label9.Text = "Escuchify 1.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 165);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 64;
            label1.Text = "(Segundos)";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(247, 246);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(169, 35);
            btnVolver.TabIndex = 65;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDisco
            // 
            txtDisco.Location = new Point(255, 197);
            txtDisco.Name = "txtDisco";
            txtDisco.ReadOnly = true;
            txtDisco.Size = new Size(336, 23);
            txtDisco.TabIndex = 66;
            // 
            // lstCanciones
            // 
            lstCanciones.FormattingEnabled = true;
            lstCanciones.ItemHeight = 15;
            lstCanciones.Location = new Point(71, 297);
            lstCanciones.Margin = new Padding(3, 2, 3, 2);
            lstCanciones.Name = "lstCanciones";
            lstCanciones.Size = new Size(505, 64);
            lstCanciones.TabIndex = 67;
            // 
            // FrmCanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 374);
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
            Name = "FrmCanciones";
            Text = "FrmCanciones";
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
    }
}