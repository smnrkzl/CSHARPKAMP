using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarName + " "  + " " +car.ModelYear + car.BrandName);
        }

        Console.WriteLine("Hello, World!");
    }
}