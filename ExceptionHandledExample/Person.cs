using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandledExample
{
    public class Person
    {
        private string first_name;
        private string last_name;
        private int phone_number;
        public Person(string fn, string ln, int pn)
        {
            
             this.first_name = fn;
            this.last_name = ln;
            this.phone_number = pn;            
            
        }

        public void displayInfo()
        {
            Console.WriteLine($"Primer nombre: {first_name}.");
            Console.WriteLine($"Apellido: {last_name}.");
            Console.WriteLine($"Numero de telefono: {phone_number}.");

        }

    }
}
