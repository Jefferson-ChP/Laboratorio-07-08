using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    public class Simple : Habitacion
    {

        //Variables

        List<Simple> listaSimple;
        public int NumeroCamas { get; set; }

        //Constructor

        public Simple(int numerocamas)
        {
            NumeroCamas = numerocamas;
        }

        //Constructor lista

        public Simple()
        {
            listaSimple = new List<Simple>();
        }

        //función para introducir el número de camas

        public void IntroducirNumeroCamas()
        {
            Console.Clear();
            Console.Write("Ingrese el número de camas que desea para la habitación: ");
        }
    }
}
