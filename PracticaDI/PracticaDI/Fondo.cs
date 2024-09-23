using System;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Fondo
    {
        private const int TAM = 10;

        Ejemplar[] lista = new Ejemplar[TAM];

        private List<Ejemplar> listAux; //lista aux para filtrar

        //METODO PARA PEDIR EL NOMBRE DEL EJEMPLAR
        private String pedirNombre(int bandera)
        {
            String nom;

            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce el nombre del videojuego: ");
                    nom = Console.ReadLine();
                    
                    if(nom.Length > 20)
                        Console.WriteLine("ERROR. El nombre supera el nº max de caracteres.");
                    
                } while (nom.Length > 20);

                return nom;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce el nombre de la pelicula: ");
                    nom = Console.ReadLine();
                    
                    if(nom.Length > 20)
                        Console.WriteLine("ERROR. El nombre supera el nº max de caracteres.");
                    
                } while (nom.Length > 20);
                
                return nom;
            }
        }

        //METODO PARA PEDIR EL TIPO
        private String pedirTipo(int bandera)
        {
            String gen;

            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce el genero del videojuego: ");
                    gen = Console.ReadLine();
                    
                    if(gen.Length > 15)
                        Console.WriteLine("ERROR. El genero supera el nº max de caracteres.");
                    
                } while (gen.Length > 15);

                return gen;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce el genero de la pelicula: ");
                    gen = Console.ReadLine();
                    
                    if(gen.Length > 15)
                        Console.WriteLine("ERROR. El genero supera el nº max de caracteres.");
                    
                } while (gen.Length > 15);
                
                return gen;
            }
        }

        //METODO PARA PEDIR FECHA
        private String pedirFecha(int bandera)
        {
            String fecha;

            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce la fecha del videojuego (DD/MM/AA): ");
                    fecha = Console.ReadLine();
                    
                    if(fecha.Length > 8)
                        Console.WriteLine("ERROR. La fecha no tiene el formato correcto.");
                    
                } while (fecha.Length > 8);

                return fecha;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce la fecha de la pelicula (DD/MM/AA): ");
                    fecha = Console.ReadLine();
                    
                    if(fecha.Length > 8)
                        Console.WriteLine("ERROR. La fecha no tiene el formato correcto.");
                    
                } while (fecha.Length > 8);
                
                return fecha;
            }
        }

        //METODO PARA PEDIR LA EDAD
        private int pedirEdad(int bandera)
        {
            int edad;
            
            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce la calificación de edad del videojuego: ");
                    edad = int.Parse(Console.ReadLine());
                    
                    if(edad < 3 || edad > 18)
                        Console.WriteLine("ERROR. La calificación no es correcta.");
                    
                } while (edad < 3 && edad > 18);

                return edad;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce la calificación de edad de la pelicula: ");
                    edad = int.Parse(Console.ReadLine());
                    
                    if(edad < 3 || edad > 18)
                        Console.WriteLine("ERROR. La calificación no es correcta.");
                    
                } while (edad < 3 && edad > 18);
                
                return edad;
            }
        }

        //METODO PARA PEDIR LA DURACION
        private float pedirDuracion(int bandera)
        {
            float dur;
            
            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce la duración del videojuego (min): ");
                    dur = float.Parse(Console.ReadLine());
                    
                    if(dur < 60 && dur > 240)
                        Console.WriteLine("ERROR. La duración no es correcta.");
                    
                } while (dur < 60 && dur > 240);

                return dur;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce la duración de la película (min): ");
                    dur = float.Parse(Console.ReadLine());
                    
                    if(dur < 60 && dur > 240)
                        Console.WriteLine("ERROR. La duración no es correcta.");
                    
                } while (dur < 60 && dur > 240);
                
                return dur;
            }
        }

        //METODO PARA PEDIR LA COMPAÑIA DEL VIDEOJUEGO O EL DIRECTOR DE LA PELICULA
        private String pedirCompañiaDirector(int bandera)
        {
            String fecha;

            if(bandera == 0)
            {
                do
                {
                    Console.WriteLine("Introduce el nombre de la compañia del videojuego: ");
                    fecha = Console.ReadLine();
                    
                    if(fecha.Length > 20)
                        Console.WriteLine("ERROR. El nombre de la compañia supera el nº max de caracteres.");
                    
                } while (fecha.Length > 20);

                return fecha;
            }
            else
            {
                do
                {
                    Console.WriteLine("Introduce el nombre del director de la pelicula: ");
                    fecha = Console.ReadLine();
                    
                    if(fecha.Length > 20)
                        Console.WriteLine("ERROR. El nombre del director supera el nº max de caracteres.");
                    
                } while (fecha.Length > 20);
                
                return fecha;
            }
        }
        public void altaVideojuego(int i)
        {
            int bandera = 0; //para llamar a los datos indicando que es un videojuego

            String nombre = pedirNombre(bandera);
            String tipo = pedirTipo(bandera);
            String fecha = pedirFecha(bandera);
            int edad = pedirEdad(bandera);
            float duracion = pedirDuracion(bandera);
            String compañia = pedirCompañiaDirector(bandera);

            Videojuego vid = new Videojuego(nombre, tipo, fecha, edad, duracion, compañia);

            //if(i < TAM)
                lista[i] = vid;
            //else
                //Console.WriteLine("HAY QUE HACER EL ARRAY MAS GRANDE");
        }

        public void altaPelicula(int i)
        {
            int bandera = 1; //para llamar a los datos indicando que es una pelicula

            String nombre = pedirNombre(bandera);
            String tipo = pedirTipo(bandera);
            String fecha = pedirFecha(bandera);
            int edad = pedirEdad(bandera);
            float duracion = pedirDuracion(bandera);
            String director = pedirCompañiaDirector(bandera);
            
            Pelicula pel = new Pelicula(nombre, tipo, fecha, edad, duracion, director);

            //if(i < TAM)
                lista[i] = pel;
            //else
                //Console.WriteLine("HAY QUE HACER EL ARRAY MAS GRANDE");
        }

        //METODO PARA MOSTRAR LA LISTA ENTERA
        public void mostrarLista(int contadorGen)
        {
            int contVid = 1; //contador de videojuegos
            int contPel = 1; //contador de peliculas
            int conGen = 0; //contador de elementos de la lista

            for (int i = 0; i < contadorGen; i++)
            {
                if (lista[i] != null)
                {
                    conGen++;
                }
            }

            if (conGen > 0)
            {
                for (int i = 0; i < conGen; i++)
                {
                    if (lista[i] is Videojuego)
                    {
                        Console.WriteLine("Videojuego " + contVid + ":");
                        Console.WriteLine(lista[i].ToString() + "\n");
                        contVid++;
                    }
                    else
                    {
                        Console.WriteLine("Pelicula " + contPel + ":");
                        Console.WriteLine(lista[i].ToString() + "\n");
                        contPel++;
                    }
                }
            }else
                Console.WriteLine("ERROR. No hay elementos en la lista.");
        }

        //METODO PARA MOSTRAR SOLO LOS VIDEOJEUGOS
        public void mostrarVideojuego(int contadorGen)
        {
            int contVid = 0; //contador de videojuegos
            int conGen = 0; //contador de elementos de la lista

            for (int i = 0; i < contadorGen; i++) //SE PUEDE USAR COUNT
            {
                if (lista[i] != null)
                {
                    conGen++;
                }
            }

            if (conGen > 0)
            {
                for (int i = 0; i < conGen; i++)
                {
                    if (lista[i] is Videojuego)
                    {
                        Console.WriteLine("Videojuego " + (contVid + 1)+ ":");
                        Console.WriteLine(lista[i].ToString() + "\n");
                        contVid++;
                    }
                }
                
                if(contVid == 0)
                    Console.WriteLine("ERROR. No hay videojuegos en la lista.");
            }else
                Console.WriteLine("ERROR. No hay elementos en la lista.");
        }

        //METODO PARA MOSTRAR SOLO LAS PELICULAS
        public void mostrarPelicula(int contadorGen)
        {
            int contPel = 0; //contador de peliculas
            int conGen = 0; //contador de elementos de la lista

            for (int i = 0; i < contadorGen; i++)
            {
                if (lista[i] != null)
                {
                    conGen++;
                }
            }

            if (conGen > 0)
            {
                for (int i = 0; i < conGen; i++)
                {
                    if (lista[i] is Pelicula)
                    {
                        Console.WriteLine("Película " + (contPel + 1)+ ":");
                        Console.WriteLine(lista[i].ToString() + "\n");
                        contPel++;
                    }
                }
                
                if(contPel == 0)
                    Console.WriteLine("ERROR. No hay películas en la lista.");
            }else
                Console.WriteLine("ERROR. No hay elementos en la lista.");
        }
        
        //METODO PARA MOSTRAR POR TITULO/GENERO/DISPONIBILIDAD
        public void muestraTituloGenero(String aux, int b, int contadorGen)
        {
            int bandera = 0;
            int conGen = 0; //contador de elementos de la lista
            int n = 0; //para marcar la posición del elemento encontrado

            if (b == 0)
            {
                for (int i = 0; i < contadorGen || bandera == 1; i++)
                {
                    if (lista[i] != null)
                    {
                        if (lista[i].Titulo == aux)
                        {
                            n = i;
                            bandera = 1;
                            conGen++;
                            break;
                        }
                        else
                            conGen++;
                    }
                }

                if (conGen > 0)
                {
                    if (bandera == 1)
                    {
                        Console.WriteLine("Elemento encontrado.");
                        Console.WriteLine(lista[n].ToString() + "\n");
                    }
                    else
                        Console.WriteLine("ERROR. No hay ningún elemento en la lista con ese nombre.");

                }
                else
                    Console.WriteLine("ERROR. No hay elementos en la lista.");
            }
            else if(b == 1)
            {
                Ejemplar[] listaAux = new Ejemplar[contadorGen];
                int contTotal = 0; //PARA CONTAR UNICAMENTE LOS ELEMENTOS ENCONTRADOS
                
                for (int i = 0; i < contadorGen; i++)
                {
                    if (lista[i] != null)
                    {
                        if (lista[i].genero == aux)
                        {
                            listaAux[contTotal] = lista[i];
                            contTotal++;
                            conGen++;
                            break;
                        }
                        else
                            conGen++;
                    }
                }

                if (conGen > 0)
                {
                    if (contTotal > 0)
                    {
                        Console.WriteLine("Elemento encontrado.");
                        
                        for (int j = 0; j < contTotal; j++)
                        {
                            Console.WriteLine(listaAux[j].ToString() + "\n");
                        }
                    }
                    else
                        Console.WriteLine("ERROR. No hay ningún elemento en la lista de ese género.");

                }
                else
                    Console.WriteLine("ERROR. No hay elementos en la lista.");
            }
            else
            {
                Ejemplar[] listaAux = new Ejemplar[contadorGen];
                int contTotal = 0; //PARA CONTAR UNICAMENTE LOS ELEMENTOS ENCONTRADOS
                
                for (int i = 0; i < contadorGen; i++)
                {
                    if (lista[i] != null)
                    {
                        if (lista[i].disponibilidad == aux)
                        {
                            listaAux[contTotal] = lista[i];
                            contTotal++;
                            conGen++;
                        }
                        else
                            conGen++;
                    }
                }

                if (conGen > 0)
                {
                    if (contTotal > 0)
                    {
                        Console.WriteLine("Elementos encontrados.");
                        
                        for (int j = 0; j < contTotal; j++)
                        {
                            Console.WriteLine(listaAux[j].ToString() + "\n");
                        }
                    }
                    else
                        Console.WriteLine("ERROR. No hay ningún elemento en la lista de esa disponibilidad.");

                }
                else
                    Console.WriteLine("ERROR. No hay elementos en la lista.");
            }
        }
        
        //METODO PARA BUSCAR UN SOCIO
        public Socio buscarSocio(String nombre, Socio s1, Socio s2, Socio s3)
        {
            Socio[] listaAux = new Socio[3];

            listaAux[0] = s1;
            listaAux[1] = s2;
            listaAux[2] = s3;
            
            for (int i = 0; i < 3; i++)
            {
                if (listaAux[i].nombre == nombre)
                {
                    return listaAux[i];
                    break;
                }
            }

            return null;
        }

        //METODO PARA PRESTAR UN EJEMPLAR
        public void prestarEjemplar(Socio s)
        {
            if(s == null)
                Console.WriteLine("ERROR. No se ha podido efectuar el alquiler. \n No existe ese socio.");
            else
            {
                Console.WriteLine("Introduce el nombre del ejemplar: ");
                String aux = Console.ReadLine();
                
                int bandera = 0;
                int conGen = 0; //contador de elementos de la lista
                int n = 0; //para marcar la posición del elemento encontrado
                
                for (int i = 0; i < lista.Length || bandera == 1; i++)
                {
                    if (lista[i] != null)
                    {
                        if (lista[i].Titulo == aux)
                        {
                            n = i;
                            bandera = 1;
                            conGen++;
                            break;
                        }
                        else
                            conGen++;
                    }
                }

                if (conGen > 0)
                {
                    if (bandera == 1)
                    {
                        //Console.WriteLine("Elemento encontrado.");
                        lista[n].disponibilidad = "alquilado";
                        lista[n].propietario = s.nombre;
                        Console.WriteLine("Elemento alquilado.");
                    }
                    else
                        Console.WriteLine("ERROR. No hay ningún elemento en la lista con ese nombre.");

                }
                else
                    Console.WriteLine("ERROR. No hay elementos en la lista.");
            }

        }
        
        //METODO PARA DEVOLVER UN EJEMPLAR
        public void devolverEjemplar()
        {
            Console.WriteLine("Introduce el nombre del ejemplar: ");
            String aux = Console.ReadLine();
                
            int bandera = 0;
            int conGen = 0; //contador de elementos de la lista
            int n = 0; //para marcar la posición del elemento encontrado
                
            for (int i = 0; i < lista.Length || bandera == 1; i++)
            {
                if (lista[i] != null)
                {
                    if (lista[i].Titulo == aux)
                    {
                        n = i;
                        bandera = 1;
                        conGen++;
                        break;
                    }
                    else
                        conGen++;
                }
            }

            if (conGen > 0)
            {
                if (bandera == 1)
                {
                    //Console.WriteLine("Elemento encontrado.");
                    lista[n].disponibilidad = "disponible";
                    lista[n].propietario = "tienda";
                    Console.WriteLine("Elemento devuelto.");
                }
                else
                    Console.WriteLine("ERROR. No hay ningún elemento en la lista con ese nombre.");

            }
            else
                Console.WriteLine("ERROR. No hay elementos en la lista.");
        }
        
        //METODO PARA MOSTRAR QUIEN TIENE LOS EJEMPLARES PRESTADOS
        public void mostrarPrestados()
        {
            Console.WriteLine("Introduce el nombre del ejemplar: ");
            String aux = Console.ReadLine();
                
            int bandera = 0;
            int conGen = 0; //contador de elementos de la lista
            int n = 0; //para marcar la posición del elemento encontrado
                
            for (int i = 0; i < lista.Length || bandera == 1; i++)
            {
                if (lista[i] != null)
                {
                    if (lista[i].Titulo == aux)
                    {
                        n = i;
                        bandera = 1;
                        conGen++;
                        break;
                    }
                    else
                        conGen++;
                }
            }

            if (conGen > 0)
            {
                if (bandera == 1)
                {
                    Console.WriteLine("Ese ejemplar lo tiene: " + lista[n].propietario);
                }
                else
                    Console.WriteLine("ERROR. No hay ningún elemento en la lista con ese nombre.");

            }
            else
                Console.WriteLine("ERROR. No hay elementos en la lista.");
        }
        
        //METODO PARA APLICAR VARIOS FILTRADOS
        public List <Ejemplar> aplicarFiltro(int bandera, int contGen)
        {
            List <Ejemplar> listAux = new List<Ejemplar>();
            
            for (int i = 0; i < contGen; i++)
            {
                listAux.Add(lista[i]);
            }

            if (bandera == 1) //filtrado por tipo
            {
                String a;
                
                do
                {
                    Console.WriteLine("¿Es un videojuego o una película? (videojuego|pelicula): ");
                    a = Console.ReadLine();

                    if (a != "videojuego" && a != "VIDEOJUEGO" && a != "pelicula" && a != "PELICULA")
                        Console.WriteLine("ERROR. Debe introducir videojuego o película.");

                } while (a != "videojuego" && a != "VIDEOJUEGO" && a != "pelicula" && a != "PELICULA");
                
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (a == "VIDEOJUEGO" || a == "videojuego")
                    {
                        if (listAux[i] is Pelicula)
                        {
                            listAux.RemoveAt(i);
                        }
                    }
                    else
                    {
                        if (listAux[i] is Videojuego)
                        {
                            listAux.RemoveAt(i);
                        }
                    }
                }

                return listAux;

            }else if (bandera == 2) //por titulo
            {
                String a;
                
                do
                {
                    Console.WriteLine("¿Introduce el título del ejemplar: ");
                    a = Console.ReadLine();

                    if (a == "" && a == " ")
                        Console.WriteLine("ERROR. El campo está vacío.");

                } while (a == "" && a == " ");
                
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (listAux[i].Titulo != a)
                    {
                        listAux.RemoveAt(i);
                    }
                }
                
                return listAux;
                
            }else if (bandera == 3) //por genero
            {
                String a;
                
                do
                {
                    Console.WriteLine("¿Introduce el género del ejemplar: ");
                    a = Console.ReadLine();

                    if (a == "" && a == " ")
                        Console.WriteLine("ERROR. El campo está vacío.");

                } while (a == "" && a == " ");
                
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (listAux[i].genero != a)
                    {
                        listAux.RemoveAt(i);
                    }
                }
                
                return listAux;
            }
            else //por disponibilidad
            {
                String a;
                
                do
                {
                    Console.WriteLine("Introduce la disponibilidad del ejemplar (alquilado|disponible): ");
                    a = Console.ReadLine();

                    if (a != "alquilado" && a != "ALQUILADO" && a != "disponible" && a != "DISPONIBLE")
                        Console.WriteLine("ERROR. Debe introducir alquilado o disponible.");

                } while (a != "alquilado" && a != "ALQUILADO" && a != "disponible" && a != "DISPONIBLE");
                
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (listAux[i].disponibilidad != a)
                    {
                        listAux.RemoveAt(i);
                    }
                }
                
                return listAux;
            }
        }
        
        //METODO PARA AMPLIAR EL ARRAY
        public void ampliaArray()
        {
            int c;

            for (c = 0; c < lista.Length; c++)
            {
            }

            Ejemplar[] aux = new Ejemplar[c];
            
            int i;

            for (i = 0; i < aux.Length; i++)
                aux[i] = lista[i];
            
            lista = new Ejemplar[i*2];

            for (int j = 0; j < aux.Length; j++)
                lista[j] = aux[j];
        }
        
        //METODO PARA ORDENAR EL ARRAY
        public void ordenaArray(int c)
        {
            //metodo de ordenacion por burbuja
            for (int x = 0; x < c; x++)
            {
                // Recuerda que el -1 es porque no queremos llegar al final ya que hacemos
                // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
                // del arreglo
                for (int indiceActual = 0; indiceActual < c - 1; indiceActual++)
                {
                    int indiceSiguienteElemento = indiceActual + 1;

                    String cad1 = lista[indiceActual].Titulo;
                    String cad2 = lista[indiceSiguienteElemento].Titulo;

                    char c1 = cad1[0];
                    char c2 = cad2[0];
                    
                    // Si el actual es mayor que el que le sigue a la derecha
                    if (c1 > c2)
                    {
                        if (lista[indiceActual] is Videojuego)
                        {
                            Videojuego ej = (Videojuego)lista[indiceActual];
                            lista[indiceActual] = lista[indiceSiguienteElemento];
                            lista[indiceSiguienteElemento] = ej;
                        }
                        else
                        {
                            Pelicula ej = (Pelicula)lista[indiceActual];
                            lista[indiceActual] = lista[indiceSiguienteElemento];
                            lista[indiceSiguienteElemento] = ej;
                        }
                    }
                }
            }
        }
        
        //METODO PARA RELLENAR EL ARRAY CON 8 ELEMENTOS INICIALES
        public void rellenaArray()
        {
            for (int i = 0; i < 8; i++)
            {
                Videojuego ej = new Videojuego("prueba"+(i+1), "p", "10/10/10", 1, 1, "p");
                lista[i] = ej;
            }
        }

        //METODO PARA CARGAR LOS DATOS DE UN FICHERO
        public void cargarFichero()
        {
            char[] cad = new char[140];

            String titulo = "", genero = "", fecha = "", compañia = "", aux1 = "", aux2 = "";
            int edad = 0;
            float duracion = 0;

            Videojuego vid;
            Pelicula pel;
            
            try
            {
                FileStream fichero = File.OpenRead("fondo.txt");

                int cont = 0;

                byte[] obj = new byte[140];

                for(int i = 0; i < fichero.Length; i++)
                {
                    if (cont < 139)
                    {
                        byte unDato = (byte) fichero.ReadByte();
                        obj[cont] = unDato;
                        cont++;
                    }
                    else
                    {
                        cont = 0;
                        for (int j = 0; j < 140; j++)
                        {
                            char a = Convert.ToChar(obj[j]);
                            //Console.WriteLine(a);
                            cad[j] = a;

                            if (j > 0 && j < 40)
                            {
                                if (j == 1)
                                    titulo = cad[j].ToString();
                                else
                                {
                                    if(cad[j] != ' ')
                                        titulo = titulo + cad[j].ToString();
                                }
                            }

                            if (j > 39 && j < 71)
                            {
                                if (j == 40)
                                    genero = cad[j].ToString();
                                else
                                {
                                    if (cad[j] != ' ')
                                        genero = genero + cad[j].ToString();
                                }
                            }

                            if (j > 70 && j < 88)
                            {
                                if (j == 71)
                                    genero = cad[j].ToString();
                                else
                                {
                                    if (cad[j] != ' ')
                                        fecha = fecha + cad[j].ToString();
                                }
                            }

                            if (j > 87 && j < 90)
                            {
                                
                                if (j == 88)
                                    aux1 = cad[j].ToString();
                                else
                                {
                                    if (cad[j] != ' ')
                                        fecha = fecha + cad[j].ToString();
                                }
                            }

                            if (j > 89 && j < 99)
                            {
                                if (j == 90)
                                    aux2 = cad[j].ToString();
                                else
                                {
                                    if (cad[j] != ' ')
                                        fecha = fecha + cad[j].ToString();
                                }
                            }

                            if (j > 98 && j < 139)
                            {
                            }

                        }
                        
                        Console.WriteLine("Este es un objeto");
                        
                        //edad = int.Parse(aux1);
                        //duracion = float.Parse(aux2);
            
                        Console.WriteLine(titulo + " | " + genero + " | " + fecha + " | " + aux1 + " | " + aux2 + " | " + compañia + " | ");
            
                        /*
                        if (cad[0] == 'v')
                            vid = new Videojuego(titulo, genero, fecha, edad, duracion, compañia);
                        else
                            pel = new Pelicula(titulo, genero, fecha, edad, duracion, compañia);
                        */
                        
                    }


                }

                fichero.Close();
                
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Se ha producido un error: {exp.Message}");
            }

        }
        
        //METODO PARA GUARDAR LOS DATOS DE UN FICHERO
        public void guardarFichero(int contGen)
        {
            try
            {
                //FileStream fichero = new FileStream("fondo.dat", FileMode.OpenOrCreate);

                byte[] modo = new byte[2];
                
                FileStream fichero = File.OpenWrite("fondo.txt");
                
                //byte dato = (byte)fichero.ReadByte();
                byte dato;
                byte[] nombreByte = new byte[20];
                byte[] generoByte = new byte[15];
                byte[] fechaByte = new byte[8];
                byte[] compañiaByte = new byte[20];
                byte[] numero = new byte[2];

                using (BinaryWriter escribir = new BinaryWriter(fichero))
                {
                    for (int i = 0; i < contGen; i++) //recorro el array
                    {
                        Console.WriteLine("Entras en el for");
                        
                        /*byte dato = (byte)fichero.ReadByte();
                        byte[] nombreByte = new byte[20];
                        byte[] generoByte = new byte[15];
                        byte[] fechaByte = new byte[8];
                        byte[] compañiaDirectorByte = new byte[20];*/

                        if (lista[i] is Videojuego)
                        {
                            Console.WriteLine("Entras en el videojuego");
                            
                            Videojuego vid = (Videojuego) lista[i];
                            String titulo = vid.Titulo;
                            String genero = vid.genero;
                            String fecha = vid.fechaSalida;
                            String compañia = vid.compañia;
                            String duracion = vid.duracion.ToString("0.00");
                            String edad = vid.edad.ToString();
                            char tipo = 'v';
                            
                            nombreByte = CadenaBytes(titulo, 20);
                            generoByte = CadenaBytes(genero, 15);
                            fechaByte = CadenaBytes(fecha, 8);
                            compañiaByte = CadenaBytes(compañia, 20);

                            dato = (byte)tipo;
                            
                            fichero.WriteByte(dato);
                            
                            for (int a = 0; a < nombreByte.Length; a++)
                            {
                                fichero.WriteByte(nombreByte[a]);
                            }

                            for (int b = 0; b < generoByte.Length; b++)
                            {
                                fichero.WriteByte(generoByte[b]);
                            }

                            for (int c = 0; c < fechaByte.Length; c++)
                            {
                                fichero.WriteByte(fechaByte[c]);
                            }

                            numero = CadenaBytes(edad, 2);
                            for (int e = 0; e < numero.Length; e++)
                            {
                                fichero.WriteByte(fechaByte[e]);
                            }
                            
                            numero = CadenaBytes(duracion, 2);
                            for (int f = 0; f < numero.Length; f++)
                            {
                                fichero.WriteByte(fechaByte[f]);
                            }
                            

                            for (int d = 0; d < compañiaByte.Length; d++)
                            {
                                fichero.WriteByte(compañiaByte[d]);
                            }
                        }
                        else
                        {
                            Pelicula vid = (Pelicula) lista[i];
                            String titulo = vid.Titulo;
                            String genero = vid.genero;
                            String fecha = vid.fechaSalida;
                            String compañia = vid.director;
                            String duracion = vid.duracion.ToString("0.00");
                            String edad = vid.edad.ToString();
                            char tipo = 'v';
                            
                            nombreByte = CadenaBytes(titulo, 20);
                            generoByte = CadenaBytes(genero, 15);
                            fechaByte = CadenaBytes(fecha, 8);
                            compañiaByte = CadenaBytes(compañia, 20);

                            dato = (byte)tipo;
                            
                            fichero.WriteByte(dato);
                            
                            for (int a = 0; a < nombreByte.Length; a++)
                            {
                                fichero.WriteByte(nombreByte[a]);
                            }

                            for (int b = 0; b < generoByte.Length; b++)
                            {
                                fichero.WriteByte(generoByte[b]);
                            }

                            for (int c = 0; c < fechaByte.Length; c++)
                            {
                                fichero.WriteByte(fechaByte[c]);
                            }

                            numero = CadenaBytes(edad, 2);
                            for (int e = 0; e < numero.Length; e++)
                            {
                                fichero.WriteByte(fechaByte[e]);
                            }
                            
                            numero = CadenaBytes(duracion, 2);
                            for (int f = 0; f < numero.Length; f++)
                            {
                                fichero.WriteByte(fechaByte[f]);
                            }

                            for (int d = 0; d < compañiaByte.Length; d++)
                            {
                                fichero.WriteByte(compañiaByte[d]);
                            }
                        }


                        /*if (dato != null)
                        {
                            fichero.WriteByte(dato);
                        }*/

                    }
                }

                Console.WriteLine("Datos guardados correctamente");
                
                fichero.Close();

            } catch (Exception exp)
            {
                Console.WriteLine($"Se ha producido un error: {exp.Message}");
            }
        }
        
        public static byte[] CadenaBytes(String cadena, int tamMax)
        {
            //Este método devuelve un array de bytes añadiendo espacios al final hasta rellenar el tamaño indicado.
            return Encoding.Unicode.GetBytes(cadena.PadRight(tamMax, ' '));
        }

        public static String BytesACadena(byte[] vectorRecorrido)
        {
            //Devuelve las cadenas leídas del array quitando los espacios finales.
            return Encoding.Unicode.GetString(vectorRecorrido).Trim();
        }
        
        /*
         * public static void CargarDatosAFichero()
        {
            byte[] modo = new byte[2];
            FileStream fichero = File.OpenWrite(@"C:\Users\paelj\Documents\DAM\2DAM 21-22\DDI\Proyecto videoclub\Videoclub\fondo.dat");

            using (BinaryWriter escribir = new BinaryWriter(fichero))
            {
                for (int i = 0; i < fichero.Length; i++)
                {

                }
            }
        }*/
        
        /*
        public static otro metodo()
        {
            BinaryWriter fic = new BinaryWriter(Fichero);
            for(int i = 0; i < contEj; i++)
            {
                if(ejemplares[i] is pelicula)
                {
                    pelicula e = (pelicula) ejemplares[i];
                    fic.write(encoding.unicode.getbyte("P"));
                    fic.write(encoding.unicode.getbyte(
                                e.titulo.padright(50, ' ')));
                    fic.write(encoding.unicode.getbyte(
                                e.genero.padright(50, ' ')));
                    fic.write(e.pegi);
                    fic.write(e.prestado);
                    fic.write(e.duracion);
                }
            }
        }
        
        otra cosa:
        
        regex r = new regex("^[a-zA-Z0-9-,-/-]*&");
        try
        {
            FileStream fichero = new FileStream("fondo.dat", FileMode.Open);
            
            for(int i = 0; i < fichero.length; i++)
            {
                char aux = convert.tochar(fichero.readbyte());
                
                String cadAux = Convert.ToString(aux);
            }
        }
        
        otra cosa:
                {
                    comienzo = 0;
                    lineas++;
                }
                
                if(comienzo == 1)
                {
                    if(aux != '|' && aux != '*' && r.IsMatch(cadAux))
                    {
                        informacion[lineas] += aux;
                    }
                }
        
            }
            
            fichero.close();
        
        }
        catch(Exception e)
        ....
         */
    }
}
