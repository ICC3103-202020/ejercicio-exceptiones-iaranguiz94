using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandledExample
{
    public class Gym
    {
        private List<Person> people_registered = new List<Person>();

        public void registerPerson(Person p)
        {
            people_registered.Add(p);
        }

        public void displayPeopleRegistered()
        {
            Console.WriteLine("**********************************************************************\n");
            Console.WriteLine("Las Personas que estan registradas en su sistema son las siguientes:\n");
            Console.WriteLine("**********************************************************************\n");
            for(int i = 0; i < people_registered.Count(); i++)
            {
                Console.WriteLine($"{i+1}° Persona:\n");
                people_registered[i].displayInfo();
                Console.WriteLine();
            }
        }

        public void initialRegistration(int quantity)
        {
            Person p;
            string first_name;
            string last_name;
            int phone_number;

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la {i + 1}° persona:\n");
                first_name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"Ingrese el apellido de la {i + 1}° persona:\n");
                last_name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"Ingrese el numero de telefono de la {i + 1}° persona:\n");
                try
                {
                    phone_number = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ingresaste un numero incorrecto (caracteres no numericos).\n");
                    Console.WriteLine("Ingresa un numero de telefono correcto.");
                    i -= 1;
                    continue;
                }
                finally
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                }


                try
                {

                    int number;
                    int numbers_in_firstname = (from caracter in first_name
                                            where int.TryParse(caracter.ToString(), out number)
                                            select caracter).Count();
                    
                    if (numbers_in_firstname > 0)
                    {
                        throw new IncorrectNameException();
                    }
                    
                    p = new Person(first_name, last_name, phone_number);
                    this.registerPerson(p);
                    Console.WriteLine("\nPersona Registrada.");
                }
                catch(IncorrectNameException e)
                {
                    Console.WriteLine(e.Message);
                    i -= 1;
                    Console.WriteLine("Vuelva a ingresar los datos de la persona que desea registrar.");
                    Thread.Sleep(1500);

                }
                finally
                {
                    Console.Clear();
                }

                

            }
        }

        

        
    }
}
