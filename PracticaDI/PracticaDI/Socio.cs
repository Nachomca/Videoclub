using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Socio
    {
        public String nombre { get; set; }
        public int id { get; set; }

        //CONSTRUCTORES
        public Socio()
        { 
        }

        public Socio(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

    }
}
