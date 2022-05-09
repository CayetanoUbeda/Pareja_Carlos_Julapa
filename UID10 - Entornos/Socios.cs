using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UID10___Entornos
{
    class Socios
    {
        string nombre, apellidos, telefono;
        public Socios(string nombre, string apellidos, string telefono)
        {
            if(nombre != null && apellidos != null && telefono != null)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.telefono = telefono;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
    }
}
