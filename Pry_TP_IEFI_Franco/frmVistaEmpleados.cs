using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace Pry_TP_IEFI_Franco
{
    public partial class frmVistaEmpleados : Form
    {
        private const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = EMPLEO.accdb";
        

        public frmVistaEmpleados()
        {
            InitializeComponent();
            CargarDatosTreeView();
        }

        private void Vista_Empleados_Load(object sender, EventArgs e)
        {

        }
        

        private void CargarDatosTreeView()
        {
            tvEmpleados.Nodes.Clear();

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT * FROM DATOS PERSONALES";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string codigoEmpleado = reader["CODIGO"].ToString();
                    string nombre = reader["NOMBRE"].ToString();
                    string cargo = reader["aPELLIDO"].ToString();
                    string gradoAcademico = reader["GradoAcademico"].ToString();

                    TreeNode nodoEmpleado = new TreeNode($"{codigoEmpleado} - {nombre}");
                    nodoEmpleado.Tag = $"{codigoEmpleado} - {nombre}\nCargo: {cargo}\nGrado Académico: {gradoAcademico}";

                    tvEmpleados.Nodes.Add(nodoEmpleado);
                }

                conexion.Close();
            }
        }

        private void tvEmpleados_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string detalles = e.Node.Tag.ToString();
            rtbContenido.Text = detalles;
        }
    }
}
