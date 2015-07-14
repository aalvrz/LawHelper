using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Grupo
    {
        private int cod;
        private string name;

        /* Permisos */
        string gestion;
        string casos;
        string clientes;
        string testigos;
        string inventario;
        string evidencia;
        string reportes;
        string config;

        public Grupo()
        {

        }

        public Grupo(int codigo, string nombre)
        {
            cod = codigo;
            name = nombre;
        }

        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }

        public string PermisoGestion
        {
            get { return gestion; }
            set { gestion = value; }
        }

        public string PermisoCasos
        {
            get { return casos; }
            set { casos = value; }
        }

        public string PermisoClientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        public string PermisoTestigos
        {
            get { return testigos; }
            set { testigos = value; }
        }

        public string PermisoInventario
        {
            get { return inventario; }
            set { inventario = value; }
        }

        public string PermisoEvidencia
        {
            get { return evidencia; }
            set { evidencia = value; }
        }

        public string PermisoReportes
        {
            get { return reportes; }
            set { reportes = value; }
        }

        public string PermisoConfiguracion
        {
            get { return config; }
            set { config = value; }
        }
    }
}
