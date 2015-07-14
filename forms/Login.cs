using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaBufetes
{
    public partial class Login : Form
    {
        private forms.Main main;

        public Login(forms.Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ingresarBoton_Click(object sender, EventArgs e)
        {
            /* Conectar a la base de datos */
            if (serverText.Text == "")
                Program.dt = new dal.DT(null);
            else
                Program.dt = new dal.DT(serverText.Text);

            Program.dt.dbConnect();
            
            /* Verificar si la autenticacion es valida */
            if (dal.ccUsuario.autenticacionValida(usuarioText.Text, ccUtilities.GetMD5Hash(passText.Text)) == true)
            {
                main.setCurrentUser(usuarioText.Text);
                main.cargarMenu();
                main.Enabled = true;
                main.Focus();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Autenticacion Invalida", "Autenticacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void serverCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (serverCheck.Checked == true)
                serverText.Enabled = true;
            else
                serverText.Enabled = false;

            serverText.Text = "";
        }
    }
}
