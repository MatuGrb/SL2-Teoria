namespace Proyecto1
{
    partial class FrmArtistas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            lstArtistas = new ListBox();
            label8 = new Label();
            btnGuardar = new Button();
            cbxDiscografica = new ComboBox();
            cbxNacionalidad = new ComboBox();
            nupAnioInicio = new NumericUpDown();
            txtNombreArtistico = new TextBox();
            txtNombreCompleto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btnDiscos = new Button();
            ((System.ComponentModel.ISupportInitialize)nupAnioInicio).BeginInit();
            SuspendLayout();
            // 
            // lstArtistas
            // 
            lstArtistas.FormattingEnabled = true;
            lstArtistas.ItemHeight = 15;
            lstArtistas.Location = new Point(11, 318);
            lstArtistas.Margin = new Padding(3, 2, 3, 2);
            lstArtistas.Name = "lstArtistas";
            lstArtistas.Size = new Size(505, 64);
            lstArtistas.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 290);
            label8.Name = "label8";
            label8.Size = new Size(189, 15);
            label8.TabIndex = 28;
            label8.Text = "Artistas agregados a la plataforma:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(369, 248);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 26);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxDiscografica
            // 
            cbxDiscografica.FormattingEnabled = true;
            cbxDiscografica.Items.AddRange(new object[] { "Sony", "Warner", "Otras" });
            cbxDiscografica.Location = new Point(223, 208);
            cbxDiscografica.Margin = new Padding(3, 2, 3, 2);
            cbxDiscografica.Name = "cbxDiscografica";
            cbxDiscografica.Size = new Size(294, 23);
            cbxDiscografica.TabIndex = 26;
            // 
            // cbxNacionalidad
            // 
            cbxNacionalidad.FormattingEnabled = true;
            cbxNacionalidad.Items.AddRange(new object[] { "Argentina", "Estados Unidos de Norteamérica", "Reino Unido", "España", "Italia", "Brasil" });
            cbxNacionalidad.Location = new Point(223, 173);
            cbxNacionalidad.Margin = new Padding(3, 2, 3, 2);
            cbxNacionalidad.Name = "cbxNacionalidad";
            cbxNacionalidad.Size = new Size(294, 23);
            cbxNacionalidad.TabIndex = 25;
            // 
            // nupAnioInicio
            // 
            nupAnioInicio.Location = new Point(223, 140);
            nupAnioInicio.Margin = new Padding(3, 2, 3, 2);
            nupAnioInicio.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nupAnioInicio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nupAnioInicio.Name = "nupAnioInicio";
            nupAnioInicio.Size = new Size(121, 23);
            nupAnioInicio.TabIndex = 24;
            nupAnioInicio.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // txtNombreArtistico
            // 
            txtNombreArtistico.Location = new Point(223, 106);
            txtNombreArtistico.Margin = new Padding(3, 2, 3, 2);
            txtNombreArtistico.Name = "txtNombreArtistico";
            txtNombreArtistico.Size = new Size(294, 23);
            txtNombreArtistico.TabIndex = 23;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(223, 72);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(294, 23);
            txtNombreCompleto.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 210);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 21;
            label7.Text = "Discográfica:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 176);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 20;
            label6.Text = "Nacionalidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 142);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 19;
            label5.Text = "Año de incio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 108);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 18;
            label4.Text = "Nombre artístico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 74);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 16;
            label2.Text = "Carga de datos de Artistas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 15;
            label1.Text = "Escuchify 1.1";
            // 
            // button1
            // 
            button1.Location = new Point(286, 393);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(230, 26);
            button1.TabIndex = 30;
            button1.Text = "Cargar un disco al artista";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDiscos
            // 
            btnDiscos.Location = new Point(50, 393);
            btnDiscos.Margin = new Padding(3, 2, 3, 2);
            btnDiscos.Name = "btnDiscos";
            btnDiscos.Size = new Size(230, 26);
            btnDiscos.TabIndex = 31;
            btnDiscos.Text = "Mirar los discos del artista";
            btnDiscos.UseVisualStyleBackColor = true;
            btnDiscos.Click += btnDiscos_Click;
            // 
            // FrmArtistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 433);
            Controls.Add(btnDiscos);
            Controls.Add(button1);
            Controls.Add(lstArtistas);
            Controls.Add(label8);
            Controls.Add(btnGuardar);
            Controls.Add(cbxDiscografica);
            Controls.Add(cbxNacionalidad);
            Controls.Add(nupAnioInicio);
            Controls.Add(txtNombreArtistico);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmArtistas";
            Text = "Gestión de artistas";
            Load += FrmArtistas_Load;
            ((System.ComponentModel.ISupportInitialize)nupAnioInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstArtistas;
        private Label label8;
        private Button btnGuardar;
        private ComboBox cbxDiscografica;
        private ComboBox cbxNacionalidad;
        private NumericUpDown nupAnioInicio;
        private TextBox txtNombreArtistico;
        private TextBox txtNombreCompleto;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btnDiscos;
    }
}
