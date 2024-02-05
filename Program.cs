using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person() { FirstName = "oğuzhan",LastName="Çırak",NationalIdentity=123456,DateOfBirthYear=1996 };
        PttManager pttManager = new PttManager(new PersonManager());
       
        pttManager.GiveMask(person1);
        
      
    }
}
