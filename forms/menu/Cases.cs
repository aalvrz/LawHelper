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
    public partial class Cases : Form
    {

        private bool camposValidados = false;
        private blc.Caso casoActual;

        public Cases()
        {
            InitializeComponent();
        }

        private void resetFields()
        {
            numText.Text = null;
            accText.Text = null;
            matText.Text = null;
            ofText.Text = null;
            clientText.Text = null;
            parte2Text.Text = null;
            obsText.Text = null;
            testText.Text = null;
            testList.Items.Clear();
        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;

            /* Validar si el caso ya existe */
            if ( dal.ccCaso.casoExiste(numText.Text) == true )
            {
                validador.SetError(numText, "Este caso ya existe.");
                camposValidados = false;
            }

            /* Validar el # accion */
            if (numText.Text == "")
            {
                validador.SetError(numText, "Porfavor ingrese el # de accion.");
                camposValidados = false;
            }

            /* Validar la accion */
            if (accText.Text == "")
            {
                validador.SetError(accText, "Porfavor ingrese la accion.");
                camposValidados = false;
            }

            /* Validar la materia */
            if (matText.Text == "")
            {
                validador.SetError(matText, "Porfavor ingrese una materia.");
                camposValidados = false;
            }

            /* Validar la oficina */
            if (ofText.Text == "")
            {
                validador.SetError(ofText, "Porfavor ingrese la oficina.");
                camposValidados = false;
            }
            
            /* Validar el cliente */
            if ( dal.ccCliente.clienteExiste(clientText.Text) == false)
            {
                validador.SetError(clientText, "Porfavor ingrese un cliente valido y existente.");
                camposValidados = false;
            }


        }

        private void habilitarCampos()
        {
            numText.Enabled = true;
            accText.Enabled = true;
            ofText.Enabled = true;
            matText.Enabled = true;
            clientText.Enabled = true;
            parte2Text.Enabled = true;
            obsText.Enabled = true;
            testText.Enabled = true;
            testList.Enabled = true;
            addTest.Enabled = true;
            delTest.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = true;
            addButton.Enabled = false;
            mainButton.Text = "Agregar";
            bitButton.Enabled = false;
            evidButton.Enabled = false;

            /* Resetear los campos de texto */
            resetFields();
            habilitarCampos();
            validador.Clear();
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = false;
            addButton.Enabled = true;
            mainButton.Text = "Buscar";
            bitButton.Enabled = false;
            evidButton.Enabled = false;

            /* Resetear los campos de texto */
            resetFields();
            validador.Clear();

            /* Deshabilitar ciertos campos */
            accText.Enabled = false;
            matText.Enabled = false;
            ofText.Enabled = false;
            clientText.Enabled = false;
            parte2Text.Enabled = false;
            obsText.Enabled = false;
            testText.Enabled = false;
            testList.Enabled = false;
            addTest.Enabled = false;
            delTest.Enabled = false;
            testList.Items.Clear();            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarCaso();
                    break;

                case "Buscar":
                    buscarCaso();
                    break;
            }
        }

        private void agregarCaso()
        {
            /* Crear el objeto del caso */
            blc.Caso caso = new blc.Caso();

            /* Llenar sus propiedades */
            caso.NumAccion = numText.Text;
            caso.Accion = accText.Text;
            caso.Materia = matText.Text;
            caso.Oficina = ofText.Text;
            caso.Observaciones = obsText.Text;
            caso.Cliente = new blc.Persona(clientText.Text);
            

            /* Agregar la lista de testigos del caso */
            foreach (string item in testList.Items )                         
                caso.Testigos.Add(new blc.Persona(item));
           
            /* Finalmente, agregar el caso a la base de datos */
            dal.ccCaso.agregarCaso(caso);

            /* Agregar los testigos al caso en la BD */
            for (int i = 0; i < caso.Testigos.Count; i++)
                dal.cctestigosCaso.agregarTestigoACaso(caso, i);            

            MessageBox.Show("Caso agregado exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarPersonas();
        }

        private void buscarCaso()
        {
            casoActual = null;
            
            /* Obtener el caso de la base de datos */
            blc.Caso caso = dal.ccCaso.obtenerCaso(numText.Text);

            /* Si el caso no existe, notificar */
            if (caso.NumAccion == null)
            {
                MessageBox.Show("Caso no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            /* Llenar los campos necesarios */
            numText.Text = caso.NumAccion;
            accText.Text = caso.Accion;
            matText.Text = caso.Materia;
            ofText.Text = caso.Oficina;
            clientText.Text = caso.Cliente.ID;
            obsText.Text = caso.Observaciones;

            /* Obtener los testigos del caso */
            caso.Testigos = dal.cctestigosCaso.obtenerTestigosDeCaso(caso);

            /* Ingresarlos en la lista de testigos */
            foreach (blc.Persona testigo in caso.Testigos)
                testList.Items.Add(testigo.ID);

            /* Asignar el caso como caso actual */
            casoActual = caso;

            /* Habilitar controles */
            testList.Enabled = true;
            bitButton.Enabled = true;
            evidButton.Enabled = true;
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            if ( dal.ccTestigo.testigoExiste(testText.Text) )
            {
                /* Validar si el testigo ya esta en la lista */
                if (testigoEstaEnLista() == false)
                {
                    testList.Items.Add(testText.Text);
                    testText.Text = null;
                }
                else
                {
                    MessageBox.Show("El testigo ya esta en la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    testText.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Testigo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testText.Text = null;
            }
        }

        private bool testigoEstaEnLista()
        {
            /* Recorrer la lista */
            foreach (string item in testList.Items)
                if (item == testText.Text)
                    return true;

            return false;
        }

        private void delTest_Click(object sender, EventArgs e)
        {
            testList.Items.Remove(testList.SelectedItem);
        }

        private void bitButton_Click(object sender, EventArgs e)
        {
            /* Cargar la forma de bitacora y honorarios */
            ByH forma = new ByH(casoActual);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void cargarPersonas()
        {
            clientText.AutoCompleteCustomSource.Clear();
            testText.AutoCompleteCustomSource.Clear();
            parte2Text.AutoCompleteCustomSource.Clear();

            /* Cargar la lista de clientes y testigos para el AutoComplete */
            string[] idsClientes = dal.ccCliente.obtenerIDs().ToArray();
            string[] idsTestigos = dal.ccTestigo.obtenerIDs().ToArray();
            string[] idsContras = dal.ccContraparte.obtenerIDs().ToArray();

            /* Asignarlo como source al textbox */
            clientText.AutoCompleteCustomSource.AddRange(idsClientes);
            testText.AutoCompleteCustomSource.AddRange(idsTestigos);
            parte2Text.AutoCompleteCustomSource.AddRange(idsContras);
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            cargarPersonas();
        }

        private void evidButton_Click(object sender, EventArgs e)
        {
            /* Cargar la forma de evidencia */
            CaseEvidence forma = new CaseEvidence(casoActual);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

    }
}
