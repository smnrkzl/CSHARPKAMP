using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }

            else
            {
                Console.WriteLine("Araba marka ismi minimum 2 karakter olmalı, günlük fiyat ise 0'dan büyük olmalıdır");
            }
        }

        public List<CarDetailDto> GetAll()
        {
            return _carDal.GetCarDetailDtos();
        }
    }
}
