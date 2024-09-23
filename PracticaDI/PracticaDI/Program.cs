/*
 * PRACTICA FINAL C#
 * Título: CLUBSOFT
 * Autor: Ignacio Martínez de CArvajal Andrés
 * Última modificación: 28/11/2021 - 23:50
 * NOTA: Aún falla el cargar los ficheros
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PracticaDI
{
    class Program
    {
        //METODO PARA EL MENU PRINCIPAL
        static void menuPrincipal()
        {
            Console.WriteLine("________________MENÚ _________________");
            Console.WriteLine("|  1) Alta de ejemplar.");
            Console.WriteLine("|  2) Busqueda de ejemplares.");
            Console.WriteLine("|  3) Prestar ejemplar.");
            Console.WriteLine("|  4) Devolver ejemplar.");
            Console.WriteLine("|  5) Mostrar quien tiene prestado un ejemplar.");
            Console.WriteLine("|  6) Salir.");
            Console.WriteLine("|______________________________________\n");
        }
        
        //METODO PARA PEDIR LA OPCION DEL MENU PRINCIPAL
        static int pedirOpcion()
        {
            int op;

            do 
            {
                Console.WriteLine("Introduce una opcion: ");
                op = int.Parse(Console.ReadLine());

                if(op < 1 || op > 6)
                    Console.WriteLine("ERROR. El dato introducido no es correcto.");

            } while (op < 1 && op > 6);

            return op;
        }

        //MENU PARA EL ALTA
        static void menuAlta()
        {
            Console.WriteLine("___________MENÚ ALTA ____________");
            Console.WriteLine("|  1) Alta de videojuego.");
            Console.WriteLine("|  2) Alta de pelicula.");
            Console.WriteLine("|  3) Volver atrás.");
            Console.WriteLine("|_________________________________\n");
        }

        //OPCION PARA SELECCIONAR DE QUE SE QUIERE HACER EL ALTA
        static int pedirOpAlta()
        {
            int op;

            do
            {
                Console.WriteLine("Introduce una opcion: ");
                op = int.Parse(Console.ReadLine());

                if (op < 1 || op > 3)
                    Console.WriteLine("ERROR. El dato introducido no es correcto.");

            } while (op < 1 && op > 3);

            return op;
        }
        
        //MENU DE BUSQUEDA
        static void menuBusqueda()
        {
            Console.WriteLine("________ MENÚ DE BUSQUEDA _________");
            Console.WriteLine("|  1) Busqueda por tipo.");
            Console.WriteLine("|  2) Busqueda por título.");
            Console.WriteLine("|  3) Busqueda por género.");
            Console.WriteLine("|  4) Busqueda por disponibilidad.");
            Console.WriteLine("|  5) Volver atrás.");
            Console.WriteLine("|_________________________________\n");
        }
        
        //METODO PARA PEDIR LA OPCION DE BUSQUEDA
        static int pedirBusqueda()
        {
            int op;

            do
            {
                Console.WriteLine("Introduce una opcion: ");
                op = int.Parse(Console.ReadLine());

                if (op < 1 || op > 5)
                    Console.WriteLine("ERROR. El dato introducido no es correcto.");

            } while (op < 1 && op > 5);

            return op;
        }
        
        //METODO PARA PEDIR EL TIPO DE OBJETO A BUSCAR
        static String pedirTipo()
        {
            String op;
            
            do
            {
                Console.WriteLine("¿Película o videojuego?: ");
                op = Console.ReadLine();

                if (op != "videojuego" && op != "VIDEOJUEGO" && op != "pelicula" && op != "PELICULA")
                    Console.WriteLine("ERROR. El dato introducido no es correcto.");

            } while (op != "videojuego" && op != "VIDEOJUEGO" && op != "pelicula" && op != "PELICULA");
            
            return op;
        }
        
        //METODO PARA PEDIR EL TITULO/GENERO/DISPONIBILIDAD DEL EJEMPLAR O NOMBRE DE SOCIO
        static String pedirTituloGenero(int i)
        {
            String op;

            if (i == 0)
            {
                do
                {
                    Console.WriteLine("Introduce el título del ejemplar: ");
                    op = Console.ReadLine();

                    if (op == "" && op == " ")
                        Console.WriteLine("ERROR. El campo está vacío.");

                } while (op == "" && op == " ");

                return op;
            }
            else if( i == 1)
            {
                do
                {
                    Console.WriteLine("Introduce el genero del ejemplar: ");
                    op = Console.ReadLine();

                    if (op == "" && op == " ")
                        Console.WriteLine("ERROR. El campo está vacío.");

                } while (op == "" && op == " ");

                return op;
            }
            else if( i == 2)
            {
                do
                {
                    Console.WriteLine("Introduce la disponibilidad del ejemplar (disponible|alquilado): ");
                    op = Console.ReadLine();

                    if (op != "disponible" && op != "DISPONIBLE" && op != "alquilado" && op != "ALQUILADO")
                        Console.WriteLine("ERROR. Debes introducir si está disponible o alquilado.");

                } while (op != "disponible" && op != "DISPONIBLE" && op != "alquilado" && op != "ALQUILADO");

                return op;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce el nombre del socio al que se le va a alquilar la película: ");
                    op = Console.ReadLine();

                    if (op == "" && op == " ")
                        Console.WriteLine("ERROR. El campo está vacío.");

                } while (op == "" && op == " ");

                return op;
            }
        }

        //METODO PARA COMPROBAR SI QUIERE USAR VARIOS FILTRADOS AL MISMO TIEMPO O NO
        static String pedirFiltrado()
        {
            String a;

            do
            {
                Console.WriteLine("¿Desea usar varios filtrados? (si|no): ");
                a = Console.ReadLine();

                if (a != "si" && a != "SI" && a != "no" && a != "NO")
                    Console.WriteLine("ERROR. Debe introducir si o no.");

            } while (a != "si" && a != "SI" && a != "no" && a != "NO");

            return a;
        }
        
        //METODO PARA VER QUE FILTRADOS QUIERE AÑADIR
        static void pedirFiltros(Fondo fondo, int contGen)
        {
            String a;
            int b1 = 0, b2 = 0, b3 = 0, b4 = 0; //banderas para ver si se aplican los filtros
            List <Ejemplar> listAux = new List<Ejemplar>();

            do
            {
                Console.WriteLine("¿Desea filtrar por tipo? (si|no): ");
                a = Console.ReadLine();

                if (a != "si" && a != "SI" && a != "no" && a != "NO")
                    Console.WriteLine("ERROR. Debe introducir si o no.");

            } while (a != "si" && a != "SI" && a != "no" && a != "NO");

            if (a == "SI" || a == "si")
            {
                listAux = fondo.aplicarFiltro(1, contGen);
                b1 = 1;
            }
            else
            {
                b1 = 0;
            }

            do
            {
                Console.WriteLine("¿Desea filtrar por titulo? (si|no): ");
                a = Console.ReadLine();

                if (a != "si" && a != "SI" && a != "no" && a != "NO")
                    Console.WriteLine("ERROR. Debe introducir si o no.");

            } while (a != "si" && a != "SI" && a != "no" && a != "NO");

            if (a == "SI" || a == "si")
            {
                listAux = fondo.aplicarFiltro(2, contGen);
                b2 = 1;
            }
            else
            {
                b2 = 0;
            }

            do
            {
                Console.WriteLine("¿Desea filtrar por genero? (si|no): ");
                a = Console.ReadLine();

                if (a != "si" && a != "SI" && a != "no" && a != "NO")
                    Console.WriteLine("ERROR. Debe introducir si o no.");

            } while (a != "si" && a != "SI" && a != "no" && a != "NO");

            if (a == "SI" || a == "si")
            {
                listAux = fondo.aplicarFiltro(3, contGen);
                b3 = 1;
            }
            else
            {
                b3 = 0;
            }

            do
            {
                Console.WriteLine("¿Desea filtrar por disponibilidad? (si|no): ");
                a = Console.ReadLine();

                if (a != "si" && a != "SI" && a != "no" && a != "NO")
                    Console.WriteLine("ERROR. Debe introducir si o no.");

            } while (a != "si" && a != "SI" && a != "no" && a != "NO");

            if (a == "SI" || a == "si")
            {
                listAux = fondo.aplicarFiltro(4, contGen);
                b4 = 1;
            }
            else
            {
                b4 = 0;
            }

            if (b1 == 0 && b2 == 0 && b3 == 0 && b4 == 0) //si no se ha aplicado ningun filtro
            {
                Console.WriteLine("ERROR. No se ha aplicado ningún filtro.");
            }
            else
            {
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (listAux[i] is Videojuego)
                    {
                        Videojuego ej = (Videojuego)listAux[i];
                        Console.WriteLine(ej.ToString());
                    }
                    else
                    {
                        Pelicula ej = (Pelicula)listAux[i];
                        Console.WriteLine(ej.ToString());
                    }
                }
            }
        }

        //METODO PARA COMPROBAR SI QUIERE SALIR/VOLVER ATRAS
        static int seguro( int bandera)
        {
            String op;

            if (bandera == 0)
            {
                do
                {
                    Console.WriteLine("¿Estás seguro que deseas salir? (escribe si o no)");
                    op = Console.ReadLine();

                    if (op != "si" && op != "no" && op != "SI" && op != "NO")
                        Console.WriteLine("ERROR. El dato introducido no es correcto.");

                } while (op != "si" && op != "no" && op != "SI" && op != "NO");

                if (op == "si" || op == "SI")
                    return 6;
                else
                    return 0;
            }
            else if(bandera == 1)
            {
                do
                {
                    Console.WriteLine("¿Estás seguro que deseas volver atrás? (escribe si o no)");
                    op = Console.ReadLine();

                    if (op != "si" && op != "no" && op != "SI" && op != "NO")
                        Console.WriteLine("ERROR. El dato introducido no es correcto.");

                } while (op != "si" && op != "no" && op != "SI" && op != "NO");

                if (op == "si" || op == "SI")
                    return 3;
                else
                    return 0;
            }
            else
            {
                do
                {
                    Console.WriteLine("¿Estás seguro que deseas volver atrás? (escribe si o no)");
                    op = Console.ReadLine();

                    if (op != "si" && op != "no" && op != "SI" && op != "NO")
                        Console.WriteLine("ERROR. El dato introducido no es correcto.");

                } while (op != "si" && op != "no" && op != "SI" && op != "NO");

                if (op == "si" || op == "SI")
                    return 5;
                else
                    return 0;
            }

        }
        
        //MAIN PRINCIPAL
        static void Main(string[] args)
        {
            Socio socio1 = new Socio("Pepe", 1);
            Socio socio2 = new Socio("Juan", 2);
            Socio socio3 = new Socio("Ines", 3);

            Fondo fondo = new Fondo();

            int op = 0; //opcion del menu principal
            int numAltaVideojuego = 0; //contador para saber cuantas altas de videojuego se han hecho
            int numAltaPelicula = 0; //contador para saber cuantas altas de peliculas se han hecho
            int contGen = 0; //contador general para contar todos los elementos de la lista
            int contAux = 0; //contador aux para ver si sobrepasa el array

            fondo.rellenaArray();
            numAltaVideojuego = 8;
            contGen = 8;
            contAux = 8;

            Console.WriteLine("CLUBSOFT. Programa de gestión de videoclubs.\n\n");
            
            fondo.cargarFichero(); //RECORRIENDO BYTE A BYTE
            
            do
            {
                menuPrincipal();

                op = pedirOpcion();

                switch (op)
                {
                    case 1:
                        {
                            int op2 = 0; //opcion del menu de altas

                            do
                            {
                                menuAlta();

                                op2 = pedirOpAlta();

                                switch (op2)
                                {
                                    case 1:
                                    {
                                        if(contAux < 10) 
                                        {
                                            fondo.altaVideojuego(contGen);
                                            numAltaVideojuego++;
                                            contGen++;
                                            contAux++;
                                        }
                                        else
                                        {
                                            fondo.ampliaArray();
                                            contAux = 0;
                                            fondo.altaVideojuego(contGen);
                                            numAltaVideojuego++;
                                            contGen++;
                                            contAux++;
                                        }

                                        break;
                                    }
                                    case 2:
                                    {
                                        if(contAux < 10)
                                        {
                                            fondo.altaPelicula(contGen);
                                            numAltaPelicula++;
                                            contGen++;
                                            contAux++;
                                        }
                                        else
                                        {
                                            fondo.ampliaArray();
                                            contAux = 0;
                                            fondo.altaPelicula(contGen);
                                            numAltaPelicula++;
                                            contGen++;
                                            contAux++;
                                        }

                                        break;
                                    }
                                    case 3:
                                        op2 = seguro(1);
                                        break;
                                }
                                
                                if(contGen > 1)
                                    fondo.ordenaArray(contGen);
                                
                            } while(op2 != 3);

                            break;
                        }
                    case 2:
                    {
                        fondo.mostrarLista(contGen);
                        
                        int op3 = 0; //opcion del menu de busqueda

                        String filtrado = pedirFiltrado();

                        if (filtrado == "NO" || filtrado == "no")
                        {
                            do
                            {
                                menuBusqueda();

                                op3 = pedirBusqueda();

                                switch (op3)
                                {
                                    case 1:
                                    {
                                        String tipo = pedirTipo();

                                        if (tipo == "videojuego" || tipo == "VIDEOJUEGO")
                                            fondo.mostrarVideojuego(contGen);
                                        else
                                            fondo.mostrarPelicula(contGen);

                                        break;
                                    }
                                    case 2:
                                    {
                                        //ARREGLAR QUE COMPRUEBE ANTES SI ESTÁ VACIA LA LISTA
                                        String titulo = pedirTituloGenero(0);

                                        fondo.muestraTituloGenero(titulo, 0, contGen);

                                        break;
                                    }
                                    case 3:
                                    {
                                        String genero = pedirTituloGenero(1);

                                        fondo.muestraTituloGenero(genero, 1, contGen);

                                        break;
                                    }
                                    case 4:
                                    {
                                        String disponibilidad = pedirTituloGenero(2);

                                        fondo.muestraTituloGenero(disponibilidad, 2, contGen);

                                        break;
                                    }
                                    case 5:
                                        op3 = seguro(2);
                                        break;
                                }
                            } while (op3 != 5);
                            
                        }
                        else //si desea usar varios filtros
                        {
                            pedirFiltros(fondo, contGen);
                        }

                        break;
                    }
                    case 3:
                    {
                        String nombre = pedirTituloGenero(3);
                        Socio aux = fondo.buscarSocio(nombre, socio1, socio2, socio3);
                        fondo.prestarEjemplar(aux);
                        break;
                    }
                    case 4:
                    {
                        fondo.devolverEjemplar();
                        break;
                    }
                    case 5:
                    {
                        fondo.mostrarPrestados();
                        break;
                    }
                    case 6: op = seguro(0);
                        break;
                }

            } while(op != 6);

            fondo.guardarFichero(contGen); //GUARDANDO BYTE A BYTE
        }
    }
}
