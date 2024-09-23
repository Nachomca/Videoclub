using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Videojuego : Ejemplar
    {
        public float duracion
        {
            get;
            set;
        }
        public String compañia
        {
            get;
            set;
        }

        public String es
        {
            get;
            set;
        } = "videojuego";

        public Videojuego(String titulo, String genero, String fecha, int edad, float duracion, String compañia) : base(
            titulo, genero, fecha, edad)
        {
            this.duracion = duracion;
            this.compañia = compañia;
        }

        public override String ToString()
        {
            return base.Titulo + "|" 
                               + base.genero + " | "
                               +base.fechaSalida + " | "
                               +base.edad + " | "
                               + this.duracion + " | " 
                               + this.compañia + " | "
                               +base.disponibilidad + " | "
                               +base.propietario;
        }
    }
}
