using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class Congelador
    {
        // Se establecen los atributos
        int CantidadHelados { get; set; }
        int Numero { get; set; }
        // Se crea un constructor
        public Congelador(int Numero)
        {
            this.Numero = Numero;
        }
        // Se realizan el metodo de almacenamiento de helados y el metodo de confirmacion
        public void AlmacenarHeladosCongelador()
        {
            Singleton CongeladorHelados = Singleton.GetInstancia();
            CongeladorHelados.AlmacenarHelados(this.CantidadHelados);
            this.CantidadHelados = 0;
        }
        public int Confirmacion(int CantidadHelados, int ConfirmacionHelados)
        {
            int Diferencia = CantidadHelados - ConfirmacionHelados;
            this.CantidadHelados += Diferencia;
            this.CantidadHelados = +CantidadHelados;
            return Diferencia;
        }
    }
}
