using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaBufetes.forms
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;
        private static string userCode;
        private blc.Usuario usuarioActivo;
        public static bool menuVisible;

        public Main()
        {
            InitializeComponent();            
        }

        public void setCurrentUser(string user)
        {
            userCode = user;

            /* Instanciar el usuario activo */
            usuarioActivo = dal.ccUsuario.cargarUsuario(userCode);
            usuarioActivo.Grupo = dal.ccGrupo.obtenerGrupo(null, usuarioActivo.Grupo.Codigo.ToString());
            Console.WriteLine(usuarioActivo.Grupo.Nombre);
            establecerRestricciones();
        }

        private void establecerRestricciones()
        {
            /* Establecer permisos restrictivos de acuerdo al grupo que pertenece el usuario */
            if (usuarioActivo.Superusuario == "Y")
                return;

            if (usuarioActivo.Grupo.PermisoGestion == "N")
                gestionMenu.Enabled = false;

            if (usuarioActivo.Grupo.PermisoConfiguracion == "N")
                configuracionToolStripMenuItem.Enabled = false;
        }

        public void cargarMenu()
        {
            /* Cargar el Menu Principal */
            Menu principal = new Menu(userCode);
            principal.MdiParent = this;

            /* Establecer la posicion del menu */
            principal.Location = new Point(6, 29);            

            principal.Show();

            menuVisible = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Cerrar la pantalla principal */
            this.Hide();

            /* Cargar una nueva pantalla princiapl */
            Program.main = null;
            Program.main = new forms.Main();
            Program.main.Enabled = false;
            Program.main.Show();

            /* Mostrar la pantalla de login */
            Login login = new Login(Program.main);
            login.Show();            
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Mostrar la pantalla de usuarios */
            Users usuarios = new Users();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void gruposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Mostrar la pantalla de grupos de usuarios */
            Groups grupos = new Groups();
            grupos.MdiParent = this;
            grupos.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Mostrar la pantalla de configuracion */
            forms.Configuration config = new Configuration();
            config.MdiParent = this;
            config.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Mostrar la forma de Acerca De */
            forms.About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void mostrarMenuBoton_Click(object sender, EventArgs e)
        {
            if (menuVisible == false)
                cargarMenu();
        }
    }
}
