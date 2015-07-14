using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Caso
    {
        private string numAccion;
        private string accion;
        private string materia;
        private string oficina;
        private Bitacora bitacora;
        private Honorarios honorarios;
        private List<Persona> testigos;
        private List<Evidencia> evidencia;
        private blc.Persona cliente;
        private blc.Persona contraparte;
        private string observaciones;

        public Caso()
        {
            testigos = new List<Persona>();
            evidencia = new List<blc.Evidencia>();
            honorarios = new Honorarios();
            cliente = new Persona();
            contraparte = new Persona();
        }

        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        public Bitacora Bitacora
        {
            get { return bitacora; }
            set { bitacora = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public string NumAccion
        {
            get { return numAccion; }
            set { numAccion = value; }
        }

        public string Oficina
        {
            get { return oficina; }
            set { oficina = value; }
        }

        public List<Evidencia> Evidencia
        {
            get { return evidencia; }
            set { evidencia = value; }
        }

        public List<Persona> Testigos
        {
            get { return testigos; }
            set { testigos = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public Persona Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

    }
}
