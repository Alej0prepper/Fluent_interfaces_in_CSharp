using System.Reflection.Emit;
using System.Net.Http.Headers;
using Interfaces;

namespace InterfacesImplementation{

    public class Person : IPerson
    {
        string FirstName;
        string LastName;

        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public void SetLastName(string LastName)
        {
            this.LastName = LastName;

        }
         public void GetID(){
            System.Console.WriteLine(this.FirstName +" " + this.LastName);
        }
    }
    public class PersonFluent : IPersonFluent{
        string FirstName;
        string LastName;
    
        public IPersonFluent SetFirstName(string FirstName)
        {
           this.FirstName = FirstName;
           return this;
        }

        public IPersonFluent SetLastName(string LastName)
        {
           this.LastName = LastName;
           return this;
        }

        public void GetID(){
            System.Console.WriteLine(this.FirstName +" " + this.LastName);
        }
    }
}