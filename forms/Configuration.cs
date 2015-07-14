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
    public partial class Configuration : Form
    {
        private bool camposValidados;
        
        public Configuration()
        {
            InitializeComponent();
        }

        private void validarCampos()
        {
            camposValidados = true;
            validador.Clear();

            /* Validar el nombre del bufete */
            if (bufeteText.Text == "")
            {
                camposValidados = false;
                validador.SetError(bufeteText, "Porfavor ingrese el nombre del bufete");
            }

            if ( bufeteText.Text.Length > 50 )
            {
                camposValidados = false;
                validador.SetError(bufeteText, "El nombre del bufete es muy largo.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Aplicar los cambios al sistema */
            validarCampos();
            if (camposValidados == true)
            {
                dal.ccBufete.actualizarBufete(bufeteText.Text, idiomaCombo.SelectedItem.ToString(), temaCombo.SelectedItem.ToString(), guardarFotografia());
                MessageBox.Show("Bufete actualizado exitosamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            appPath = System.IO.Directory.GetParent(Application.StartupPath).ToString() + "\\config\\";
            
            string directorioFinal = appPath + bufeteText.Text + "." + extension;

            /* Copiar la imagen al directorio */
            System.IO.File.Copy(fileBrowser.FileName, directorioFinal, true);            

            return directorioFinal;
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            bufeteText.Text = dal.ccBufete.obtenerNombre();
            logo.ImageLocation = dal.ccBufete.obtenerLogo();
            
            /* Cargar los ComboBoxes */
            idiomaCombo.SelectedItem = idiomaCombo.Items[0];
            temaCombo.SelectedItem = temaCombo.Items[0];
        }

        private void examinarBoton_Click(object sender, EventArgs e)
        {
            DialogResult = fileBrowser.ShowDialog();

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                /* Cargar la fotografia en la picture box */
                logo.ImageLocation = fileBrowser.FileName;
            }
        }
    }
}
