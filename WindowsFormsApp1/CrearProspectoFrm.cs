using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApp1.clases;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{


    public partial class CrearProspectoFrm : Form
    {

        conexionClass conexionClass = new conexionClass();
        string[] ArregloN = { };

        string[] FNames;
       
        public CrearProspectoFrm()
        {
            InitializeComponent();
            openFileDialog1.Title = "Documentos de prospecto";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "c:\\";
           
            openFileDialog1.FilterIndex =1;
            this.openFileDialog1.Multiselect = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ArregloN= openFileDialog1.SafeFileNames;
                FNames = openFileDialog1.FileNames;

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            byte[][] file = { };
            try
            {
                 file = new byte[FNames.Length][];
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se selecciono ningun archivo");
                return;
            }
            

            int index = 0;
            int id = 0;
            Model.tablaProspecto oDocument = new Model.tablaProspecto();
           
            using (Model.EntidadCRUDP db = new Model.EntidadCRUDP())
            {

                
               
                

                oDocument.Nombre = txtNombre.Text.Trim();
                oDocument.Primer_Apellido = txtApellido1.Text.Trim();
                oDocument.Segundo_Apellido = txtApellido2.Text.Trim();
                oDocument.Calle = txtCalle.Text.Trim();
                oDocument.Numero = txtNumero.Text.Trim();
                oDocument.Colonia = txtColonia.Text.Trim();
                oDocument.Codigo_Postal = long.Parse(txtCp.Text); 
                oDocument.Telefono = long.Parse(txtTelefono.Text);
                oDocument.RFC = txtRfc.Text.Trim();
                oDocument.Estatus = "Enviado";
                oDocument.Notas = "";
                db.tablaProspectos.Add(oDocument);
                db.SaveChanges();
                id=conexionClass.ObtenerId();


            }

            foreach (string ruta in openFileDialog1.FileNames)
            {
               
                openFileDialog1.FileName = ruta;
                Stream mystream = openFileDialog1.OpenFile();
               
                using (MemoryStream ms = new MemoryStream())
                {
                    mystream.CopyTo(ms);
                    file[index] =ms.ToArray();
                    index++;  
                }

                using (Model.EntidadCRUDP tablaDocumentos = new Model.EntidadCRUDP())
                {
                    Model.documento tablaBD = new Model.documento();

                    tablaBD.Id = index;
                    tablaBD.Nombre = openFileDialog1.SafeFileName;
                    tablaBD.Archivo = file[index-1];
                    tablaBD.idProspecto = id;
                    tablaDocumentos.documentos.Add(tablaBD);
                    tablaDocumentos.SaveChanges();
                    
                }
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaProspectosFrm frm2 = new ListaProspectosFrm();
            frm2.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (txtApellido1.Text != "" || txtApellido2.Text != "" || txtCalle.Text != "" || txtNombre.Text != "" || txtColonia.Text != "" || txtCp.Text != ""||txtNumero.Text !="" || txtTelefono.Text !="" || txtRfc.Text!="")
            {
                string message="si cierras el programa perderas los datos no enviados";
                string caption = "Cuidado!";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message,caption,buttons);

                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            Evaluacion_Prospectos frmEvaluacion = new Evaluacion_Prospectos();
            frmEvaluacion.Show();
        }
    }
}
