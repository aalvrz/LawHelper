using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaBufetes
{
    public partial class Loader : Form
    {
        
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {                                                
            reloj.Enabled = true;
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            reloj.Enabled = false;            
            this.Hide();

            /* Cargar la pantalla principal */
            Program.main = new forms.Main();
            Program.main.Show();
            Program.main.Enabled = false;

            /* Cargar la pantalla de login */
            Login login = new Login(Program.main);                        
            login.Show();
            
        }
    }
}
