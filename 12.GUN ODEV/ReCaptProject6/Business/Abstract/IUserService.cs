using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Delete(User user);
        IResult Update(User user);
        IResult Add(User user);
        
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetbyId(int userId);
    }
}
