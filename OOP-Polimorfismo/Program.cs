using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invocamos las clases de casa, departamento, terreno 
            CCasa casa = new CCasa("Casa en la Playa ", 30000);
            CDepartamento departamento = new CDepartamento("Departamento Delux ", 50000);
            CTerreno terreno = new CTerreno("Terreno Acera ", 10000);

            // Invocamos los metodos 
            casa.Vender();
            departamento.Vender();
            terreno.Vender();


            // El polimorfismo se trata simplemente de que un unico objeto puede tener multiples
            // estados y comportamiento, basicamente es la capacidad de los objetos de una clase, 
            // en responder de diferentes maneras a un solo mensaje, esta estrechamente relacionado a 
            // la herencia

        }
    }
}
