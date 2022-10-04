using Business.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (var returnedCar in carManager.GetAll())
        {
            Console.WriteLine(returnedCar.Description);
        }
        Console.WriteLine("Hello, World!");
    }
}