using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        var Result = rentalManager.Add(new Rental { Id = 2, CarId = 1, CustomerId = 1, ReturnDate = DateTime.Now, RentDate = DateTime.Now });
    }
}