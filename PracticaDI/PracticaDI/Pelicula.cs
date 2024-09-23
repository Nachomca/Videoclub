using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Pelicula : Ejemplar
    {
        public float duracion
        {
            get;
            set;
        }
        public String director
        {
            get;
            set;
        }

        public String es
        {
            get;
            set;
        } = "pelicula";

        public Pelicula(String titulo, String genero, String fecha, int edad, float duracion, String director) : base(titulo, genero, fecha, edad)
        {
            this.duracion = duracion;
            this.director = director;
        }
        
        public override String ToString()
        {
            return base.Titulo + "|" 
                               + base.genero + " | "
                               +base.fechaSalida + " | "
                               +base.edad + " | "
                               + this.duracion + " | " 
                               + this.director + " | "
                               +base.disponibilidad + " | "
                               +base.propietario;
        }
    }
}
