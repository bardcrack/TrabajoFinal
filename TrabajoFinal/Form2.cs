using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Form2 : Form
    {
        public String UserRoot = "root";
        public String PasswordRoot = "root";
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            if (txtUser.Text == UserRoot && txtPassword.Text == PasswordRoot)
            {
                this.Close();
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Las credenciales proporcionadas estan incorrectas", "Error de autentitcación");
            }
        }
    }
}
