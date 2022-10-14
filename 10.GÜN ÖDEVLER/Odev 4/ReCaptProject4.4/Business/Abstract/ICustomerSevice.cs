﻿using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerSevice
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IDataResult<Customer> GetbyId(int customerId);
        IDataResult<List<Customer>> GetAll();
        IResult Delete(Customer customer);
        
    }
}
