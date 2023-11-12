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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

        public int SubscribeCount()
        {
            return _subscribeDal.SubscribeCount();
        }

        public void TAdd(Subscribe entity)
		{
			_subscribeDal.Add(entity);
		}

		public void TDelete(Subscribe entity)
		{
			_subscribeDal.Delete(entity);
		}

		public List<Subscribe> TGetAll()
		{
			return _subscribeDal.GetAll();	
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDal.GetById(id);
		}

		public void TUpdate(Subscribe entity)
		{
			_subscribeDal.Update(entity);
		}
	}
}
