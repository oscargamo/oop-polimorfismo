using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polimorfismo
{
    class CDepartamento : CInmueble
    {
        // Estados - Atributos
        // ...
        // Comportamientos - Metodos
        // ... 
        // Constructores
        public CDepartamento(string tipoInmueble, double precio)
        {
            this.tipoInmueble = tipoInmueble;
            this.precio = precio;
        }
    }
}
