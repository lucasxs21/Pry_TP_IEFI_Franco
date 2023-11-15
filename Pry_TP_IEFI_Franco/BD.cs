using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Pry_TP_IEFI_Franco
{
    internal class BD
    {
        string rutaArchivo;
        string cadenaConexion;
       
        OleDbCommand cmd;     
        OleDbDataReader rdr;

        public BD()
        {
            rutaArchivo = @"../../Base/EMPLEO.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

        }
        public void CargarTreeView(System.Windows.Forms.TreeView tv)
        {

            using (OleDbConnection connection = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CODIGO FROM [DATOS PERSONALES]";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "DATOS PERSONALES");

                    foreach (DataRow row in dataSet.Tables["DATOS PERSONALES"].Rows)
                    {
                        string codigo = row["CODIGO"].ToString();
                        TreeNode newNode = new TreeNode(codigo);
                        tv.Nodes.Add(newNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        public void MostrarDatosPersonales(string empleado, RichTextBox rtb)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(cadenaConexion);
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [DATOS PERSONALES] WHERE CODIGO = @codigo";
                cmd.Parameters.AddWithValue("@codigo", empleado);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    rtb.Text += "DATOS PERSONALES\n\n" +
                                $"Nombre: {rdr["NOMBRE"]}\n" +
                                $"Apellido: {rdr["APELLIDO"]}\n" +
                                $"Dirección: {rdr["DIRECCIÒN"]}\n" +
                                $"Ciudad: {rdr["CIUDAD"]}\n" +
                                $"Teléfono: {rdr["TELEFONO"]}\n" +
                                $"Fecha de Nacimiento: {rdr["FECHA_NACIMIENTO"]}\n\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public void MostrarDatosLaborales(string empleado, RichTextBox rtb)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(cadenaConexion);
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [DATOS LABORALES] WHERE CODIGO = @codigo";
                cmd.Parameters.AddWithValue("@codigo", empleado);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    rtb.Text += "DATOS LABORALES\n\n" +
                                $"Años/Experiencia: {rdr["AÑOS/EXPERIENCIA"]}\n" +
                                $"Ultimo lugar de trabajo: {rdr["ULTIMO LUGAR DE TRABAJO"]}\n" +
                                $"Cargo desempeñado: {rdr["CARGO DESEMPENADO"]}\n" +
                                $"Remuneracion: {rdr["REMUNERACION"]}\n\n";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }


        public void MostrarDatosAcademicos(string empleado, RichTextBox rtb)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(cadenaConexion);
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [DATOS ACADEMICOS] WHERE CODIGO = @codigo";
                cmd.Parameters.AddWithValue("@codigo", empleado);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    rtb.Text += "DATOS ACADEMICOS\n\n" +
                                $"Cursos que recibio: {rdr["CURSOS QUE RECIBIO"]}\n" +
                                $"Horas/Estudio: {rdr["HORAS/ESTUDIO"]}\n" +
                                $"Lugar de Estudio: {rdr["LUGAR DE ESTUDIO"]}\n\n";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

    }
}
