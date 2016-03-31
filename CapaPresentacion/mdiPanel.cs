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
    }
}