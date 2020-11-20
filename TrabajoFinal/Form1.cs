using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TrabajoFinal
{
    public partial class Form1 : Form
    {
        
        public String UserRoot = "root";
        public String PasswordRoot = "root";
        public int userSelected     =   0;
        public int cardTypeSelected = 0;

        // Esta variable contempla el numero maximo de intentos fallidos permitidos antes de que se cierre el programa
        public int intentosFallidos = 3;
        TabPage current;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            menuStrip1.Visible = false;
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            tabControl2.Selecting += new TabControlCancelEventHandler(tabControl2_Selecting);
            tabControl3.Selecting += new TabControlCancelEventHandler(tabControl3_Selecting);
            tabControl4.Selecting += new TabControlCancelEventHandler(tabControl4_Selecting);
        }
        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current = (sender as TabControl).SelectedTab;
            String TabName = current.ToString().Replace("TabPage: {","").Replace("}","");
            if(TabName == "Editar") {
                txtSearchNickname.Enabled= false;
                txtSearchEmail.Enabled = false;
                txtSearchFirstname.Enabled = false;
                txtSearchLastname.Enabled = false;
                txtSearchPassword.Enabled = false;
            }
            
            label13.Text = TabName;
        }
        void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current = (sender as TabControl).SelectedTab;
            String TabName = current.ToString().Replace("TabPage: {", "").Replace("}", "");
            if (TabName == "Usuarios")
            {
                this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
            }
            if (TabName == "Clientes" || TabName=="Tarjetas")
            {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }

            label13.Text = TabName;
        }
        void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current = (sender as TabControl).SelectedTab;
            String TabName = current.ToString().Replace("TabPage: {", "").Replace("}", "");
            if (TabName == "Editar")
            {
                textBox12.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox8.Enabled = false;
            }
            label13.Text = TabName;
        }
        void tabControl4_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current = (sender as TabControl).SelectedTab;
            String TabName = current.ToString().Replace("TabPage: {", "").Replace("}", "");
            if (TabName== "Nuevo Cliente de Tarjeta") {
                var Customers = comboBox1.Items.Count;
                var TypeCard = comboBox2.Items.Count;
                if (Customers==0 || TypeCard==0) {
                    if (Customers == 0)
                    {
                        MessageBox.Show("No hay suficientes usuarios registrados en la plataforma. Debes de crear por lo menos un usuario para poder asignarle una tarjeta.", "Necesita ingresar registros");
                    }
                    else {
                        MessageBox.Show("Actualmente no hay configurados tipos de tarjeta en la plataforma. Debes de crear un tipo de tarjeta por lo menos. Para hacerlo presiona las teclas ALT + T.", "Necesita ingresar registros");
                        tabControl2.SelectTab(2);
                        tabControl4.SelectTab(2);
                    }

                }
            }
            if (TabName == "Generar Transaccion" || TabName=="Nuevo Cliente") {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }
            label13.Text = TabName;
        }

        /// <summary>
        /// Se utilizara para cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se ha cortado la conexion a la base");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == UserRoot && txtPassword.Text== PasswordRoot) {
                groupLogin.Visible = false;
                menuStrip1.Visible = true;
                tabControl1.Visible = true;
                tabControl2.Visible = true;
                this.resetFormNewUser();
            }
            else {
                MessageBox.Show("Lo sentimos credenciales incorrectas vuelve a intentarlo nuevamente.");
                intentosFallidos--;
                if (intentosFallidos==0) {
                    DialogResult results =  MessageBox.Show("Has fallado muchas veces, cerraremos la aplicacion para que lo intentes mas tarde.","Demasiados intentos",MessageBoxButtons.OK);
                    if (results == DialogResult.OK)
                    {
                        this.Close();
                        MessageBox.Show("Se ha cortado la conexion a la base");
                    }
                }
            }
        }
        /*
            Desde aqui se controlan los menus de Usuarios
        */
        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(0);
            tabControl1.SelectTab(2);
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(0);
            tabControl1.SelectTab(1);
        }
        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(0);
            tabControl1.SelectTab(3);
            groupAllUsers.Visible = true;
        }
        /*
            Desde aqui se controlan los menus de Clientes
        */
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
            tabControl3.SelectTab(0);
        }
        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
            tabControl3.SelectTab(1);
        }
        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
            tabControl3.SelectTab(2);
        }
        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
            tabControl3.SelectTab(3);
        }
        /*
        Desde aqui se controla el menu de Tarjetas
        */
        private void nuevaTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(2);
            tabControl4.SelectTab(0);
        }
        private void generarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(2);
            tabControl4.SelectTab(1);
        }
        private void configurarNuevoTipoDeTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(2);
            tabControl4.SelectTab(2);
        }
        /*
        Desde aqui se controla el menu de Reportes
        */
        private void verTransaccionesPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(3);
            tabControl5.SelectTab(0);
        }
        private void verAperturasPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(3);
            tabControl5.SelectTab(1);
        }
        private void cantidadDePuntosAcumuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(3);
            tabControl5.SelectTab(2);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
           
        }
        private void resetFormNewUser() {
            txtNewNickname.Text = "";
            txtNewEmail.Text = "";
            txtNewPassword.Text = "";
            txtNewFirstName.Text = "";
            txtNewLastName.Text = "";
            isEmployeeCheckBox.Checked = false;
        }
        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trabajoFinalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoFinalDataSet.card_transaction' Puede moverla o quitarla según sea necesario.
            this.card_transactionTableAdapter.Fill(this.trabajoFinalDataSet.card_transaction);
            // TODO: esta línea de código carga datos en la tabla 'trabajoFinalDataSet.card' Puede moverla o quitarla según sea necesario.
            this.cardTableAdapter.Fill(this.trabajoFinalDataSet.card);
            // TODO: esta línea de código carga datos en la tabla 'trabajoFinalDataSet.card_type' Puede moverla o quitarla según sea necesario.
            this.card_typeTableAdapter.Fill(this.trabajoFinalDataSet.card_type);
            // TODO: esta línea de código carga datos en la tabla 'trabajoFinalDataSet.user' Puede moverla o quitarla según sea necesario.
            this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        private void groupNewUser_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click_1(object sender, EventArgs e)
        {
            bool isEmployee = false;
            if (txtNewNickname.Text != "" && txtNewEmail.Text != "" && txtNewPassword.Text != "" && txtNewFirstName.Text != "" && txtNewLastName.Text != "")
            {
                if (isEmployeeCheckBox.Checked)
                {
                    isEmployee = true;
                }
                var fechaActual = DateTime.Now;
                this.userTableAdapter.InsertUser(fechaActual.Date, txtNewNickname.Text, txtNewEmail.Text, txtNewPassword.Text, txtNewFirstName.Text, txtNewLastName.Text, isEmployee);
                this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
                MessageBox.Show("Registro almacenado con exito", "Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos requeridos");
            }
        }
        /// <summary>
        /// Metodo para eliminar a un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            String codigoUser = txtCodigoUser.Text;
            if (codigoUser!="") {
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar a este usuario?","Confirmacion de accion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    this.userTableAdapter.DeleteUser(int.Parse(codigoUser));
                    this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
                    MessageBox.Show("Usuario eliminado con exito", "Operacion exitosa");
                    txtCodigoUser.Text = "";
                }
                else {
                    MessageBox.Show("No ha pasado nada, la operacion fue cancelada.", "Todo bien");
                }
            }
            else {
                MessageBox.Show("El codigo de usuario es requerido","Campos obligatorios");
            }
        }
        /// <summary>
        /// Metodo que busca a un usuario para poder actualizar sus datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            String codigoUser = txtSearchUserByCode.Text;
            if (codigoUser!="") {
                this.userTableAdapter.SearchUserById(this.trabajoFinalDataSet.user, int.Parse(codigoUser));
                txtSearchNickname.Text = userDataGridView.Rows[0].Cells[2].Value.ToString();
                txtSearchEmail.Text = userDataGridView.Rows[0].Cells[3].Value.ToString();
                txtSearchFirstname.Text = userDataGridView.Rows[0].Cells[4].Value.ToString();
                txtSearchLastname.Text = userDataGridView.Rows[0].Cells[5].Value.ToString();
                if(userDataGridView.Rows[0].Cells[6].Value.ToString() == "True")
                    checkBox1.Checked = true;
                else
                    checkBox1.Checked = false;


                txtSearchUserByCode.Enabled = false;
                txtSearchNickname.Enabled = true;
                txtSearchEmail.Enabled = true;
                txtSearchFirstname.Enabled = true;
                txtSearchLastname.Enabled = true;
                txtSearchPassword.Enabled = true;
            }
            else {
                MessageBox.Show("El codigo del usuario es requerido","Campos requeridos");
            }
        }
        /// <summary>
        /// Metodo que envia los valores para ser actualizado el perfil del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            bool isEmployee = false;
            if (txtSearchNickname.Text != "" && txtSearchEmail.Text != "" && txtSearchPassword.Text != "" && txtSearchFirstname.Text != "" && txtSearchLastname.Text != "")
            {
                if (checkBox1.Checked)
                {
                    isEmployee = true;
                }
                this.userTableAdapter.UpdateUser(txtSearchNickname.Text, txtSearchEmail.Text, txtSearchPassword.Text, txtSearchNickname.Text, txtSearchLastname.Text, isEmployee, int.Parse(txtSearchUserByCode.Text));
                this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
                this.resetFormEditUser();
                MessageBox.Show("Registro actualizado con exito", "Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos requeridos");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.resetFormEditUser();
        }
        private void resetFormEditUser() {
            //Inicializamos el formulario que actualizara los datos del usuario.
            txtSearchNickname.Text = "";
            txtSearchEmail.Text = "";
            txtSearchFirstname.Text = "";
            txtSearchLastname.Text = "";
            txtSearchPassword.Text = "";
            checkBox1.Checked = false;

            //Desactivamos el formulario para que no tengan valores.
            txtSearchNickname.Enabled = false;
            txtSearchEmail.Enabled = false;
            txtSearchFirstname.Enabled = false;
            txtSearchLastname.Enabled = false;
            txtSearchPassword.Enabled = false;

            //Habilitamos nuevamente la TextBox del codigo de usuario para realizar nueva busqueda
            txtSearchUserByCode.Enabled = true;
        }
        private void resetFormEditCustomer()
        {
            //Inicializamos el formulario que actualizara los datos del usuario.
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            checkBox3.Checked = false;

            //Desactivamos el formulario para que no tengan valores.
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;

            //Habilitamos nuevamente la TextBox del codigo de usuario para realizar nueva busqueda
            textBox7.Enabled = true;
        }

        /// <summary>
        /// Se tiene la posibilidad de filtrar a los usuarios por empleados y por clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrarResultados_Click(object sender, EventArgs e)
        {
            if (chkShowOnlyCustomer.Checked) {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }
            else {
                this.userTableAdapter.fillByOnlyEmployee(this.trabajoFinalDataSet.user);
            }
        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
        }
        /// <summary>
        /// Metodo para almacenar un nuevo tipo de tarjeta: Visa, Mastercard, Gold, Basic, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            if (txtNewCardName.Text!="") {
                this.card_typeTableAdapter.InsertCardType(txtNewCardName.Text);
                this.card_typeTableAdapter.Fill(this.trabajoFinalDataSet.card_type);
                txtNewCardName.Text = "";
            }
            else {
                MessageBox.Show("El nombre del nuevo tipo de tarjeta es requerido","Campos requeridos");
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillBy1(this.trabajoFinalDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByOnlyCustomersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByOnlyCustomersToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo para asociar una tarjeta a un usuario. Se deben de haber seleccionado un usuario y un tipo de tarjeta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            float tasaInteres = 0, montoCredito=0;
            if (comboBox1.Text!="" && comboBox2.Text!="" && txtTasaInteres.Text!="" && txtMontoCredito.Text!="") {
                tasaInteres = float.Parse(txtTasaInteres.Text);
                montoCredito = float.Parse(txtMontoCredito.Text);
                if (tasaInteres > 0 && tasaInteres <= 100)
                {
                    if (montoCredito>0) {
                        var fechaActual = DateTime.Now;
                        userSelected = int.Parse(comboBox1.SelectedValue.ToString());
                        cardTypeSelected = int.Parse(comboBox2.SelectedValue.ToString());
                        this.cardTableAdapter.InsertCardForCustomer(fechaActual, userSelected, cardTypeSelected, int.Parse(txtTasaInteres.Text), int.Parse(txtMontoCredito.Text));
                        this.cardTableAdapter.Fill(this.trabajoFinalDataSet.card);
                    }
                    else {
                        MessageBox.Show("El monto del credito otorgado debe de ser mayor a cero.", "Monto de credito invalido");
                    }
                }
                else {
                    MessageBox.Show("La tasa de interes debe de ser mayor a cero, y menor o igual a 100.","Tasa de Interes invalida");
                }
            }
        }
        /// <summary>
        /// Metodo para insertar una transaccion a la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearTransaccion_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" && txtMontoTransaccion.Text != "")
            {
                DateTime fechaActual = DateTime.Parse(dateTimePicker1.Text);
                MessageBox.Show("El valor de fechaActual es:"+ fechaActual.ToString("MM/dd/yyyy"), "Mostrando Valores");
                int cardSelected = int.Parse(comboBox4.SelectedValue.ToString());
                int pointsTransactions = 0;
                decimal montoTransaction = decimal.Parse(txtMontoTransaccion.Text);
                if (montoTransaction>=500) {
                    pointsTransactions +=20;
                }
                else {
                    pointsTransactions += 5;
                }
                this.card_transactionTableAdapter.InsertNewTransacction(DateTime.Parse(fechaActual.ToString("MM/dd/yyyy")), cardSelected, montoTransaction, pointsTransactions);
                this.card_transactionTableAdapter.Fill(this.trabajoFinalDataSet.card_transaction);
            }
            else {
                MessageBox.Show("Tanto la fecha como el monto de la transaccion son requeridos.","Campos Obligatorios");
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Metodo que detecta cuando el comboBox cambia de valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            userSelected = int.Parse(comboBox3.SelectedValue.ToString());
            this.card1TableAdapter.GetDataCardByCustomer(userSelected);
            this.card1TableAdapter.FillCardByCustomer(this.trabajoFinalDataSet1.card1, userSelected);
            if (comboBox4.Items.Count > 0)
            {
                dateTimePicker1.Enabled = true;
                txtMontoTransaccion.Enabled = true;
            }
            else {
                dateTimePicker1.Enabled = false;
                txtMontoTransaccion.Enabled = false;
            }
        }
        /// <summary>
        /// Metodo para crear a un cliente, el cual tambien sera un usuario de la plataforma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            bool isEmployee = false;
            if (textBox5.Text != "" && textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                var fechaActual = DateTime.Now;
                this.userTableAdapter.InsertUser(fechaActual.Date, textBox5.Text, textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, isEmployee);
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
                MessageBox.Show("Cliente almacenado con exito", "Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos requeridos");
            }
        }
        /// <summary>
        /// Metodo para eliminar un cliente de la lista de clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            String codigoUser = textBox6.Text;
            if (codigoUser != "")
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar a este usuario?", "Confirmacion de accion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.userTableAdapter.DeleteCustomer(int.Parse(codigoUser));
                    this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
                    MessageBox.Show("Cliente eliminado con exito", "Operacion exitosa");
                    textBox6.Text = "";
                }
                else
                {
                    MessageBox.Show("No ha pasado nada, la operacion fue cancelada.", "Todo bien");
                }
            }
            else
            {
                MessageBox.Show("El codigo de cliente es requerido", "Campos obligatorios");
            }
        }
        /// <summary>
        /// Metodo para la busqueda de un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            String codigoUser = textBox7.Text;
            if (codigoUser != "")
            {
                try {
                    this.userTableAdapter.FillByIdCustomer(this.trabajoFinalDataSet.user, int.Parse(codigoUser));
                    textBox12.Text = dataGridView6.Rows[0].Cells[2].Value.ToString();
                    textBox9.Text = dataGridView6.Rows[0].Cells[3].Value.ToString();
                    textBox10.Text = dataGridView6.Rows[0].Cells[4].Value.ToString();
                    textBox11.Text = dataGridView6.Rows[0].Cells[5].Value.ToString();
                    if (dataGridView6.Rows[0].Cells[6].Value.ToString() == "True")
                        checkBox1.Checked = true;
                    else
                        checkBox1.Checked = false;


                    textBox7.Enabled = false;
                    textBox12.Enabled = true;
                    textBox9.Enabled = true;
                    textBox10.Enabled = true;
                    textBox11.Enabled = true;
                    textBox8.Enabled = true;
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Cliente no encontrado");
                }
            }
            else
            {
                MessageBox.Show("El codigo del cliente es requerido", "Campos requeridos");
            }
        }
        /// <summary>
        /// Nos disponemos actualizar los datos del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            bool isEmployee = false;
            if (textBox12.Text != "" && textBox9.Text != "" && textBox8.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                this.userTableAdapter.UpdateUser(textBox12.Text, textBox9.Text, textBox8.Text, textBox10.Text, textBox11.Text, isEmployee, int.Parse(textBox7.Text));
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
                this.resetFormEditCustomer();
                MessageBox.Show("Registro actualizado con exito", "Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos requeridos");
            }
        }
        /// <summary>
        /// Con este metodo se reinicia el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.resetFormEditCustomer();
        }
        /// <summary>
        /// Filtra los resultados de los usuarios solo por clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.userTableAdapter.FillByOnlyCustomers(this.trabajoFinalDataSet.user);
            }
            else
            {
                MessageBox.Show("En esta seccion no se pueden ver a todos los usuarios del sistema. Solo a los clientes","Operacion invalida.");
            }
        }
        /// <summary>
        /// Metodo que se encarga de buscar las transacciones realizadas entre un periodo de tiempo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse(dateStartPeriodTransaction.Text);
            DateTime date2 = DateTime.Parse(dateEndPeriodTransaction.Text);
            String StartDate = dateStartPeriodTransaction.Value.ToString("MM/dd/yyyy");
            String EndDate = dateEndPeriodTransaction.Value.ToString("MM/dd/yyyy");
            double result = (date2 - date1).TotalDays;
            if (dateStartPeriodTransaction.Text!="" && dateEndPeriodTransaction.Text!="") {
                if (result >= 0)
                {
                    try {
                        MessageBox.Show("Valores de las fechas seleccionadas es: ["+ dateStartPeriodTransaction.Value.Date +"] [ "+ dateEndPeriodTransaction.Value.Date+"]");
                        this.card_transactionTableAdapter.GetDataTransactionBetweenDates(dateStartPeriodTransaction.Value.Date, dateEndPeriodTransaction.Value.Date);
                        this.card_transactionTableAdapter.FillTransactionBetweenDates(this.trabajoFinalDataSet.card_transaction, dateStartPeriodTransaction.Value.Date, dateEndPeriodTransaction.Value.Date);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al ejecutar esta consulta. Intentelo nuevamente.");
                    }
                }
                else {
                    MessageBox.Show("La fecha de inicio tiene que ser mayor que la fecha de fin.","Fechas incorrectas");
                }


            }
            else {
                MessageBox.Show("Las fechas de inico y de fin son obligatorias.","Campos obligatorios");
            }
        }
    }
}
