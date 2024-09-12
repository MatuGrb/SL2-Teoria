namespace C2_110924
{
    partial class Form1
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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            nupCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label4 = new Label();
            btnAgregar = new Button();
            nupCantidadMovimineto = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            cbxTipoMovimiento = new ComboBox();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestión de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 85);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 130);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 2;
            label3.Text = "Cantidad disponible:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(271, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 34);
            txtNombre.TabIndex = 3;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(271, 130);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(246, 34);
            nupCantidad.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(cbxTipoMovimiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nupCantidadMovimineto);
            groupBox1.Location = new Point(15, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 145);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de movimientos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(13, 214);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 88);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 171);
            label4.Name = "label4";
            label4.Size = new Size(201, 28);
            label4.TabIndex = 7;
            label4.Text = "Listado de productos:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(575, 78);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(190, 42);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nupCantidadMovimineto
            // 
            nupCantidadMovimineto.Location = new Point(228, 45);
            nupCantidadMovimineto.Name = "nupCantidadMovimineto";
            nupCantidadMovimineto.Size = new Size(150, 34);
            nupCantidadMovimineto.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 47);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 9;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 91);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 10;
            label6.Text = "Tipo movimiento:";
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "AGREGAR", "QUITAR" });
            cbxTipoMovimiento.Location = new Point(228, 88);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(150, 36);
            cbxTipoMovimiento.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(560, 40);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(190, 42);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar stock";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 488);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(nupCantidad);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private NumericUpDown nupCantidad;
        private GroupBox groupBox1;
        private Button btnModificar;
        private ComboBox cbxTipoMovimiento;
        private Label label6;
        private Label label5;
        private NumericUpDown nupCantidadMovimineto;
        private ListBox listBox1;
        private Label label4;
        private Button btnAgregar;
    }
}
