using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clases;

namespace WindowsFormsApp1
{
    public partial class Evaluacion_Prospectos : Form
    {

        conexionClass conexionClass = new conexionClass();
        int id = 0;

        public Evaluacion_Prospectos()
        {
            InitializeComponent();
        }

        private void dgvListaProspectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int id = int.Parse(dgvListaProspectos.Rows[dgvListaProspectos.CurrentRow.Index].Cells[0].Value.ToString());
                dgvdoc= conexionClass.ResibirDatosProspecto(id,dgvdoc);
            
                DataRow filaResultado=conexionClass.leerProspecto(id);
                txtNombre.Text=filaResultado[1].ToString();
                txtApellido1.Text=filaResultado[2].ToString();
                txtApellido2.Text=filaResultado[3].ToString();
                txtCalle.Text=filaResultado[4].ToString();
                txtNumero.Text=filaResultado[5].ToString();
                txtColonia.Text=filaResultado[6].ToString();
                txtCp.Text=filaResultado[7].ToString();
                txtTelefono.Text=filaResultado[8].ToString();
                txtRfc.Text=filaResultado[9].ToString();
                txtEstatus.Text=filaResultado[10].ToString();
                txtObservaciones.Text=filaResultado[11].ToString();   
        }

        private void Evaluacion_Prospectos_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            id = 1;
            cargarDatos();    
        }

        private void btnAprobado_Click(object sender, EventArgs e)
        {
            txtEstatus.Text = "Aprobado";
            txtObservaciones.Text = "";
            txtObservaciones.Enabled = false;
            btnActualizar.Enabled = true;
        }

        private void binRechazado_Click(object sender, EventArgs e)
        {
            txtObservaciones.Enabled = true;
            txtEstatus.Text = "Rechazado";
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtObservaciones.Text !="" ||txtEstatus.Text=="Aprobado")
            {
                 id = int.Parse(dgvListaProspectos.Rows[dgvListaProspectos.CurrentRow.Index].Cells[0].Value.ToString());

                conexionClass.ActualizarBD(id, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCalle.Text, txtNumero.Text, txtColonia.Text, long.Parse(txtCp.Text), long.Parse(txtTelefono.Text), txtRfc.Text, txtEstatus.Text, txtObservaciones.Text);
                cargarDatos();
            }
        }


        void cargarDatos()
        {
            string comand = "select * from tablaProspectos";
            conexionClass.Conexion.Open();

            SqlCommand cmd = new SqlCommand(comand, conexionClass.Conexion);
            SqlDataAdapter dataAda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAda.Fill(dt);
            dgvListaProspectos.DataSource = dt;
            conexionClass.Conexion.Close();
        }

        private void dgvdoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvdoc.Rows[dgvdoc.CurrentRow.Index].Cells[0].Value.ToString());
            conexionClass.mostrarDocumento(dgvdoc,id);
        
        }
    }
}
