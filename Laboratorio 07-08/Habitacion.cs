using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    public class Habitacion
    {

        //Variables

        List<Habitacion> listaHabitaciones;
        public int Numero { get; set; }
        public double PrecioNoche { get; set; }
        public bool Disponibilidad { get; set; }
        public string ClienteAsignado { get; set; }

        //Constructor

        public Habitacion(int numero, double precionoche, bool disponibilidad, string clienteasignado)
        {
            Numero = numero;
            PrecioNoche = precionoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteasignado;
        }

        //Creación lista

        public Habitacion()
        {
            listaHabitaciones = new List<Habitacion>();
        }

        //Función para mostrar información de la habitación

        public void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine($"Número de habitación: {Numero}");
            Console.WriteLine($"Precio por noche de la habitación: {PrecioNoche}");
            if (Disponibilidad == true)
            {
                Console.WriteLine("Habitación disponible.");
            }
            else
            {
                Console.WriteLine($"Habitación ocupada por: {ClienteAsignado}");
            }
        }

        //Función para cambiar la disponibilidad de la habitación

        public bool CambiarDisponibilidad(bool disponible)
        {
            if (disponible == true )
            {
                return disponible = false;
            }
            else
            {
                return disponible = true;
            }
        }

        //Función para asignar un cliente a la habitación

        public string AsignarCliente(string nombreCliente)
        {
            return ClienteAsignado = nombreCliente;
        }

        //Función para liberar una habitación

        public void LiberarHabitacion()
        {

            //Condicional en caso de que la habitación esté ocupada y haya una persona asignada

            if (Disponibilidad == true && ClienteAsignado != null)
            {
                Disponibilidad = false;
                ClienteAsignado = "";
            }

            //Condicional en caso de que la habitación esté ocupada y no haya una persona asignada

            else if (Disponibilidad == true && ClienteAsignado == null)
            {
                Disponibilidad = false;
            }

            //Condicional en caso de que la habitación esté libre pero haya una persona asignada

            else if (Disponibilidad == false && ClienteAsignado != null)
            {
                ClienteAsignado = "";
            }
            //Condicional en caso de que la habitación ya esté libre

            else
            {
                Console.WriteLine("La habitación ya está liberada.");
                Console.ReadKey();
            }
        }

        //Función para mostrar el menu del hotel

        public void MenuHotel()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("---MENU DEL HOTEL PATO---");
            Console.WriteLine("1. Agregar habitación.");
            Console.WriteLine("2. Eliminar habitación.");
            Console.WriteLine("3. Mostrar habitaciones.");
            Console.WriteLine("4. Asignar habitación a cliente.");
            Console.WriteLine("5. Liberar habitación.");
            Console.WriteLine("6. Salir del menú.");
            Console.WriteLine("===========================================\n");
            Console.Write("Seleccione alguna de las opciones: ");
        }

        //Función para mostrar el menú de tipo de habitación

        public void TipoHabitacion()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Habitación simple.");
            Console.WriteLine("2. Habitación doble.");
            Console.WriteLine("3. Habitación suite.");
            Console.WriteLine("4. Habitación deluxe.");
            Console.WriteLine("5. Regresar al menú.");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Seleccione el tipo de habitación: ");
        }
    }

}


