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
    public partial class Testigos : Form
    {

        private bool camposValidados = false;

        public Testigos()
        {
            InitializeComponent();
            
        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;

            /* Validar si el testigo ya existe */
            if (dal.ccTestigo.testigoExiste(idText.Text) == true)
            {
                validador.SetError(idText, "Este testigo ya existe.");
                camposValidados = false;
            }

            if (idText.Text == "" || idText.Text.Length > 13)
            {
                validador.SetError(idText, "Porfavor ingrese una ID valida.");
                camposValidados = false;
            }

            if (nameText.Text == "")
            {
                validador.SetError(nameText, "Porfavor ingrese un nombre para el cliente.");
                camposValidados = false;
            }

            if (lnameText.Text == "")
            {
                validador.SetError(lnameText, "Porfavor ingrese un apellido para el cliente.");
                camposValidados = false;
            }

            if (natText.Text == "")
            {
                validador.SetError(natText, "Porfavor ingrese una nacionalidad para el cliente.");
                camposValidados = false;
            }

            if (ageText.Text == "")
            {
                /* Validar tambien que sea numerico, FALTA */
                validador.SetError(ageText, "Porfavor ingrese la edad del cliente.");
                camposValidados = false;
            }

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

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarTestigo();
                    break;

                case "Buscar":
                    buscarTestigo();
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

            /* Deshabilitar autocomplete */
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

            /* Habilitar autocomplete */
            idText.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarTestigo()
        {
            /* Instanciar el objeto cliente */
            blc.Persona testigo = new blc.Persona();

            testigo.ID = idText.Text;
            testigo.Nombre = nameText.Text;
            testigo.Apellido = lnameText.Text;
            testigo.Nacionalidad = natText.Text;
            testigo.Edad = int.Parse(ageText.Text);
            testigo.EstadoCivil = estadoText.Text;
            testigo.Domicilio = domText.Text;
            testigo.Telefono = telText.Text;
            testigo.Celular = celText.Text;
            testigo.Email = mailText.Text;            

            /* Guardar la imagen en el directorio (si se escogio una) */
            if (fotografia.ImageLocation != null)
                testigo.Foto = guardarFotografia();
            else
                testigo.Foto = null;

            /* Agregar al cliente a la BD */
            dal.ccTestigo.agregarTestigo(testigo);

            MessageBox.Show("Testigo agregado exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarTestigos();
        }

        private void buscarTestigo()
        {
            /* Buscar el cliente en la base de datos */
            blc.Persona testigo = new blc.Persona();

            testigo = dal.ccTestigo.buscarTestigo(idText.Text);

            if (testigo.ID == null)
            {
                MessageBox.Show("Testigo no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            resetFields();
            /* Despeglar la informacion en los campos */
            idText.Text = testigo.ID;
            nameText.Text = testigo.Nombre;
            lnameText.Text = testigo.Apellido;
            natText.Text = testigo.Nacionalidad;
            ageText.Text = testigo.Edad.ToString();
            estadoText.Text = testigo.EstadoCivil;
            domText.Text = testigo.Domicilio;
            telText.Text = testigo.Telefono;
            celText.Text = testigo.Celular;
            mailText.Text = testigo.Email;
            
            /* Cargar la fotografia */
            fotografia.ImageLocation = testigo.Foto;
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
            string appPath = Application.StartupPath + "\\data\\ftsTs\\";
            string directorioFinal = appPath + idText.Text + "." + extension;

            /* Copiar la imagen al directorio */
            System.IO.File.Copy(fileBrowser.FileName, directorioFinal, true);

            return directorioFinal;
        }

        private void cargarTestigos()
        {
            idText.AutoCompleteCustomSource.Clear();
            
            /* Cargar los IDS para autocomplete */
            string[] ids = dal.ccTestigo.obtenerIDs().ToArray();

            /* Asignarlos como sugerencias */
            idText.AutoCompleteCustomSource.AddRange(ids);
        }

        private void Testigos_Load(object sender, EventArgs e)
        {
            cargarTestigos();
        }

    }
}
