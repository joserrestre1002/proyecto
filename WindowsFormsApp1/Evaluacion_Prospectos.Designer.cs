namespace WindowsFormsApp1
{
    partial class Evaluacion_Prospectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaProspectos = new System.Windows.Forms.DataGridView();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAprobado = new System.Windows.Forms.Button();
            this.binRechazado = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblOBservaciones = new System.Windows.Forms.Label();
            this.dgvdoc = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lnlEstatus = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProspectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProspectos
            // 
            this.dgvListaProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProspectos.Location = new System.Drawing.Point(12, 12);
            this.dgvListaProspectos.Name = "dgvListaProspectos";
            this.dgvListaProspectos.Size = new System.Drawing.Size(1253, 426);
            this.dgvListaProspectos.TabIndex = 0;
            this.dgvListaProspectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProspectos_CellClick);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(1271, 197);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(231, 126);
            this.txtObservaciones.TabIndex = 2;
            // 
            // btnAprobado
            // 
            this.btnAprobado.Location = new System.Drawing.Point(1271, 331);
            this.btnAprobado.Name = "btnAprobado";
            this.btnAprobado.Size = new System.Drawing.Size(106, 36);
            this.btnAprobado.TabIndex = 3;
            this.btnAprobado.Text = "Aprobado";
            this.btnAprobado.UseVisualStyleBackColor = true;
            this.btnAprobado.Click += new System.EventHandler(this.btnAprobado_Click);
            // 
            // binRechazado
            // 
            this.binRechazado.Location = new System.Drawing.Point(1383, 331);
            this.binRechazado.Name = "binRechazado";
            this.binRechazado.Size = new System.Drawing.Size(98, 36);
            this.binRechazado.TabIndex = 4;
            this.binRechazado.Text = "Rechazado";
            this.binRechazado.UseVisualStyleBackColor = true;
            this.binRechazado.Click += new System.EventHandler(this.binRechazado_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1271, 373);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(210, 66);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblOBservaciones
            // 
            this.lblOBservaciones.AutoSize = true;
            this.lblOBservaciones.Location = new System.Drawing.Point(1268, 184);
            this.lblOBservaciones.Name = "lblOBservaciones";
            this.lblOBservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblOBservaciones.TabIndex = 6;
            this.lblOBservaciones.Text = "Observaciones:";
            // 
            // dgvdoc
            // 
            this.dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoc.Location = new System.Drawing.Point(1271, 12);
            this.dgvdoc.Name = "dgvdoc";
            this.dgvdoc.Size = new System.Drawing.Size(231, 165);
            this.dgvdoc.TabIndex = 7;
            this.dgvdoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoc_CellClick);
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.Color.White;
            this.txtEstatus.Location = new System.Drawing.Point(1518, 420);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(138, 20);
            this.txtEstatus.TabIndex = 62;
            // 
            // lnlEstatus
            // 
            this.lnlEstatus.AutoSize = true;
            this.lnlEstatus.Location = new System.Drawing.Point(1515, 404);
            this.lnlEstatus.Name = "lnlEstatus";
            this.lnlEstatus.Size = new System.Drawing.Size(45, 13);
            this.lnlEstatus.TabIndex = 61;
            this.lnlEstatus.Text = "Estatus:";
            // 
            // txtRfc
            // 
            this.txtRfc.BackColor = System.Drawing.Color.White;
            this.txtRfc.Location = new System.Drawing.Point(1515, 369);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.ReadOnly = true;
            this.txtRfc.Size = new System.Drawing.Size(138, 20);
            this.txtRfc.TabIndex = 60;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(1512, 354);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(31, 13);
            this.lblRfc.TabIndex = 59;
            this.lblRfc.Text = "RFC:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(1515, 196);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(138, 20);
            this.txtNumero.TabIndex = 58;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(1512, 180);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 57;
            this.lblNumero.Text = "Numero:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(1512, 323);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1512, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Telefono:";
            // 
            // txtCp
            // 
            this.txtCp.BackColor = System.Drawing.Color.White;
            this.txtCp.Location = new System.Drawing.Point(1512, 281);
            this.txtCp.Name = "txtCp";
            this.txtCp.ReadOnly = true;
            this.txtCp.Size = new System.Drawing.Size(139, 20);
            this.txtCp.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1515, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Codigo Postal:";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Location = new System.Drawing.Point(1515, 240);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(138, 20);
            this.txtColonia.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1515, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Colonia:";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Location = new System.Drawing.Point(1512, 149);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.ReadOnly = true;
            this.txtCalle.Size = new System.Drawing.Size(139, 20);
            this.txtCalle.TabIndex = 50;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(1512, 134);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 49;
            this.lblCalle.Text = "Calle:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.White;
            this.txtApellido2.Location = new System.Drawing.Point(1515, 110);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(138, 20);
            this.txtApellido2.TabIndex = 48;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(1512, 92);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(92, 13);
            this.lblApellido2.TabIndex = 47;
            this.lblApellido2.Text = "Segundo apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.Location = new System.Drawing.Point(1515, 69);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(138, 20);
            this.txtApellido1.TabIndex = 46;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(1512, 50);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 13);
            this.lblApellido1.TabIndex = 45;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(1515, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(1512, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // Evaluacion_Prospectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 447);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.lnlEstatus);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.lblRfc);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvdoc);
            this.Controls.Add(this.lblOBservaciones);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.binRechazado);
            this.Controls.Add(this.btnAprobado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.dgvListaProspectos);
            this.Name = "Evaluacion_Prospectos";
            this.Text = "Evaluacion_Prospectos";
            this.Load += new System.EventHandler(this.Evaluacion_Prospectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProspectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProspectos;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAprobado;
        private System.Windows.Forms.Button binRechazado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblOBservaciones;
        private System.Windows.Forms.DataGridView dgvdoc;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lnlEstatus;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}