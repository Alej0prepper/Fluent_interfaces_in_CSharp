using System.Reflection.Metadata;
using Interfaces;
using InterfacesImplementation;

namespace Program{

    class Program{

        public static void Main(string[] args)
        {
            // using a common interface
            Person person = new Person();
            person.SetFirstName("Jorge");
            person.SetLastName("El Salvaje");
            // using a fluent interface
            IPersonFluent personFluent = new PersonFluent().SetFirstName("Jorge").SetLastName("El Curioso");
            
            person.GetID();
            // personFluent.GetID();
        }
    }
}