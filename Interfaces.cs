using InterfacesImplementation;
namespace Interfaces
{
    public interface IPerson
    {
        void SetFirstName(string FirstName);
        void SetLastName(string LastName);
    }

    public interface IPersonFluent
    {
        IPersonFluent SetFirstName(string FirstName);
        IPersonFluent SetLastName(string LastName);
    }
     public interface IPersonFluentV
    {
        PersonFluent SetFirstName(string FirstName);
        PersonFluent SetLastName(string LastName);
    }
}