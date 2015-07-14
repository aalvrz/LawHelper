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
    public partial class Users : Form
    {
        private bool camposValidados = false;
        
        public Users()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = true;
            addButton.Enabled = false;
            mainButton.Text = "Agregar";

            /* Resetear los campos de texto */
            resetFields();
            habilitarTodosCampos();

            /* Desactivar autocomplete */
            userText.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = false;
            addButton.Enabled = true;
            mainButton.Text = "Buscar";

            /* Resetear los campos de texto */
            resetFields();

            /* Deshabilitar ciertos campos */
            nameText.Enabled = false;
            lnameText.Enabled = false;
            gruposCombo.Enabled = false;
            passText.Enabled = false;
            superCheck.Enabled = false;
            mobileText.Enabled = false;

            /* Activar el autocomplete */
            userText.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetFields()
        {
            userText.Text = null;
            nameText.Text = null;
            lnameText.Text = null;
            mobileText.Text = null;
            mailText.Text = null;
            gruposCombo.Text = null;
            passText.Text = null;
            superCheck.Checked = false;
            

            validador.Clear();
        }

        private void habilitarTodosCampos()
        {
            userText.Enabled = true;
            nameText.Enabled = true;
            lnameText.Enabled = true;
            mobileText.Enabled = true;
            mailText.Enabled = true;
            gruposCombo.Enabled = true;
            passText.Enabled = true;
            superCheck.Enabled = true;

        }

        private void Users_Load(object sender, EventArgs e)
        {
            /* Cargar los grupos existentes */
            List<blc.Grupo> grupos = dal.ccGrupo.obtenerGrupos();

            /* Llenar el combo box con los grupos */
            foreach (blc.Grupo grupo in grupos)          
                gruposCombo.Items.Add(grupo.Nombre);

            /* Cargar los usuarios ya existentes para el autocomplete en FIND */
            cargarUsuarios();

            toolTip.SetToolTip(encIcon, "Encriptacion segura");
        }

        private void cargarUsuarios()
        {
            userText.AutoCompleteCustomSource.Clear();
            
            /* Obtener ids */
            string[] usuarios = dal.ccUsuario.obtenerUsuarios().ToArray();
            
            /* Autocomplete */
            userText.AutoCompleteCustomSource.AddRange(usuarios);            
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarUsuario();
                    break;

                case "Buscar":
                    buscarUsuario();
                    break;
            }
        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;

            if (userText.Text == "")
            {
                validador.SetError(userText, "Porfavor ingrese un usuario");
                camposValidados = false;
            }

            if (dal.ccUsuario.usuarioExiste(userText.Text) == true)
            {
                validador.SetError(userText, "Este usuario ya existe. Porfavor escoger otro.");
                camposValidados = false;
            }

            if (nameText.Text == "")
            {
                validador.SetError(nameText, "Porfavor ingrese un nombre");
                camposValidados = false;
            }

            if (lnameText.Text == "")
            {
                validador.SetError(lnameText, "Porfavor ingrese un apellido");
                camposValidados = false;
            }

            if (mobileText.Text.Contains("-") )
            {
                validador.SetError(mobileText, "El formato de celular es invalido. Porfavor solo ingrese numeros");
                camposValidados = false;
            }

            if (!(mailText.Text == "") && !mailText.Text.Contains("@") )
            {
                validador.SetError(mailText, "El formato de email es invalido.");
                camposValidados = false;
            }

            if (gruposCombo.Text == "Seleccione Grupo" || gruposCombo.Text == "" )
            {
                validador.SetError(gruposCombo, "Seleccione un grupo de la lista.");
                camposValidados = false;
            }

            if (passText.Text == "" || passText.Text.Length < 7 || passText.Text.Length > 10)
            {
                validador.SetError(passText, "Porfavor ingrese una contraseña valida. La contraseña debe de tener al menos 7 caracteres y no mas de 10.");
                camposValidados = false;
            }
        }

        private void agregarUsuario()
        {
            blc.Usuario usuario = new blc.Usuario(userText.Text, ccUtilities.GetMD5Hash(passText.Text));

            /* Agregar las demas propiedades */
            usuario.Nombre = nameText.Text;
            usuario.Apellido = lnameText.Text;
            usuario.Celular = mobileText.Text;
            usuario.Email = mailText.Text;

            /* Asignar si es super usuario */
            if (superCheck.Checked == true)
                usuario.Superusuario = "Y";
            else
                usuario.Superusuario = "N";

            /* Asignar el codigo del grupo */
            usuario.Grupo = dal.ccGrupo.obtenerGrupo(gruposCombo.Text, null);

            /* Finalmente, agregar el usuario a la base de datos */
            dal.ccUsuario.agregarUsuario(usuario);

            MessageBox.Show("Usuario agregado exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarUsuarios();

        }

        private void buscarUsuario()
        {
            /* Buscar el usuario en la BD */
            
            blc.Usuario usuario = dal.ccUsuario.cargarUsuario(userText.Text);

            if (usuario.Codigo == null)
            {
                MessageBox.Show("Usuario no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            usuario.Grupo  = dal.ccGrupo.obtenerGrupo(null, usuario.Grupo.Codigo.ToString());
            
            /* Desplegar los datos en los campos */
            resetFields();
            userText.Text = usuario.Codigo;
            nameText.Text = usuario.Nombre;
            lnameText.Text = usuario.Apellido;
            mobileText.Text = usuario.Celular;
            mailText.Text = usuario.Email;
            gruposCombo.Text = usuario.Grupo.Nombre;
            passText.Text = "********";

            if (usuario.Superusuario == "Y")
                superCheck.Checked = true;
            else
                superCheck.Checked = false;

        }
    }
}
