using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Evidencia
    {
        private string codigo;
        private string caso;
        private string descripcion;
        private string path;

        public Evidencia()
        {

        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Caso
        {
            get { return caso; }
            set { caso = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }


    }
}
