namespace CapaPresentacion
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnBuscarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.cmdEstadoCivil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.cmbGenero = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlEmpleados = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEstadoCivil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGenero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1048, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.btnEliminar);
            this.panelControl2.Controls.Add(this.btnGuardar);
            this.panelControl2.Controls.Add(this.btnNuevo);
            this.panelControl2.Location = new System.Drawing.Point(7, 6);
            this.panelControl2.LookAndFeel.SkinName = "VS2010";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(188, 44);
            this.panelControl2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(118, 4);
            this.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnEliminar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEliminar.LookAndFeel.UseWindowsXPTheme = true;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(38, 36);
            this.btnEliminar.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(71, 4);
            this.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGuardar.LookAndFeel.UseWindowsXPTheme = true;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(38, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(25, 3);
            this.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnNuevo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNuevo.LookAndFeel.UseWindowsXPTheme = true;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(38, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(225, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.pctFoto);
            this.panel1.Controls.Add(this.btnBuscarImagen);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.memoDireccion);
            this.panel1.Controls.Add(this.cmdEstadoCivil);
            this.panel1.Controls.Add(this.dateFechaNacimiento);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 231);
            this.panel1.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(422, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(361, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Email:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(188, 9);
            this.txtId.Name = "txtId";
            this.txtId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtId.Properties.MaxLength = 13;
            this.txtId.Size = new System.Drawing.Size(148, 20);
            this.txtId.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(37, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Id:";
            // 
            // pctFoto
            // 
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFoto.Image = global::CapaPresentacion.Properties.Resources.no_image;
            this.pctFoto.Location = new System.Drawing.Point(677, 13);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(235, 195);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 22;
            this.pctFoto.TabStop = false;
            this.pctFoto.Visible = false;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarImagen.Image")));
            this.btnBuscarImagen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnBuscarImagen.Location = new System.Drawing.Point(927, 78);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(82, 42);
            this.btnBuscarImagen.TabIndex = 21;
            this.btnBuscarImagen.Text = "Buscar";
            this.btnBuscarImagen.Visible = false;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(643, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Foto:";
            this.labelControl4.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(361, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Dirección:";
            // 
            // memoDireccion
            // 
            this.memoDireccion.Location = new System.Drawing.Point(422, 78);
            this.memoDireccion.Name = "memoDireccion";
            this.memoDireccion.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.memoDireccion.Size = new System.Drawing.Size(210, 134);
            this.memoDireccion.TabIndex = 17;
            // 
            // cmdEstadoCivil
            // 
            this.cmdEstadoCivil.Location = new System.Drawing.Point(188, 162);
            this.cmdEstadoCivil.Name = "cmdEstadoCivil";
            this.cmdEstadoCivil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmdEstadoCivil.Properties.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Divorciado",
            "Viudo",
            "Unido"});
            this.cmdEstadoCivil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdEstadoCivil.Size = new System.Drawing.Size(148, 20);
            this.cmdEstadoCivil.TabIndex = 15;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.EditValue = null;
            this.dateFechaNacimiento.Location = new System.Drawing.Point(188, 192);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaNacimiento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateFechaNacimiento.Size = new System.Drawing.Size(148, 20);
            this.dateFechaNacimiento.TabIndex = 14;
            // 
            // cmbGenero
            // 
            this.cmbGenero.EditValue = "";
            this.cmbGenero.Location = new System.Drawing.Point(188, 130);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGenero.Properties.DropDownRows = 2;
            this.cmbGenero.Properties.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbGenero.Size = new System.Drawing.Size(148, 20);
            this.cmbGenero.TabIndex = 13;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(423, 10);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(188, 99);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(148, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(188, 70);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(148, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(188, 40);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCedula.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCedula.Properties.MaxLength = 13;
            this.txtCedula.Size = new System.Drawing.Size(148, 20);
            this.txtCedula.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(35, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(358, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado Civil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(37, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cédula:";
            // 
            // gridControlEmpleados
            // 
            this.gridControlEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlEmpleados.Location = new System.Drawing.Point(0, 303);
            this.gridControlEmpleados.LookAndFeel.SkinName = "Office 2013";
            this.gridControlEmpleados.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlEmpleados.MainView = this.gridViewEmpleados;
            this.gridControlEmpleados.Name = "gridControlEmpleados";
            this.gridControlEmpleados.Size = new System.Drawing.Size(1048, 261);
            this.gridControlEmpleados.TabIndex = 2;
            this.gridControlEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleados});
            // 
            // gridViewEmpleados
            // 
            this.gridViewEmpleados.GridControl = this.gridControlEmpleados;
            this.gridViewEmpleados.Name = "gridViewEmpleados";
            this.gridViewEmpleados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewEmpleados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewEmpleados.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewEmpleados.OptionsBehavior.ReadOnly = true;
            this.gridViewEmpleados.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridViewEmpleados.OptionsFind.AlwaysVisible = true;
            this.gridViewEmpleados.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar...";
            // 
            // frmEmpleados
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1048, 564);
            this.Controls.Add(this.gridControlEmpleados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEstadoCivil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGenero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateFechaNacimiento;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGenero;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.ComboBoxEdit cmdEstadoCivil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnBuscarImagen;
        private System.Windows.Forms.PictureBox pctFoto;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEmail;
    }
}