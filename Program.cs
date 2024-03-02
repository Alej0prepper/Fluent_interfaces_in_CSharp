using System.Reflection.Metadata;
using Interfaces;
using InterfacesImplementation;

namespace Program{

    class Program{

        public static void Main(string[] args)
        {
            // using a common interface
            IPerson person = new Person();
            person.SetFirstName("Jorge");
            person.SetLastName("El Salvaje");
            // using a fluent interface
            IPersonFluent personFluent = new PersonFluent().SetFirstName("Jorge").SetLastName("El Curioso");
            IPersonFluent Juan = new PersonFluent().SetFirstName("Juan").SetLastName("Perez");

            try {var a = (PersonFluent)Juan;
                a.GetID();
            }
            
            catch {System.Console.WriteLine("didn't work");}

            
            

           
        }
    }
}