using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Bitacora
    {
        private string idCaso;
        private string ficha;
        private string fecha;
        private string hora;
        private string folio;
        private string actuacion;
        private string notDemandante;
        private string notDemandado;
        private string obs;

        public Bitacora()
        {

        }

        public string Caso
        {
            get { return idCaso; }
            set { idCaso = value; }
        }

        public string Ficha
        {
            get { return ficha; }
            set { ficha = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Folio
        {
            get { return folio; }
            set { folio = value; }
        }

        public string Actuacion
        {
            get { return actuacion; }
            set { actuacion = value; }
        }

        public string NotificDemandado
        {
            get { return notDemandado; }
            set { notDemandado = value; }
        }

        public string NotificDemandante
        {
            get { return notDemandante; }
            set { notDemandante = value; }
        }

        public string Observaciones
        {
            get { return obs; }
            set { obs = value; }
        }




    }
}
