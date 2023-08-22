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
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public void TAdd(Room entity)
		{
			_roomDal.Add(entity);
		}

		public void TDelete(Room entity)
		{
			_roomDal.Delete(entity);
		}

		public List<Room> TGetAll()
		{
			return _roomDal.GetAll();
		}

		public Room TGetById(int id)
		{
			return _roomDal.GetById(id);
		}

		public void TUpdate(Room entity)
		{
			_roomDal.Update(entity);
		}
	}
}
