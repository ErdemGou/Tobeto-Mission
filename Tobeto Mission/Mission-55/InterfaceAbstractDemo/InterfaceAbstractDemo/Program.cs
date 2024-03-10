using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.References.Abstract;
using InterfaceAbstractDemo.References.Consrete;

internal class Program
{
    private static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        customerManager.Save(new Customer { DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName="Demiroğ", NationalityId = "24234234344" });

        Console.ReadLine();
    }
}
