﻿using System;
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
        public int intentosFallidos = 3;
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Daniel\\Desktop\\Proyecto grupal\\TrabajoFinal\\TrabajoFinal\\TrabajoFinal.mdb");

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            menuStrip1.Visible = false;
            this.hideAllGroupElements();
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Conexion a la base de datos no establecida" + ex);
            }
        }
        private void hideAllGroupElements() {
            /*groupNewUser.Visible = false;
            groupAllUsers.Visible = false;*/
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
            ///cn.Close();
            ///dataGridViewUser.DataSource = "";
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
                        //cn.Close();
                        ///dataGridViewUser.DataSource = "";
                        MessageBox.Show("Se ha cortado la conexion a la base");
                    }
                }
            }
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            this.reloadDataGridView();
        }
        public void reloadDataGridView() {
            /*OleDbCommand command = new OleDbCommand();
            //command.Connection = cn;
            string sql = "SELECT id_user,date_created,user_nickname, user_email,user_firstname, user_lastname,isEmployee FROM [user]";
            command.CommandText = sql;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            userDataGridView.DataSource = dt;
            userDataGridView.Refresh();*/
            //cn.Close();
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
            // TODO: esta línea de código carga datos en la tabla 'trabajoFinalDataSet.user' Puede moverla o quitarla según sea necesario.
            this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.hideAllGroupElements();
            groupAllUsers.Visible = true;
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
                /*this.reloadDataGridView();
                this.resetFormNewUser();*/
                this.userTableAdapter.Fill(this.trabajoFinalDataSet.user);
                MessageBox.Show("Registro almacenado con exito", "Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos requeridos");
            }
        }
    }
}
