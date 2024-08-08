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
        List<Habitacion> listaHabitacion;
        public int Numero { get; set; }
        public double PrecioNoche { get; set; }
        public bool Disponibilidad { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precionoche, bool disponibilidad, string clienteAsignado)
        {
            Numero = numero;
            PrecioNoche = precionoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteAsignado;
        }

        public Habitacion()
        {
            listaHabitacion = new List<Habitacion>();
        }
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
        public string AsignarCliente(string nombreCliente)
        {
            return ClienteAsignado = nombreCliente;
        }
        public void LiberarHabitacion()
        {
            if (Disponibilidad == true && ClienteAsignado != null)
            {
                Disponibilidad = false;
                ClienteAsignado = "";
            }
            else if(Disponibilidad == true && ClienteAsignado == null)
            {
                Disponibilidad = false;
            }
            else
            {
                Console.WriteLine("La habitación ya está liberada.");
                Console.ReadKey();
            }
        }
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
        public void TipoHabitacion()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Habitación simple.");
            Console.WriteLine("2. Habitación doble.");
            Console.WriteLine("3. Habitación suite.");
            Console.WriteLine("4. Habitación deluxe.");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Seleccione el tipo de habitación: ");
        }
    }

}


