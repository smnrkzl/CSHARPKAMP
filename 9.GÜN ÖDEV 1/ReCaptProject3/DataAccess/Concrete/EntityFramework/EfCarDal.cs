using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (CarContext context = new CarContext())
            {
                var result = from p in context.CarTable
                             join c in context.BrandTable
                             on p.Id equals c.Id
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 BrandName = c.BrandName,
                                 ModelYear = p.ModelYear,
                                 DailyPrice = p.DailyPrice

                             };
                return result.ToList();
            }
        }
    }
}
