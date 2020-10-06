using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandledExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //Manejo de 2 excepciones:
            //1. Cuando ingreso un numero de telefono con caracteres no numericos (por ejm: errores de tipeo).
            //2. Cuando ingreso un primer nombre con caracteres numericos (por ejm: Ignaci0.).
            //Para ambos casos, vuelve correr esa iteracion para registrar correctamente los datos de la persona.
            Gym my_gym = new Gym();
            Console.WriteLine("Bienvenido al sistema de gestion de su gimnasio.\n\n");
            int quantity;
            while (true)
            {
                Console.WriteLine("Ingrese el numero de personas que desea registrar:\n");
                string quantity_str = Console.ReadLine();
                if (int.TryParse(quantity_str, out quantity))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("No ingresaste un numero, prueba nuevamente.");
                Thread.Sleep(1500);
                Console.Clear();
                
            }
            
            Console.Clear();

            my_gym.initialRegistration(quantity);
            my_gym.displayPeopleRegistered();

            

        }
    }
}
