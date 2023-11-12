using HotelProjectBusinessLayer.Abstract;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

        public List<Staff> GetLastFourStaff()
        {
            return _staffDal.GetLastFourStaff();
        }

        public void TAdd(Staff entity)
		{
			_staffDal.Add(entity);
		}

		public void TDelete(Staff entity)
		{
			_staffDal.Delete(entity);
		}

		public List<Staff> TGetAll()
		{
			return _staffDal.GetAll();
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}
