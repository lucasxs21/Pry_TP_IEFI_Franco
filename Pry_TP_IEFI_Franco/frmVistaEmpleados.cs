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
        
        

        public frmVistaEmpleados()
        {
            InitializeComponent();
            
        }
        BD objBD = new BD();
        private void Vista_Empleados_Load(object sender, EventArgs e)
        {
            objBD.CargarTreeView(tvEmpleados);
        }
        
        private void tvEmpleados_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string codEmpleado = e.Node.Text;
            rtbContenido.Clear();
            objBD.MostrarDatosPersonales(codEmpleado, rtbContenido);
            objBD.MostrarDatosLaborales(codEmpleado, rtbContenido);
            objBD.MostrarDatosAcademicos(codEmpleado, rtbContenido);

        }
    }
}
