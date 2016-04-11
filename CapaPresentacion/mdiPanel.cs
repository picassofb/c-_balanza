using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using CapaNegocio;
using CapaDatos.Reportes;

namespace CapaPresentacion
{
    public partial class mdiPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public mdiPanel()
        {
            InitializeComponent();
        }

        private void bbtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bbtnEmpleadosG_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEmpleados FormEmpleados = new frmEmpleados();
            FormEmpleados.MdiParent = this;
            FormEmpleados.Show();
        }

        private void bbtnEmpleadosL_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Create a report. 
            xrptEmpleados reporteEmpleados = new xrptEmpleados();

            // Show the report's preview. 
            ReportPrintTool tool = new ReportPrintTool(reporteEmpleados);
            tool.PreviewForm.MdiParent = this;
            tool.PreviewForm.WindowState = FormWindowState.Maximized;
            tool.ShowPreview();
        }
    }
}