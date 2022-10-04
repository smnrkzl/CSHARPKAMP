using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
             {
                 new Car {Id = 1, BrandId = "1", ColorId = 3, DailyPrice = 254005, ModelYear = 2020, Description = "Sport"},
                 new Car{Id = 2,BrandId = "2",ColorId = 3,DailyPrice = 254005, ModelYear = 2000,Description = "Sport"},
                 new Car{Id = 3,BrandId = "3",ColorId = 32,DailyPrice = 5411, ModelYear = 2010,Description = "Manuel"},
                 new Car{Id = 4,BrandId = "4",ColorId = 3,DailyPrice = 8520, ModelYear = 2012,Description = "Hybrid"},
                 new Car{Id = 5,BrandId = "5",ColorId = 3,DailyPrice = 98742, ModelYear = 2003,Description = "Manuel"},

             };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(x => x.Id == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
