using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    internal class Deluxe : Habitacion
    {
        public string ServiciosExtra {  get; set; }

        public Deluxe(string serviciosExtra)
        {
            ServiciosExtra = serviciosExtra;
        }
        public void AgregarServicios()
        {
            Console.Clear();
            Console.WriteLine("Escriba el tipo de servicios extra que desea: ");
        }
    }
}
