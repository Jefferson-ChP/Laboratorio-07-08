using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    public class Simple : Habitacion
    {
        public int NumeroCamas { get; set; }
        public Simple(int numero, double precionoche, bool disponibilidad, string clienteAsignado, int numerocamas)
        {
            NumeroCamas = numerocamas;
        }
        public void IntroducirNumeroCamas()
        {
            Console.WriteLine("Ingrese el número de camas que desea para la habitación: ");
        }
    }
}
