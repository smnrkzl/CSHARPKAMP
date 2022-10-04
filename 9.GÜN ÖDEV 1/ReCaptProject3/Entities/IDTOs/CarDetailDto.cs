using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IDTOs
{
    public class CarDetailDto:IDto
    {
        
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
