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
    public partial class Evidence : Form
    {
        private bool camposValidados = false;

        public Evidence()
        {
            InitializeComponent();
        }

        private void resetFields()
        {
            codigoText.Text = null;
            casoText.Text = null;
            descText.Text = null;
            fileText.Text = null;
        }

        private void validarCampos()
        {
            camposValidados = true;
            validador.Clear();

            /* Validar el codigo de la evidencia */
            if (codigoText.Text == "")
            {
                camposValidados = false;
                validador.SetError(codigoText, "Porfavor ingrese un codigo para la evidencia.");
            }

            /* Validar si ya existe el codigo ingresado */
            if ( dal.ccEvidencia.existeEvidencia(codigoText.Text) == true )
            {
                camposValidados = false;
                validador.SetError(codigoText, "Este codigo de evidencia ya esta tomado.");
            }

            /* Validar el id del caso */
            if (casoText.Text == "")
            {
                camposValidados = false;
                validador.SetError(casoText, "Porfavor ingrese el caso a cual esta evidencia pertenece");
            }

            /* Validar que existe el caso ingresado */
            if (dal.ccCaso.casoExiste(casoText.Text) == false )
            {
                camposValidados = false;
                validador.SetError(casoText, "Este caso no existe");
            }

            /* Validar la descripcion */
            if (descText.Text == "")
            {
                camposValidados = false;
                validador.SetError(descText, "Porfavor ingrese una descripcion.");
            }

            /* Validar el path del archivo */
            if (fileText.Text == "")
            {
                camposValidados = false;
                validador.SetError(browseButton, "Porfavor seleccione el archivo de evidencia.");
            }
        }

        private void habilitarCampos()
        {
            codigoText.Enabled = true;
            casoText.Enabled = true;
            descText.Enabled = true;            
            browseButton.Enabled = true;
        }

        private string guardarArchivo()
        {
            /* Recuperar la extension del archivo */
            string[] split = fileBrowser.FileName.Split('.');
            string extension = split[split.Length - 1];

            /* Obtener el directorio donde se guardaran las fotografias */
            string appPath;
            appPath = Application.StartupPath + "\\data\\ev\\";


            string directorioFinal = appPath + codigoText.Text + "." + extension;

            /* Copiar la imagen al directorio */
            System.IO.File.Copy(fileBrowser.FileName, directorioFinal);

            return directorioFinal;
        }

        private void agregarEvidencia()
        {
            /* Instanciar el objeto */
            blc.Evidencia evidencia = new blc.Evidencia();
            evidencia.Codigo = codigoText.Text;
            evidencia.Caso = casoText.Text;
            evidencia.Descripcion = descText.Text;

            /* Copiar el archivo al directorio de la aplicacion */
            evidencia.Path = guardarArchivo();

            /* Agregar a la base de datos */
            dal.ccEvidencia.agregarEvidencia(evidencia);
            
            MessageBox.Show("Evidencia agregada exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarEvidencias();
        }

        private void buscarEvidencia()
        {
            /* Instanciar objeto */
            blc.Evidencia evidencia = new blc.Evidencia();

            /* Buscarlo en la base de datos */
            evidencia = dal.ccEvidencia.buscarEvidencia(codigoText.Text);

            if (evidencia.Codigo == null)
            {
                MessageBox.Show("Evidencia no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            /* Desplegar los datos */
            codigoText.Text = evidencia.Codigo;
            casoText.Text = evidencia.Caso;
            descText.Text = evidencia.Descripcion;            
        }

        private void cargarEvidencias()
        {
            codigoText.AutoCompleteCustomSource.Clear();

            /* Cargar IDs de evidencias para el autocomplete */
            string[] ids = dal.ccEvidencia.obtenerIDs().ToArray();

            /* Agregar los ids a las sugerencias */
            codigoText.AutoCompleteCustomSource.AddRange(ids);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = true;
            addButton.Enabled = false;
            mainButton.Text = "Agregar";

            /* Resetear los campos de texto */
            resetFields();
            habilitarCampos();
            validador.Clear();

            codigoText.AutoCompleteMode = AutoCompleteMode.None;
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
            casoText.Enabled = false;
            descText.Enabled = false;           
            browseButton.Enabled = false;

            codigoText.AutoCompleteMode = AutoCompleteMode.Suggest;

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarEvidencia();
                    break;

                case "Buscar":
                    buscarEvidencia();
                    break;
            }
        }

        private void Evidence_Load(object sender, EventArgs e)
        {
            cargarEvidencias();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            /* Abrir el file dialog */
            DialogResult = fileBrowser.ShowDialog();

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                /* Cargar el path al textbox */
                fileText.Text = fileBrowser.FileName;

                /* Setear el Tooltip del path */                                
                toolTip.SetToolTip(fileText, fileBrowser.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
