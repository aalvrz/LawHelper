using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Honorarios
    {
        private long honorarios;
        private long abonos;
        private string fecha;
        private long gastos;

        public Honorarios()
        {


        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
