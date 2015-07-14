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
    public partial class Groups : Form
    {
        private bool camposValidados = false;

        public Groups()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = true;
            addButton.Enabled = false;
            mainButton.Text = "Agregar";

            resetFields();
            habilitarCampos();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = false;
            addButton.Enabled = true;
            mainButton.Text = "Buscar";

            resetFields();
            nameText.Enabled = false;

            gestionCheck.Enabled = false;
            casosCheck.Enabled = false;
            clientesCheck.Enabled = false;
            testigosCheck.Enabled = false;
            inventarioCheck.Enabled = false;
            evidenciaCheck.Enabled = false;
            reportesCheck.Enabled = false;
            configCheck.Enabled = false;
        }

        private void resetFields()
        {
            codigoText.Text = null;
            nameText.Text = null;

            gestionCheck.Checked = false;
            casosCheck.Checked = false;
            clientesCheck.Checked = false;
            testigosCheck.Checked = false;
            inventarioCheck.Checked = false;
            evidenciaCheck.Checked = false;
            reportesCheck.Checked = false;
            configCheck.Checked = false;
        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;
            
            if (codigoText.Text == null)
            {
                validador.SetError(codigoText, "Ingrese un codigo para el grupo.");
                camposValidados = false;
            }

            if (nameText.Text == null)
            {
                validador.SetError(nameText, "Ingrese un nombre para el grupo.");
                camposValidados = false;
            }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarGrupo();
                    break;

                case "Buscar":
                    buscarGrupo();
                    break;
            }
        }

        private void agregarGrupo()
        {
            blc.Grupo grupo = new blc.Grupo( int.Parse(codigoText.Text), nameText.Text);

            /* Agregar los permisos al objeto */
            if (gestionCheck.Checked == true)
                grupo.PermisoGestion = "Y";
            else
                grupo.PermisoGestion = "N";

            if (casosCheck.Checked == true)
                grupo.PermisoCasos = "Y";
            else
                grupo.PermisoCasos = "N";

            if (clientesCheck.Checked == true)
                grupo.PermisoClientes = "Y";
            else
                grupo.PermisoClientes = "N";

            if (testigosCheck.Checked == true)
                grupo.PermisoTestigos = "Y";
            else
                grupo.PermisoTestigos = "N";

            if (inventarioCheck.Checked == true)
                grupo.PermisoInventario = "Y";
            else
                grupo.PermisoInventario = "N";

            if (evidenciaCheck.Checked == true)
                grupo.PermisoEvidencia = "Y";
            else
                grupo.PermisoEvidencia = "N";

            if (reportesCheck.Checked == true)
                grupo.PermisoReportes = "Y";
            else
                grupo.PermisoReportes = "N";

            if (configCheck.Checked == true)
                grupo.PermisoConfiguracion = "Y";
            else
                grupo.PermisoConfiguracion = "N";

            /* Agregar el grupo a la base de datos */
            dal.ccGrupo.agregarGrupo(grupo);

            MessageBox.Show("Grupo agregado exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
        }

        private void buscarGrupo()
        {
            blc.Grupo grupo = new blc.Grupo();
            
            /* Buscar el grupo en la BD */
            grupo = dal.ccGrupo.obtenerGrupo(null, codigoText.Text);

            /* Mostrar mensaje si no se encontro grupo */
            if (grupo.Nombre == null)
            {
                resetFields();
                MessageBox.Show("Grupo no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            /* Desplegar la info en los campos */
            nameText.Text = grupo.Nombre;

            if (grupo.PermisoGestion == "Y")
                gestionCheck.Checked = true;
            else
                gestionCheck.Checked = false;

            if (grupo.PermisoCasos == "Y")
                casosCheck.Checked = true;
            else
                casosCheck.Checked = false;

            if (grupo.PermisoClientes == "Y")
                clientesCheck.Checked = true;
            else
                clientesCheck.Checked = false;

            if (grupo.PermisoTestigos == "Y")
                testigosCheck.Checked = true;
            else
                testigosCheck.Checked = false;

            if (grupo.PermisoInventario == "Y")
                inventarioCheck.Checked = true;
            else
                inventarioCheck.Checked = false;

            if (grupo.PermisoEvidencia == "Y")
                evidenciaCheck.Checked = true;
            else
                evidenciaCheck.Checked = false;

            if (grupo.PermisoReportes == "Y")
                reportesCheck.Checked = true;
            else
                reportesCheck.Checked = false;

            if (grupo.PermisoConfiguracion == "Y")
                configCheck.Checked = true;
            else
                configCheck.Checked = false;
        }

        private void habilitarCampos()
        {
            codigoText.Enabled = true;
            nameText.Enabled = true;

            gestionCheck.Enabled = true;
            casosCheck.Enabled = true;
            clientesCheck.Enabled = true;
            testigosCheck.Enabled = true;
            inventarioCheck.Enabled = true;
            evidenciaCheck.Enabled = true;
        }
    }
}
