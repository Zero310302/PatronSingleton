using System;
using System.Collections.Generic;
using System.Linq;

namespace PatronSingleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Se crea un Congelador donde se puedan guardar Helados
            Singleton CongeladorHelados = Singleton.GetInstancia();

            // Se crea una lista para almacenar todos los congeladores
            List<Congelador> congelador = new List<Congelador>();

            // Se crean los congeladores que se requieran y se añaden a la lista
            Congelador congelador1 = new Congelador(1);
            congelador.Add(congelador1);
            Congelador congelador2 = new Congelador(2);
            congelador.Add(congelador2);
            Congelador congelador3 = new Congelador(3);
            congelador.Add(congelador3);

            // Se crean variables
            bool Exit = true;
            int Eleccion = 0;
            int NumCongelador;

            // Variables usadas en la opcion de Almacenar Helados
            int confirmacion;
            int canthelados;

            // Se muestra en pantalla mediante un do while 
            do
            {
                Console.Clear();

                Console.WriteLine("*************************************");
                Console.WriteLine("Ingrese la opcion que desea realizar: ");
                Console.Write("\n1. Almacenar Helados\n2. Ver Helados Almacenados\n3. Finalizar programa\n");
                Console.WriteLine("********************************************************");
                Console.WriteLine();
                Eleccion = Opcion(3);

                // Se implementa la opcion para almacenar los helados
                switch (Eleccion)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Congeladores");
                        for (int contado = 0; contado < congelador.Count; contado++)
                        {
                            Console.WriteLine("Congelador " + (contado + 1));
                        }
                        Console.WriteLine("***********************************************************");
                        Console.WriteLine("Ingrese el numero de congelador en el que desea almacenar:");
                        NumCongelador = Opcion(congelador.Count);
                        Console.WriteLine("***********************************************************");
                        Console.WriteLine("Ingrese los helados a almacenar:");
                        canthelados = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Confirme la cantidad de helados a almacenar:");
                        confirmacion= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("********************************************************");

                        congelador[NumCongelador].Confirmacion(canthelados, confirmacion);
                        congelador[NumCongelador].AlmacenarHeladosCongelador();
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("Almacenamiento de helados registrados");
                        Console.WriteLine("********************************************************");
                        Thread.Sleep(2000);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("El total de helados almacenados es: " + CongeladorHelados.CantidadHelados);
                        Console.WriteLine("Ingrese cualquier letra o digito para salir");
                        Console.WriteLine("********************************************************");
                        NumCongelador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Espere.....");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("Finalizando Programa");
                        Console.WriteLine("********************************************************");
                        Thread.Sleep(2000);
                        Exit = false;
                        break;

                    default:
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("Ha ingresado una opcion incorrectra");
                        Console.WriteLine("Por favor, intente ingresar una opcion nuevamente.....");
                        Console.WriteLine("********************************************************");
                        break;
                }
            }while (Exit);
        }
        public static int Opcion(int LimiteParametro)
        {
            int Elecccion = 0;
            do
            {
                Elecccion = Convert.ToInt32(Console.ReadLine());
                if (Elecccion <= 0 || Elecccion > LimiteParametro)
                {
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("Ha ingresado una opcion incorrectra");
                    Console.WriteLine("Por favor, intente ingresar una opcion nuevamente.....");
                    Console.WriteLine("********************************************************");
                }
            } while (Elecccion <= 0 || Elecccion > LimiteParametro);
            return Elecccion;
        }
    }
}