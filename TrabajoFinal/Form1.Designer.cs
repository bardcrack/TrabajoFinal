namespace TrabajoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label user_nicknameLabel;
            System.Windows.Forms.Label user_emailLabel;
            System.Windows.Forms.Label user_passwordLabel;
            System.Windows.Forms.Label user_firstnameLabel;
            System.Windows.Forms.Label user_lastnameLabel;
            System.Windows.Forms.Label isEmployeeLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarNuevoTipoDeTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTransaccionesPorPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAperturasPorPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePuntosAcumuladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoFinalDataSet = new TrabajoFinal.TrabajoFinalDataSet();
            this.userTableAdapter = new TrabajoFinal.TrabajoFinalDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new TrabajoFinal.TrabajoFinalDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupNewUser = new System.Windows.Forms.GroupBox();
            this.user_nicknameTextBox = new System.Windows.Forms.TextBox();
            this.user_emailTextBox = new System.Windows.Forms.TextBox();
            this.user_passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_firstnameTextBox = new System.Windows.Forms.TextBox();
            this.user_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.isEmployeeCheckBox = new System.Windows.Forms.CheckBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.groupAllUsers = new System.Windows.Forms.GroupBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            user_nicknameLabel = new System.Windows.Forms.Label();
            user_emailLabel = new System.Windows.Forms.Label();
            user_passwordLabel = new System.Windows.Forms.Label();
            user_firstnameLabel = new System.Windows.Forms.Label();
            user_lastnameLabel = new System.Windows.Forms.Label();
            isEmployeeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoFinalDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupNewUser.SuspendLayout();
            this.groupAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tarjetasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // miPerfilToolStripMenuItem
            // 
            this.miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            this.miPerfilToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.miPerfilToolStripMenuItem.Text = "Mi perfil";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarUsuarioToolStripMenuItem.Text = "Ver Usuarios";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.buscarClienteToolStripMenuItem.Text = "Ver Clientes";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaTarjetaToolStripMenuItem,
            this.generarMovimientoToolStripMenuItem,
            this.toolStripSeparator1,
            this.configurarNuevoTipoDeTarjetaToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            // 
            // nuevaTarjetaToolStripMenuItem
            // 
            this.nuevaTarjetaToolStripMenuItem.Name = "nuevaTarjetaToolStripMenuItem";
            this.nuevaTarjetaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.nuevaTarjetaToolStripMenuItem.Text = "Nuevo cliente de Tarjeta";
            // 
            // generarMovimientoToolStripMenuItem
            // 
            this.generarMovimientoToolStripMenuItem.Name = "generarMovimientoToolStripMenuItem";
            this.generarMovimientoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.generarMovimientoToolStripMenuItem.Text = "Generar Transacción";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // configurarNuevoTipoDeTarjetaToolStripMenuItem
            // 
            this.configurarNuevoTipoDeTarjetaToolStripMenuItem.Name = "configurarNuevoTipoDeTarjetaToolStripMenuItem";
            this.configurarNuevoTipoDeTarjetaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.configurarNuevoTipoDeTarjetaToolStripMenuItem.Text = "Configurar nuevo tipo de tarjeta";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTransaccionesPorPeriodoToolStripMenuItem,
            this.verAperturasPorPeriodoToolStripMenuItem,
            this.cantidadDePuntosAcumuladosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verTransaccionesPorPeriodoToolStripMenuItem
            // 
            this.verTransaccionesPorPeriodoToolStripMenuItem.Name = "verTransaccionesPorPeriodoToolStripMenuItem";
            this.verTransaccionesPorPeriodoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verTransaccionesPorPeriodoToolStripMenuItem.Text = "Ver transacciones por periodo";
            // 
            // verAperturasPorPeriodoToolStripMenuItem
            // 
            this.verAperturasPorPeriodoToolStripMenuItem.Name = "verAperturasPorPeriodoToolStripMenuItem";
            this.verAperturasPorPeriodoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verAperturasPorPeriodoToolStripMenuItem.Text = "Ver aperturas por periodo";
            // 
            // cantidadDePuntosAcumuladosToolStripMenuItem
            // 
            this.cantidadDePuntosAcumuladosToolStripMenuItem.Name = "cantidadDePuntosAcumuladosToolStripMenuItem";
            this.cantidadDePuntosAcumuladosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.cantidadDePuntosAcumuladosToolStripMenuItem.Text = "Cantidad de puntos acumulados";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BackColor = System.Drawing.Color.Red;
            this.btnCancelarLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarLogin.Location = new System.Drawing.Point(43, 307);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(153, 37);
            this.btnCancelarLogin.TabIndex = 20;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(43, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 37);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(43, 184);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(153, 20);
            this.txtUser.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "USUARIO:";
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.pictureBox1);
            this.groupLogin.Controls.Add(this.btnLogin);
            this.groupLogin.Controls.Add(this.btnCancelarLogin);
            this.groupLogin.Controls.Add(this.label1);
            this.groupLogin.Controls.Add(this.label2);
            this.groupLogin.Controls.Add(this.txtPassword);
            this.groupLogin.Controls.Add(this.txtUser);
            this.groupLogin.Location = new System.Drawing.Point(157, 12);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(263, 370);
            this.groupLogin.TabIndex = 22;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Iniciar Sesion";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.trabajoFinalDataSet;
            // 
            // trabajoFinalDataSet
            // 
            this.trabajoFinalDataSet.DataSetName = "TrabajoFinalDataSet";
            this.trabajoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.card_transactionTableAdapter = null;
            this.tableAdapterManager.card_typeTableAdapter = null;
            this.tableAdapterManager.cardTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrabajoFinal.TrabajoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 366);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupNewUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupAllUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupNewUser
            // 
            this.groupNewUser.Controls.Add(user_nicknameLabel);
            this.groupNewUser.Controls.Add(this.user_nicknameTextBox);
            this.groupNewUser.Controls.Add(user_emailLabel);
            this.groupNewUser.Controls.Add(this.user_emailTextBox);
            this.groupNewUser.Controls.Add(user_passwordLabel);
            this.groupNewUser.Controls.Add(this.user_passwordTextBox);
            this.groupNewUser.Controls.Add(user_firstnameLabel);
            this.groupNewUser.Controls.Add(this.user_firstnameTextBox);
            this.groupNewUser.Controls.Add(user_lastnameLabel);
            this.groupNewUser.Controls.Add(this.user_lastnameTextBox);
            this.groupNewUser.Controls.Add(isEmployeeLabel);
            this.groupNewUser.Controls.Add(this.isEmployeeCheckBox);
            this.groupNewUser.Controls.Add(this.btnNewUser);
            this.groupNewUser.Location = new System.Drawing.Point(137, 8);
            this.groupNewUser.Name = "groupNewUser";
            this.groupNewUser.Size = new System.Drawing.Size(336, 324);
            this.groupNewUser.TabIndex = 24;
            this.groupNewUser.TabStop = false;
            this.groupNewUser.Text = "Nuevo Usuario";
            // 
            // user_nicknameLabel
            // 
            user_nicknameLabel.AutoSize = true;
            user_nicknameLabel.Location = new System.Drawing.Point(14, 31);
            user_nicknameLabel.Name = "user_nicknameLabel";
            user_nicknameLabel.Size = new System.Drawing.Size(79, 13);
            user_nicknameLabel.TabIndex = 18;
            user_nicknameLabel.Text = "user nickname:";
            // 
            // user_nicknameTextBox
            // 
            this.user_nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_nickname", true));
            this.user_nicknameTextBox.Location = new System.Drawing.Point(99, 28);
            this.user_nicknameTextBox.Name = "user_nicknameTextBox";
            this.user_nicknameTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_nicknameTextBox.TabIndex = 19;
            // 
            // user_emailLabel
            // 
            user_emailLabel.AutoSize = true;
            user_emailLabel.Location = new System.Drawing.Point(14, 57);
            user_emailLabel.Name = "user_emailLabel";
            user_emailLabel.Size = new System.Drawing.Size(57, 13);
            user_emailLabel.TabIndex = 20;
            user_emailLabel.Text = "user email:";
            // 
            // user_emailTextBox
            // 
            this.user_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_email", true));
            this.user_emailTextBox.Location = new System.Drawing.Point(99, 54);
            this.user_emailTextBox.Name = "user_emailTextBox";
            this.user_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_emailTextBox.TabIndex = 21;
            // 
            // user_passwordLabel
            // 
            user_passwordLabel.AutoSize = true;
            user_passwordLabel.Location = new System.Drawing.Point(14, 83);
            user_passwordLabel.Name = "user_passwordLabel";
            user_passwordLabel.Size = new System.Drawing.Size(78, 13);
            user_passwordLabel.TabIndex = 22;
            user_passwordLabel.Text = "user password:";
            // 
            // user_passwordTextBox
            // 
            this.user_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_password", true));
            this.user_passwordTextBox.Location = new System.Drawing.Point(99, 80);
            this.user_passwordTextBox.Name = "user_passwordTextBox";
            this.user_passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_passwordTextBox.TabIndex = 23;
            // 
            // user_firstnameLabel
            // 
            user_firstnameLabel.AutoSize = true;
            user_firstnameLabel.Location = new System.Drawing.Point(14, 109);
            user_firstnameLabel.Name = "user_firstnameLabel";
            user_firstnameLabel.Size = new System.Drawing.Size(75, 13);
            user_firstnameLabel.TabIndex = 24;
            user_firstnameLabel.Text = "user firstname:";
            // 
            // user_firstnameTextBox
            // 
            this.user_firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_firstname", true));
            this.user_firstnameTextBox.Location = new System.Drawing.Point(99, 106);
            this.user_firstnameTextBox.Name = "user_firstnameTextBox";
            this.user_firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_firstnameTextBox.TabIndex = 25;
            // 
            // user_lastnameLabel
            // 
            user_lastnameLabel.AutoSize = true;
            user_lastnameLabel.Location = new System.Drawing.Point(14, 135);
            user_lastnameLabel.Name = "user_lastnameLabel";
            user_lastnameLabel.Size = new System.Drawing.Size(75, 13);
            user_lastnameLabel.TabIndex = 26;
            user_lastnameLabel.Text = "user lastname:";
            // 
            // user_lastnameTextBox
            // 
            this.user_lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_lastname", true));
            this.user_lastnameTextBox.Location = new System.Drawing.Point(99, 132);
            this.user_lastnameTextBox.Name = "user_lastnameTextBox";
            this.user_lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_lastnameTextBox.TabIndex = 27;
            // 
            // isEmployeeLabel
            // 
            isEmployeeLabel.AutoSize = true;
            isEmployeeLabel.Location = new System.Drawing.Point(14, 163);
            isEmployeeLabel.Name = "isEmployeeLabel";
            isEmployeeLabel.Size = new System.Drawing.Size(66, 13);
            isEmployeeLabel.TabIndex = 28;
            isEmployeeLabel.Text = "is Employee:";
            // 
            // isEmployeeCheckBox
            // 
            this.isEmployeeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "isEmployee", true));
            this.isEmployeeCheckBox.Location = new System.Drawing.Point(99, 158);
            this.isEmployeeCheckBox.Name = "isEmployeeCheckBox";
            this.isEmployeeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isEmployeeCheckBox.TabIndex = 29;
            this.isEmployeeCheckBox.Text = "checkBox1";
            this.isEmployeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(18, 182);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(100, 23);
            this.btnNewUser.TabIndex = 13;
            this.btnNewUser.Text = "Insertar usuario";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // groupAllUsers
            // 
            this.groupAllUsers.Controls.Add(this.userDataGridView);
            this.groupAllUsers.Location = new System.Drawing.Point(3, 6);
            this.groupAllUsers.Name = "groupAllUsers";
            this.groupAllUsers.Size = new System.Drawing.Size(580, 239);
            this.groupAllUsers.TabIndex = 31;
            this.groupAllUsers.TabStop = false;
            this.groupAllUsers.Text = "Todos los usuarios";
            this.groupAllUsers.Visible = false;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToOrderColumns = true;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(34, 28);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(576, 279);
            this.userDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_created";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_created";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_nickname";
            this.dataGridViewTextBoxColumn3.HeaderText = "user_nickname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "user_email";
            this.dataGridViewTextBoxColumn4.HeaderText = "user_email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "user_password";
            this.dataGridViewTextBoxColumn5.HeaderText = "user_password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_firstname";
            this.dataGridViewTextBoxColumn6.HeaderText = "user_firstname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "user_lastname";
            this.dataGridViewTextBoxColumn7.HeaderText = "user_lastname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isEmployee";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isEmployee";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(611, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 575);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupLogin);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banco Universitario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoFinalDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupNewUser.ResumeLayout(false);
            this.groupNewUser.PerformLayout();
            this.groupAllUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarNuevoTipoDeTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTransaccionesPorPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAperturasPorPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDePuntosAcumuladosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLogin;
        private TrabajoFinalDataSet trabajoFinalDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private TrabajoFinalDataSetTableAdapters.userTableAdapter userTableAdapter;
        private TrabajoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupNewUser;
        private System.Windows.Forms.TextBox user_nicknameTextBox;
        private System.Windows.Forms.TextBox user_emailTextBox;
        private System.Windows.Forms.TextBox user_passwordTextBox;
        private System.Windows.Forms.TextBox user_firstnameTextBox;
        private System.Windows.Forms.TextBox user_lastnameTextBox;
        private System.Windows.Forms.CheckBox isEmployeeCheckBox;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupAllUsers;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

