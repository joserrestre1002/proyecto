using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1.clases
{
    internal class conexionClass
    {
        //hola
        static private string CadenaConexion = "Server=PC-MASTER-RACE;DataBase=CRUD;Integrated Security=true";
        public SqlConnection Conexion = new SqlConnection(CadenaConexion);



        public DataGridView Refresh(DataGridView tabla)
        {
            using (Model.EntidadCRUDP db = new Model.EntidadCRUDP())
            {
                var lst = from d in db.tablaProspectos select new { d.Id, d.Nombre, d.Primer_Apellido, d.Segundo_Apellido, d.Estatus, d.Notas };
                tabla.DataSource = lst.ToList();
            }

            return tabla;
        }

        public int ObtenerId()
        {
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("select max(id) from tablaProspectos", Conexion);

            SqlDataAdapter dataAda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAda.Fill(dt);
            int id = (int)dt.Rows[0][0];
            Conexion.Close();
            return id;
        }

        
        public DataRow leerProspecto(int id)
        {
            Conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_readP", Conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            DataSet ds = new DataSet();
            ds.Clear();
            dataAdapter.Fill(ds);
            DataTable dataTable =ds.Tables[0];
            DataRow dataRow = dataTable.Rows[0];
            Conexion.Close();
            return dataRow;
        }


        public void ActualizarBD(int id, string nombre, string apellido1, string apellido2, string calle, string numero, string colonia, long cp,long telefono, string rfc, string estatus, string notas)
        {

            SqlCommand cmd = new SqlCommand("sp_updateP", Conexion);
            Conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Nombre",SqlDbType.VarChar).Value= nombre;
            cmd.Parameters.Add("@ApellidoUno",SqlDbType.VarChar).Value = apellido1;
            cmd.Parameters.Add("@ApellidoDos", SqlDbType.VarChar).Value = apellido2;
            cmd.Parameters.Add("@Calle", SqlDbType.VarChar).Value = calle;
            cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = numero;
            cmd.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = colonia;
            cmd.Parameters.Add("@CodigoPostal", SqlDbType.BigInt).Value = cp;
            cmd.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = telefono;
            cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = rfc;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = estatus;
            
            cmd.Parameters.Add("@Notas", SqlDbType.VarChar).Value = notas;
            cmd.ExecuteNonQuery();
            Conexion.Close();

            
        }


       public void mostrarDocumento(DataGridView dgvdoc, int id)
        {
            if (dgvdoc.Rows.Count > 0)
            {
                

                using (Model.EntidadCRUDP db = new Model.EntidadCRUDP())
                {
                    var oArchivos = db.documentos.Find(id);
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullfilepath = folder + oArchivos.Nombre;

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    if (File.Exists(fullfilepath))
                    {
                        // Directory.Delete(fullfilepath);
                    }

                    File.WriteAllBytes(fullfilepath, oArchivos.Archivo);
                    Process.Start(fullfilepath);
                }
            }
       }

        public DataGridView ResibirDatosProspecto(int id, DataGridView dgvdoc)
        {
            using (Model.EntidadCRUDP db = new Model.EntidadCRUDP())
            {


                
                string comand = "select id, Nombre from documentos where idProspecto=" + id.ToString();
                Conexion.Open();
                SqlCommand cmd = new SqlCommand(comand, Conexion);

                SqlDataAdapter dataAda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAda.Fill(dt);
                dgvdoc.DataSource = dt;
                Conexion.Close();
            }

            return dgvdoc;
        }

    }
}
