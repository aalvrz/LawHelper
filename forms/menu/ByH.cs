using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace sistemaBufetes.forms
{
    public partial class ByH : Form
    {
        private blc.Caso caso;

        /* Controles de Bases de Datos */
        SqlDataAdapter bitAdapter;
        DataTable bitTable;

        SqlDataAdapter honAdapter;
        DataTable honTable;

        private int filaFechaSeleccionada;

        public ByH(blc.Caso caso)
        {
            this.caso = caso;
            InitializeComponent();

            /* Asignar el #Accion del caso como titulo */
            accionLabel.Text += caso.NumAccion;

            /* Llenar la tabla de bitacora */
            llenarBitacora();

            /* Llenar la tabla de honorarios */
            llenarHonorarios();

            toolTip.SetToolTip(updateBit, "Guardar cambios");
            toolTip.SetToolTip(updateHon, "Guardar cambios");
        }

        private void llenarBitacora()
        {            
            string strSQL = "SELECT * FROM Bitacora WHERE idCaso = '" + caso.NumAccion + "'";            

            bitAdapter = new SqlDataAdapter(strSQL, Program.dt.ConnectionStr);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(bitAdapter);

            // Populate a new data table and bind it to the BindingSource.
            bitTable = new DataTable();
            bitTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            bitAdapter.Fill(bitTable);

            bitBindSource.DataSource = bitTable;

            // Resize the DataGridView columns to fit the newly loaded content.
            bitacoraGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                        
            // finally bind the data to the grid
            bitacoraGrid.DataSource = bitBindSource;

            // Esconder la columna del idCaso y del idRegistro
            bitacoraGrid.Columns[0].Visible = false;
            bitacoraGrid.Columns[1].Visible = false;

            // Alargar la columna de observaciones
            bitacoraGrid.Columns[9].Width = 280;

            /* Cambiar los nombres de los headers de las notificaciones */
            bitacoraGrid.Columns[7].HeaderText = "Notificacion Demandante";
            bitacoraGrid.Columns[8].HeaderText = "Notificacion Demandadado";

            /* Centrar los headers de las columnas */
            for ( int i = 0; i < bitacoraGrid.Columns.Count; i++ )
                bitacoraGrid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            
            
        }

        private void llenarHonorarios()
        {
            string strSQL = "SELECT * FROM Honorarios WHERE idCaso = '" + caso.NumAccion + "'";
            
            honAdapter = new SqlDataAdapter(strSQL, Program.dt.ConnectionStr);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(honAdapter);

            // Populate a new data table and bind it to the BindingSource.
            honTable = new DataTable();
            honTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            honAdapter.Fill(honTable);

            honBindSource.DataSource = honTable;

            // Resize the DataGridView columns to fit the newly loaded content.
            honorariosGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            // finally bind the data to the grid
            honorariosGrid.DataSource = honBindSource;

            // Esconder la columna del idCaso
            honorariosGrid.Columns[0].Visible = false;
            honorariosGrid.Columns[1].Visible = false;

            /* Centrar los headers de las columnas */
            for (int i = 0; i < honorariosGrid.Columns.Count; i++)
                honorariosGrid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void bitacoraGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            /* Evento cuando ocurre un error en los datos */
            if (e.Context == DataGridViewDataErrorContexts.Commit)
                Program.main.statusStrip.Text = "Error, porfavor corrija el dato en la celda (" + e.RowIndex + "," + e.ColumnIndex + ").";
                //MessageBox.Show("Error, porfavor corrija el dato en la celda (" + e.RowIndex + "," + e.ColumnIndex + ").","Error",MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            
        }
        
        private void addReg_Click(object sender, EventArgs e)
        {
            /* Actualizar la tabla */
            bitAdapter.Update(bitTable);

            /* Mostrar mensaje de exito */
            MessageBox.Show("Cambios efectuados exitosamente en la base de datos.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void updateHon_Click(object sender, EventArgs e)
        {
            /* Actualizar la tabla */
            honAdapter.Update(honTable);
            
            /* Mostrar mensaje de exito */
            MessageBox.Show("Cambios efectuados exitosamente en la base de datos.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void honorariosGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /* Agregar el mismo codigo del caso a la nueva fila */
            honorariosGrid.Rows[e.RowIndex].Cells["idCaso"].Value = caso.NumAccion;

        }

        private void bitacoraGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /* Agregar el mismo codigo del caso a la nueva fila */
            bitacoraGrid.Rows[e.RowIndex].Cells["idCaso"].Value = caso.NumAccion;            
            
        }

        private void ByH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bUFETEDataSet.Bitacora' table. You can move, or remove it, as needed.
            

        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void bitacoraGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                datePicker.Enabled = true;
                filaFechaSeleccionada = e.RowIndex;
            }
            else
                datePicker.Enabled = false;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            /* Asignar el nuevo valor a la celda de fecha */
            bitacoraGrid[3, filaFechaSeleccionada].Value = datePicker.Value;
        } 

    }
}
