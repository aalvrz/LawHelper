using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Articulo
    {
        private string codigo;
        private string nombre;
        private double costo;
        private string ubicacion;

        public Articulo()
        {
            
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
    }
}
