using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.blc
{
    public class Usuario
    {
        private string codigo;
        private string pass;
        private string name;
        private string lastname;
        private string mobile;
        private string mail;
        private Grupo group;
        private string super;

        public Usuario()
        {
            group = new Grupo();
        }

        public Usuario(string codigo, string password )
        {
            group = new Grupo();
            this.codigo = codigo;
            pass = password;
        }

        public string Codigo
        {
            get
            { return codigo; }
            set
            { codigo = value; }
        }

        public string Password
        {
            get { return pass; }
            set { pass = value;  }
        }

        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }

        public string Apellido
        {
            get { return lastname; }
            set { lastname = value;  }
        }

        public Grupo Grupo
        {
            get { return group; }
            set { group = value; }
        }

        public string Email
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Celular
        {
            get { return mobile; }
            set { mobile = value;  }
        }

        public string Superusuario
        {
            get { return super; }
            set { super = value; }
        }

        
    }
}
