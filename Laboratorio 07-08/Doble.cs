using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    public class Doble : Habitacion
    {

        //Variables

        List<Doble> listaDoble;
        public bool VistaAlMar {  get; set; }

        //Constructor

        public Doble(bool vistaAlMar)
        {
            VistaAlMar = vistaAlMar;
        }

        //Constructor lista

        public Doble()
        {
            listaDoble = new List<Doble>();
        }

        //Función para declarar si la habitación posee vista al mar.

        public void DeclararVista()
        {
            Console.Clear();
            Console.WriteLine("¿La habitación posee vista al mar? (S/N) ");
        }
    }
}
