using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            gridControlEmpleados.DataSource = NEmpleado.ListarEmpleados();
            gridViewEmpleados.Columns[0].Caption = "Id";
            gridViewEmpleados.Columns[1].Caption = "CI / RUC";
            gridViewEmpleados.Columns[2].Caption = "Nombres";
            gridViewEmpleados.Columns[3].Caption = "Apellidos";
            gridViewEmpleados.Columns[4].Caption = "Sexo";
            gridViewEmpleados.Columns[5].Caption = "Estado Civil";
            gridViewEmpleados.Columns[6].Caption = "Fecha Nacimiento";
            gridViewEmpleados.Columns[7].Caption = "Dirección";
            gridViewEmpleados.Columns[8].Caption = "Teléfono";
            gridViewEmpleados.Columns[9].Caption = "Email";
            gridViewEmpleados.Columns[10].Visible = false; //Acceso
            gridViewEmpleados.Columns[11].Visible = false; //Usuario
            gridViewEmpleados.Columns[12].Visible = false; //Clave
            gridViewEmpleados.Columns[13].Caption = "Foto"; 

            if (!gridControlEmpleados.IsPrintingAvailable)
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");

            //gridControlEmpleados.ShowPrintPreview();
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pctFoto.Image  = Image.FromFile(dlg.FileName); 
            }
            dlg.Dispose();
        }
    }
}