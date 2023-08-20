namespace WindowsFormsApp1
{
    partial class CrearProspectoFrm
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(60, 497);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(60, 51);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 13);
            this.lblApellido1.TabIndex = 2;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(60, 453);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 23);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(63, 70);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(138, 20);
            this.txtApellido1.TabIndex = 3;
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(63, 400);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(125, 13);
            this.lblArchivos.TabIndex = 19;
            this.lblArchivos.Text = "Nombre de Documentos:";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(60, 93);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(92, 13);
            this.lblApellido2.TabIndex = 4;
            this.lblApellido2.Text = "Segundo apellido:";
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Location = new System.Drawing.Point(63, 416);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(136, 22);
            this.btnDocumentos.TabIndex = 18;
            this.btnDocumentos.Text = "+";
            this.btnDocumentos.UseVisualStyleBackColor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(63, 111);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(138, 20);
            this.txtApellido2.TabIndex = 5;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(63, 370);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(138, 20);
            this.txtRfc.TabIndex = 17;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(60, 134);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle:";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(60, 354);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(31, 13);
            this.lblRfc.TabIndex = 16;
            this.lblRfc.Text = "RFC:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(60, 150);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(139, 20);
            this.txtCalle.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(63, 197);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(138, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colonia:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(60, 181);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(63, 241);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(138, 20);
            this.txtColonia.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(60, 324);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono:";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(60, 282);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(139, 20);
            this.txtCp.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lista De Prospectos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.Location = new System.Drawing.Point(221, 28);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Size = new System.Drawing.Size(139, 51);
            this.btnEvaluacion.TabIndex = 22;
            this.btnEvaluacion.Text = "Evaluacion De Prospectos";
            this.btnEvaluacion.UseVisualStyleBackColor = true;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // CrearProspectoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 593);
            this.Controls.Add(this.btnEvaluacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDocumentos);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.lblRfc);
            this.Controls.Add(this.lblCalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrearProspectoFrm";
            this.Text = "Agregar Prospecto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEvaluacion;
    }
}

