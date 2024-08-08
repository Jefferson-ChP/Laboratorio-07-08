using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07_08
{
    static class Program
    {
        static void Main(string[] args)
        {

            //Variables

            Habitacion hotel = new Habitacion();
            
            bool menu = true;
            

            //Cliclo menu

            while (menu == true)
            {
                bool menuTipo = true;

                //Búsqueda de errores

                try
                {
                    hotel.MenuHotel(); int opcionMenu = Convert.ToInt32(Console.ReadLine());

                    //Opciones menu

                    switch (opcionMenu)
                    {

                        //Caso agregar habitación

                        case 1:

                            //Ciclo menú de tipo de habitación

                            while (menu)
                            {

                                //Búsqueda de errores

                                try
                                {
                                    hotel.TipoHabitacion(); int opcionHabitacion = Convert.ToInt32(Console.ReadLine());

                                    //Opciones menu tipo de habitación

                                    switch (opcionHabitacion)
                                    {
                                        //Caso habitación simple

                                        case 1:
                                            Simple simple = new Simple();

                                            simple.
                                            simple.IntroducirNumeroCamas(); int numeroCamas = Convert.ToInt32(Console.ReadLine());
                                            simple.NumeroCamas = numeroCamas;
                                            Console.WriteLine("");
                                            Console.WriteLine("La habitación ha sido registrada con éxito.");
                                            Console.ReadKey();
                                        break;

                                        //Caso habitación doble

                                        case 2:
                                            Doble doble = new Doble();

                                            
                                            break;
                                    }
                                }

                                //Mensaje de error encontrado

                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error encontrado: " + ex);
                                }
                            }

                            break;
                    }
                }

                //Mensaje de error encontrado

                catch (Exception ex)
                {
                    Console.WriteLine("Error encontrado: " + ex);
                }
            }
            
        }
    }
}
