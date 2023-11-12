using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public List<Staff> GetLastFourStaff()
        {
           using Context context = new Context();
            return context.Staffs.OrderByDescending(x=>x.StaffID).Take(4).ToList();
        }

        public int GetStaffCount()
        {
            using (Context context = new Context())
            {
               return context.Staffs.Count();
            }
        }
    }
}
