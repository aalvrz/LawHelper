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
    public partial class Menu : Form
    {
        private blc.Usuario usuarioActivo;

        public Menu(string userCode)
        {
            InitializeComponent();

            /* Instanciar el usuario activo */
            usuarioActivo = dal.ccUsuario.cargarUsuario(userCode);
            bienvenidoLabel.Text += usuarioActivo.Nombre + " " + usuarioActivo.Apellido + ".";
            usuarioActivo.Grupo = dal.ccGrupo.obtenerGrupo(null, usuarioActivo.Grupo.Codigo.ToString());

            /* Habilitar o Deshabilitar controles de acuerdo al tipo de usuario */
            establecerRestricciones();

        }

        protected override void WndProc(ref Message m) 
        { 
            /* Metodo para impedir que la forma actual sea movida por el usuario */            
            const int WM_SYSCOMMAND = 0x0112; 
            const int SC_MOVE = 0xF010;
            
            switch (m.Msg) 
            { 
                case WM_SYSCOMMAND:                     
                    int command = m.WParam.ToInt32() & 0xfff0; 
                    if (command == SC_MOVE)                         
                        return; 
                break; 
            } 
            base.WndProc(ref m); 
        } 

        private void establecerRestricciones()
        {
            /* Si el usuario es super usuario, salir */
            if (usuarioActivo.Superusuario.Equals("Y"))
                return;

            /* Establecer restricciones de acuerdo a los permisos del grupo al que pertenece el usuario */
            if (usuarioActivo.Grupo.PermisoCasos == "N")            
                casosBoton.Enabled = false;

            if (usuarioActivo.Grupo.PermisoClientes == "N")
                clientesBoton.Enabled = false;

            if (usuarioActivo.Grupo.PermisoTestigos == "N")
                testigosBoton.Enabled = false;

            if (usuarioActivo.Grupo.PermisoEvidencia == "N")
                evidenciaBoton.Enabled = false;

            if (usuarioActivo.Grupo.PermisoInventario == "N")
                inventarioBoton.Enabled = false;

            if (usuarioActivo.Grupo.PermisoReportes == "N")
                reportesBoton.Enabled = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Instanciar la forma de Usuarios */
            forms.Users forma = new forms.Users();
            forma.Show();

        }

        private void gruposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Groups forma = new forms.Groups();
            forma.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            Program.dt.Connecion.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login forma = new Login(new forms.Main());
            forma.Show();
        }

        private void clientesBoton_Click(object sender, EventArgs e)
        {
            forms.Clients forma = new forms.Clients();
            forma.MdiParent = sistemaBufetes.forms.Main.ActiveForm;
            forma.Show();
        }

        private void testigosBoton_Click(object sender, EventArgs e)
        {
            forms.Testigos forma = new forms.Testigos();
            forma.MdiParent = sistemaBufetes.forms.Main.ActiveForm;
            forma.Show();
        }

        private void casosBoton_Click(object sender, EventArgs e)
        {
            forms.Cases forma = new forms.Cases();
            forma.MdiParent = sistemaBufetes.forms.Main.ActiveForm;
            forma.Show();
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioBoton_Click(object sender, EventArgs e)
        {
            forms.Inventory forma = new forms.Inventory();
            forma.MdiParent = sistemaBufetes.forms.Main.ActiveForm;
            forma.Show();
        }

        private void evidenciaBoton_Click(object sender, EventArgs e)
        {
            forms.Evidence forma = new forms.Evidence();
            forma.MdiParent = sistemaBufetes.forms.Main.ActiveForm;
            forma.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            forms.Main.menuVisible = false;
        }
    }
}
