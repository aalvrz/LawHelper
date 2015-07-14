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
    public partial class Inventory : Form
    {
        private bool camposValidados = false;

        public Inventory()
        {
            InitializeComponent();
        }

        private void resetFields()
        {
            codigoText.Text = null;
            nombreText.Text = null;
            costoText.Text = null;
            ubicacionText.Text = null;

        }

        private void validarCampos()
        {
            validador.Clear();
            camposValidados = true;

            /* Validar el codigo del articulo */
            if (codigoText.Text.Length > 10)
            {
                camposValidados = false;
                validador.SetError(codigoText, "El codigo no puede contener mas de 10 caracteres");
            }

            if (codigoText.Text == "")
            {
                camposValidados = false;
                validador.SetError(codigoText, "Porfavor ingrese un codigo.");
            }

            /* Validar el nombre del articulo */
            if (nombreText.Text == "")
            {
                camposValidados = false;
                validador.SetError(nombreText, "Porfavor ingrese un nombre.");
            }

        }

        private void habilitaTodosLosCampos()
        {
            codigoText.Enabled = true;
            nombreText.Enabled = true;
            costoText.Enabled = true;
            ubicacionText.Enabled = true;

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            /* Estados de botones */
            findButton.Enabled = false;
            addButton.Enabled = true;

            /* Campos */
            nombreText.Enabled = false;
            costoText.Enabled = false;
            ubicacionText.Enabled = false;

            /* Main button y reset */
            mainButton.Text = "Buscar";
            resetFields();
            validador.Clear();

            /* Habilitar auto complete */
            codigoText.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            /* Estado de botones */
            habilitaTodosLosCampos();
            addButton.Enabled = false;
            findButton.Enabled = true;

            /* Main button y resets */
            mainButton.Text = "Agregar";
            resetFields();
            validador.Clear();

            /* Deshabilitar auto-complete */
            codigoText.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cargarArticulos()
        {
            codigoText.AutoCompleteCustomSource.Clear();
            
            /* Cargar los articulos para el auto-complete */
            string[] codigos = dal.ccArticulo.obtenerIds().ToArray();
            codigoText.AutoCompleteCustomSource.AddRange(codigos);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (mainButton.Text)
            {
                case "Agregar":
                    validarCampos();
                    if (camposValidados == true)
                        agregarArticulo();
                    break;

                case "Buscar":
                    buscarArticulo();
                    break;
            }
        }

        private void agregarArticulo()
        {
            /* Definir el objeto */
            blc.Articulo articulo = new blc.Articulo();

            articulo.Codigo = codigoText.Text;
            articulo.Nombre = nombreText.Text;
            if (costoText.Text != "")
                articulo.Costo = double.Parse(costoText.Text.ToString());
            else
                articulo.Costo = 0;

            articulo.Ubicacion = ubicacionText.Text;

            dal.ccArticulo.agregarArticulo(articulo);

            MessageBox.Show("Articulo agregado exitosamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetFields();
            cargarArticulos();
        }

        private void buscarArticulo()
        {
            /* Instanciar un objeto articulo */
            blc.Articulo articulo = new blc.Articulo();

            articulo = dal.ccArticulo.buscarArticulo(codigoText.Text);

            if (articulo.Codigo == null)
            {
                MessageBox.Show("Articulo no existe.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
                return;
            }

            resetFields();
            /* Mostrar los datos */
            codigoText.Text = articulo.Codigo;
            nombreText.Text = articulo.Nombre;
            costoText.Text = articulo.Costo.ToString();
            ubicacionText.Text = articulo.Ubicacion;

        }

    }
}
