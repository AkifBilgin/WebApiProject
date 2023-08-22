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
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TAdd(Service entity)
		{
			_serviceDal.Add(entity);
		}

		public void TDelete(Service entity)
		{
			_serviceDal.Delete(entity);
		}

		public List<Service> TGetAll()
		{
			return _serviceDal.GetAll();
		}

		public Service TGetById(int id)
		{
			return _serviceDal.GetById(id);
		}

		public void TUpdate(Service entity)
		{
			_serviceDal.Update(entity);
		}
	}
}
