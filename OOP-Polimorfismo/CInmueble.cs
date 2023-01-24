using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polimorfismo
{
    class CInmueble
    {
        // Estados - Atributos
        protected string tipoInmueble;
        protected string ubicacion;
        protected double areaTerreno;
        protected double precio;

        // Comportamientos - Metodos
        /// <summary>
        /// Metodo x
        /// </summary>
        public void Vender()
        {
            Console.WriteLine(tipoInmueble + "Vendida por el precio de " + precio);
        }

    }
}
