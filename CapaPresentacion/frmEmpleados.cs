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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

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
            limpiar_textos();

            refrescar_grid();

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
            gridViewEmpleados.Columns[13].Visible = false; // foto 

            if (!gridControlEmpleados.IsPrintingAvailable)
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
 
            //gridControlEmpleados.ShowPrintPreview();*/

            // Agrego Boton para seleccionar empleado de una fila y lo vinculo a un evento click para editar
            DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoItemBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            DevExpress.XtraGrid.Columns.GridColumn selColumn = gridViewEmpleados.Columns[0];
            gridViewEmpleados.GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoItemBtnEdit });
            repoItemBtnEdit.AllowMouseWheel = false;
            repoItemBtnEdit.AutoHeight = false;
            repoItemBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repoItemBtnEdit.Name = "repoItemBtnEdit";
            repoItemBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repoItemBtnEdit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK;
            repoItemBtnEdit.Buttons[1].Visible = false;
            repoItemBtnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Editar_ClickBoton);

            selColumn.ColumnEdit = repoItemBtnEdit;

        }

        private void refrescar_grid()
        {
            gridControlEmpleados.DataSource = NEmpleado.ListarEmpleados();
        }

        void Editar_ClickBoton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable empleado = NEmpleado.BuscarPorId((sender as ButtonEdit).EditValue.ToString());
            foreach (DataRow row in empleado.Rows)
            {
                this.txtId.Text = row["idempleado"].ToString();
                this.txtCedula.Text = row["ci_ruc"].ToString();
                this.txtNombres.Text = row["nombres"].ToString();
                this.txtApellidos.Text = row["apellidos"].ToString();
                this.cmbGenero.Text = row["sexo"].ToString();
                this.cmdEstadoCivil.Text = row["estado_civil"].ToString();
                this.dateFechaNacimiento.Text = row["fecha_nac"].ToString();
                this.txtTelefono.Text = row["telefono"].ToString();
                this.memoDireccion.Text = row["direccion"].ToString();
                //this.pctFoto.Image = row["foto"];
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar_textos();
        }

        private void limpiar_textos()
        {
            this.txtId.Text = null;
            this.txtCedula.Text = null;
            this.txtNombres.Text = null;
            this.txtApellidos.Text = null;
            this.cmbGenero.Text = null;
            this.cmdEstadoCivil.Text = null;
            this.dateFechaNacimiento.Text = null;
            this.txtTelefono.Text = null;
            this.memoDireccion.Text = null;
            this.pctFoto.Image = CapaPresentacion.Properties.Resources.no_image;
            this.txtCedula.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String[] mensaje;

            if (this.txtId.Text == string.Empty)
            {
                mensaje = NEmpleado.Insertar(this.txtNombres.Text, this.txtApellidos.Text, this.cmbGenero.Text, this.dateFechaNacimiento.Text,
                                             this.txtCedula.Text, this.memoDireccion.Text, this.txtTelefono.Text, this.txtEmail.Text);

                if (mensaje[0] == "Y") this.txtId.Text = mensaje[1];
            }
            else
            {
                mensaje = NEmpleado.Editar(this.txtNombres.Text, this.txtApellidos.Text, this.cmbGenero.Text, this.dateFechaNacimiento.Text,
                                           this.txtCedula.Text, this.memoDireccion.Text, this.txtTelefono.Text, this.txtEmail.Text, this.txtId.Text);
            }


            if (mensaje[0] == "Y")
            {
                refrescar_grid();
                Mensaje("Guardado con Exito");
            }
            else
            {
                MensajeError(mensaje[0]);
            }
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}