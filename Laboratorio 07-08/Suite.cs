using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    public class Suite : Habitacion
    {
        public int NumeroDeHabitaciones {  get; set; }
        public bool TieneJacuzzi {  get; set; }

        public Suite(int numeroDeHabitaciones, bool tieneJacuzzi)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
        public void IngresarNumeroHabitaciones()
        {
            Console.Clear();
            Console.Write("Ingrese el número de habitaciones de la suite: ");
        }
        public void DeclararJacuzzi()
        {
            Console.Clear();
            Console.WriteLine("¿La suite tiene jacuzzi? (S/N)");
        }
    }
}
