namespace WindowsFormsApp1
{
    partial class ListaProspectosFrm
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
            this.button2 = new System.Windows.Forms.Button();
            this.dgvdoc = new System.Windows.Forms.DataGridView();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.dgvListaProspectos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Observacioneslbl = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lnlEstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProspectos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRfc
            // 
            this.txtRfc.BackColor = System.Drawing.Color.White;
            this.txtRfc.Location = new System.Drawing.Point(709, 367);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.ReadOnly = true;
            this.txtRfc.Size = new System.Drawing.Size(138, 20);
            this.txtRfc.TabIndex = 35;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(706, 351);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(31, 13);
            this.lblRfc.TabIndex = 34;
            this.lblRfc.Text = "RFC:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(709, 194);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(138, 20);
            this.txtNumero.TabIndex = 33;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(706, 178);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 32;
            this.lblNumero.Text = "Numero:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(706, 321);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefono:";
            // 
            // txtCp
            // 
            this.txtCp.BackColor = System.Drawing.Color.White;
            this.txtCp.Location = new System.Drawing.Point(706, 279);
            this.txtCp.Name = "txtCp";
            this.txtCp.ReadOnly = true;
            this.txtCp.Size = new System.Drawing.Size(139, 20);
            this.txtCp.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codigo Postal:";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Location = new System.Drawing.Point(709, 238);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(138, 20);
            this.txtColonia.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Colonia:";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Location = new System.Drawing.Point(706, 147);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.ReadOnly = true;
            this.txtCalle.Size = new System.Drawing.Size(139, 20);
            this.txtCalle.TabIndex = 25;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(706, 131);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 24;
            this.lblCalle.Text = "Calle:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.White;
            this.txtApellido2.Location = new System.Drawing.Point(709, 108);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(138, 20);
            this.txtApellido2.TabIndex = 23;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(706, 90);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(92, 13);
            this.lblApellido2.TabIndex = 22;
            this.lblApellido2.Text = "Segundo apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.Location = new System.Drawing.Point(709, 67);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(138, 20);
            this.txtApellido1.TabIndex = 21;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(706, 48);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 13);
            this.lblApellido1.TabIndex = 20;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(709, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(706, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 44);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvdoc
            // 
            this.dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoc.Location = new System.Drawing.Point(866, 25);
            this.dgvdoc.Name = "dgvdoc";
            this.dgvdoc.Size = new System.Drawing.Size(280, 189);
            this.dgvdoc.TabIndex = 37;
            this.dgvdoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoc_CellClick);
            // 
            // txtNotas
            // 
            this.txtNotas.BackColor = System.Drawing.Color.White;
            this.txtNotas.Location = new System.Drawing.Point(869, 243);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ReadOnly = true;
            this.txtNotas.Size = new System.Drawing.Size(280, 124);
            this.txtNotas.TabIndex = 38;
            // 
            // dgvListaProspectos
            // 
            this.dgvListaProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProspectos.Location = new System.Drawing.Point(12, 12);
            this.dgvListaProspectos.Name = "dgvListaProspectos";
            this.dgvListaProspectos.Size = new System.Drawing.Size(672, 379);
            this.dgvListaProspectos.TabIndex = 0;
            this.dgvListaProspectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProspectos_CellClick);
//            this.dgvListaProspectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProspectos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Documentos De Prospecto";
            // 
            // Observacioneslbl
            // 
            this.Observacioneslbl.AutoSize = true;
            this.Observacioneslbl.Location = new System.Drawing.Point(875, 222);
            this.Observacioneslbl.Name = "Observacioneslbl";
            this.Observacioneslbl.Size = new System.Drawing.Size(81, 13);
            this.Observacioneslbl.TabIndex = 40;
            this.Observacioneslbl.Text = "Observaciones:";
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.Color.White;
            this.txtEstatus.Location = new System.Drawing.Point(712, 418);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(138, 20);
            this.txtEstatus.TabIndex = 42;
            // 
            // lnlEstatus
            // 
            this.lnlEstatus.AutoSize = true;
            this.lnlEstatus.Location = new System.Drawing.Point(709, 402);
            this.lnlEstatus.Name = "lnlEstatus";
            this.lnlEstatus.Size = new System.Drawing.Size(45, 13);
            this.lnlEstatus.TabIndex = 41;
            this.lnlEstatus.Text = "Estatus:";
            // 
            // ListaProspectosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 464);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.lnlEstatus);
            this.Controls.Add(this.Observacioneslbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.dgvdoc);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.dgvListaProspectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaProspectosFrm";
            this.Text = "Lista De Prospectos";
            this.Load += new System.EventHandler(this.ListaProspectosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProspectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvdoc;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.DataGridView dgvListaProspectos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Observacioneslbl;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lnlEstatus;
    }
}