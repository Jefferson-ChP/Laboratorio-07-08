using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Habitacion hallarDisponibilidad = listaHabitacion.Find(a => a.Numero == numeroModificar);
            if (hallarDisponibilidad == null)
            {
                if (Disponibilidad == false)
                {
                    Console.WriteLine("La disponibilidad de la habitación ha sido cambiada a OCUPADA.");
                    HabitacionNoDisponible();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("La disponibilidad de la habitación ha sido cambiada a LIBRE.");
                    return disponible = false;
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("No existe una habitación con ese número.");
                Console.ReadKey();
            }
        }
    }
}
