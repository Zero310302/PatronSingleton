using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class Singleton
    {
        // Se establecen los atributos

        private static Singleton Instancia;
        public int CantidadHelados { get; set; }
        // Se crea el constructor privado
        private Singleton() { }
        // Se crean los metodos para crear la clase
        public static Singleton GetInstancia()
        {
            /* Ahora se comprueba si la clase esta creada o no, en caso de estar creada devolvera la clase,
             si la clase no esta creada se crea una clase nueva*/
            if (Instancia == null)
            {
                Instancia = new Singleton();
            }
            return Instancia;
        }
        // Se crea un metodo para almacenar los helados en el congelador

        public void AlmacenarHelados(int CantidadHelados)
        {
            this.CantidadHelados += CantidadHelados;
        }

    }
}
