using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Ejemplar
    {
        //MODIFICAR SETS (DESDE DENTRO) PARA PONER EL TAMAÑO MAXIMO
        public String Titulo
        {
            get;
            set;
        }
        public String genero
        {
            get;
            set;
        }
        public int edad
        {
            get;
            set;
        }
        public String fechaSalida
        {
            get;
            set;
        }

        public String disponibilidad
        {
            get;
            set;
        } = "disponible";
        
        public String propietario
        {
            get;
            set;
        } = "tienda";

        //CONSTRUCTORES
        public Ejemplar()
        {
        }

        public Ejemplar(String titulo, String genero, String fecha, int edad)
        {
            this.Titulo = titulo;
            this.genero = genero;
            this.fechaSalida = fecha;
            this.edad = edad;
        }
        
    }
}
