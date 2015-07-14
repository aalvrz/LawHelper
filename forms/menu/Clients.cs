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
    public partial class Clients : Form
    {

        private bool camposValidados = false;

        public Clients()
        {
            InitializeComponent();
            
        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;
            
            /* Validar si el cliente ya existe */
            if (dal.ccCliente.clienteExiste(idText.Text) == true)
            {
                validador.SetError(idText, "Este cliente ya existe.");
                camposValidados = false;
            }

            /* Validar el ID */
            if (idText.Text == "" || idText.Text.Length > 13)
            {
                validador.SetError(idText, "Porfavor ingrese una ID valida.");
                camposValidados = false;
            }

            /* Validar el nombre */
            if (nameText.Text == "")
            {
                validador.SetError(nameText, "Porfavor ingrese un nombre para el cliente.");
                camposValidados = false;
            }

            /* Validar el apellido */
            if (lnameText.Text == "")
            {
                validador.SetError(lnameText, "Porfavor ingrese un apellido para el cliente.");
                camposValidados = false;
            }

            /* Validar la nacionalidad */
            if (natText.Text == "")
            {
                validador.SetError(natText, "Porfavor ingrese una nacionalidad para el cliente.");
                camposValidados = false;
            }

            /* Validar la edad */
            if (ageText.Text == "")
            { 
                /* Validar tambien que sea numerico, FALTA */
                validador.SetError(ageText, "Porfavor ingrese la edad del cliente.");
                camposValidados = false;
            } 

            /* Validar el estado */
            if (estadoText.Text == "")
            {
                validador.SetError(estadoText, "Porfavor ingrese el estado civil del cliente.");
                camposValidados = false;
            } 
        }

        private void resetFields()
        {
            idText.Text = null;
            nameText.Text = null;
            lnameText.Text = null;
            natText.Text = null;
            ageText.Text = null;
            estadoText.Text = null;
            domText.Text = null;
            telText.Text = null;
            celText.Text = null;
            mailText.Text = null;
            fotografia.Image = null;            

        }

        private void habilitarTodosCampos()
        {
            idText.Enabled = true;
            nameText.Enabled = true;
            lnameText.Enabled = true;
            natText.Enabled = true;
            ageText.Enabled = true;
            estadoText.Enabled = true;
            domText.Enabled = true;
            telText.Enabled = true;
            celText.Enabled = true;
            mailText.Enabled = true;
            imagenBotton.Enabled = true;
            tipoCombo.Enabled = true;

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarPersona();
                    break;

                case "Buscar":
                    buscarPersona();
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = true;
            addButton.Enabled = false;
            mainButton.Text = "Agregar";

            /* Resetear los campos de texto */
            resetFields();
            habilitarTodosCampos();
            validador.Clear();

            /* Deshabilitar la opcion de autocomplete */
            idText.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = false;
            addButton.Enabled = true;
            mainButton.Text = "Buscar";

            /* Resetear los campos de texto */
            resetFields();
            validador.Clear();

            /* Deshabilitar ciertos campos */
            nameText.Enabled = false;
            lnameText.Enabled = false;
            natText.Enabled = false;
            estadoText.Enabled = false;
            ageText.Enabled = false;
            domText.Enabled = false;
            telText.Enabled = false;
            celText.Enabled = false;
            mailText.Enabled = false;
            imagenBotton.Enabled = false;
            tipoCombo.Enabled = false;

            /* Habilitar la funcion de autocomplete */
            idText.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarPersona()
        {
            /* Instanciar el objeto persona */
            blc.Persona persona = new blc.Persona();

            persona.ID = idText.Text;
            persona.Nombre = nameText.Text;
            persona.Apellido = lnameText.Text;
            persona.Nacionalidad = natText.Text;
            persona.Edad = int.Parse(ageText.Text);
            persona.EstadoCivil = estadoText.Text;
            persona.Domicilio = domText.Text;
            persona.Telefono = telText.Text;
            persona.Celular = celText.Text;
            persona.Email = mailText.Text;
            
            /* Agregar al cliente a la BD */
            if (tipoCombo.SelectedItem == tipoCombo.Items[0])
                dal.ccCliente.agregarCliente(persona);
            else
                dal.ccContraparte.agregarContraparte(persona);

            /* Guardar la imagen en el directorio (si se escogio una) */
            if (fotografia.ImageLocation != null)
                persona.Foto = guardarFotografia();
            else
                persona.Foto = null;

            MessageBox.Show("Persona agregada exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarPersonas();
        }

        private void buscarPersona()
        {
            /* Buscar el cliente en la base de datos */
            blc.Persona cliente = new blc.Persona();

            cliente = dal.ccCliente.buscarCliente(idText.Text);

            if (cliente.ID == null)
            {
                MessageBox.Show("Persona no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            resetFields();

            /* Despeglar la informacion en los campos */
            idText.Text = cliente.ID;
            nameText.Text = cliente.Nombre;
            lnameText.Text = cliente.Apellido;
            natText.Text = cliente.Nacionalidad;
            ageText.Text = cliente.Edad.ToString();
            estadoText.Text = cliente.EstadoCivil;
            domText.Text = cliente.Domicilio;
            telText.Text = cliente.Telefono;
            celText.Text = cliente.Celular;
            mailText.Text = cliente.Email;
            
            /* Cargar la fotografia */
            fotografia.ImageLocation = cliente.Foto;
        }

        private void imagenBotton_Click(object sender, EventArgs e)
        {
            
            DialogResult =  fileBrowser.ShowDialog();

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                /* Cargar la fotografia en la picture box */
                fotografia.ImageLocation = fileBrowser.FileName;                               
            }
            
        }

        private string guardarFotografia()
        {
            if (fileBrowser.FileName == "")
                return null;

            /* Recuperar la extension del archivo */
            string[] split = fileBrowser.FileName.Split('.');
            string extension = split[split.Length - 1];
            
            /* Obtener el directorio donde se guardaran las fotografias */
            string appPath;
            if (tipoCombo.SelectedItem == tipoCombo.Items[0])
                appPath = Application.StartupPath + "\\data\\ftsCl\\";
            else
                appPath = Application.StartupPath + "\\data\\ftsCn\\";

            string directorioFinal = appPath + idText.Text + "." + extension;

            /* Copiar la imagen al directorio */
            try
            {
                System.IO.File.Copy(fileBrowser.FileName, directorioFinal, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return directorioFinal;
        }

        private void cargarPersonas()
        {
            idText.AutoCompleteCustomSource.Clear();

            /* Cargar los IDS para el auto complete */
            string[] ids = dal.ccCliente.obtenerIDs().ToArray();

            /* Agregar los ids a las sugerencias */
            idText.AutoCompleteCustomSource.AddRange(ids);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            cargarPersonas();
            tipoCombo.SelectedItem = tipoCombo.Items[0];
        }

    }
}
