using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Persona
    {

        private string id;
        private string nombre;
        private string apellido;
        private string nacionalidad;        
        private int edad;
        private string estadoCivil;
        private string domicilio;
        private string telefono;
        private string celular;
        private string email;
        private string foto;

        public Persona()
        {
            
        }

        public Persona(string id)
        {
            this.id = id;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get
            { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
    
}
