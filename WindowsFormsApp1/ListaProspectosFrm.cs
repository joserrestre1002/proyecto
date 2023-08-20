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
    public partial class ListaProspectosFrm : Form
    {

          conexionClass conexionClass = new conexionClass();

       
        public ListaProspectosFrm()
        {
            InitializeComponent();
        }

        private void ListaProspectosFrm_Load(object sender, EventArgs e)
        {
            conexionClass conexion = new conexionClass();
            dgvListaProspectos=conexion.Refresh(dgvListaProspectos);
        }


        private void dgvdoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvdoc.Rows[dgvdoc.CurrentRow.Index].Cells[0].Value.ToString());
            conexionClass.mostrarDocumento(dgvdoc,id);

        }

        private void dgvListaProspectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvListaProspectos.Rows[dgvListaProspectos.CurrentRow.Index].Cells[0].Value.ToString());
            conexionClass.ResibirDatosProspecto(id,dgvdoc);

                DataRow filaResultado= conexionClass.leerProspecto(id);
                txtNombre.Text = filaResultado[1].ToString();
                txtApellido1.Text=filaResultado[2].ToString();
                txtApellido2.Text = filaResultado[3].ToString();
                txtCalle.Text = filaResultado[4].ToString();
                txtNumero.Text=filaResultado[5].ToString();
                txtColonia.Text = filaResultado[6].ToString();
                txtCp.Text = filaResultado[7].ToString();
                txtTelefono.Text = filaResultado[8].ToString();
                txtRfc.Text = filaResultado[9].ToString();
                txtEstatus.Text = filaResultado[10].ToString();
                txtNotas.Text = filaResultado[11].ToString();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
