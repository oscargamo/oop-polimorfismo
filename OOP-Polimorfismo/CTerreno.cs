using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polimorfismo
{
    class CTerreno : CInmueble
    {
        // Estados - Atributos
        // ...
        // Comportamientos - Metodos
        // ...
        // Constructores
        public CTerreno(string tipoInmueble, double precio)
        {
            this.tipoInmueble = tipoInmueble;
            this.precio = precio;
        }
    }
}
