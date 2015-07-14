using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace sistemaBufetes.forms
{
    public partial class CaseEvidence : Form
    {
        private blc.Caso caso;
        private blc.Evidencia evidenciaActual;

        public CaseEvidence(blc.Caso caso)
        {
            this.caso = caso;
            
            InitializeComponent();
            
        }

        private void llenarLista()
        {
            string[] codigos = dal.ccEvidencia.obtenerIDs().ToArray();

            /* Popular la lista */
            evidenciaList.Items.AddRange(codigos);                       
        }

        private void CaseEvidence_Load(object sender, EventArgs e)
        {
            /* Mostrar el #accion del caso actual */
            tituloLabel.Text = tituloLabel.Text + caso.NumAccion;

            /* Cargar la lista de codigos de evidencias en el listbox */
            llenarLista();
        }

        private void evidenciaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Obtener la descripcion de la evidencia seleccionada */
            evidenciaActual = null;
            evidenciaActual = dal.ccEvidencia.buscarEvidencia(evidenciaList.SelectedItem.ToString());
            
            /* Desplegar la descripcion de la nueva evidencia seleccionada */
            descText.Text = evidenciaActual.Descripcion;
            
        }

        private void abrirBoton_Click(object sender, EventArgs e)
        {
            if (evidenciaList.SelectedItem == null)
                return;
            
            /* Abrir el archivo de evidencia seleccionado */
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo(evidenciaActual.Path);
            proc.Start();


        }
    }
}
