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
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(ToDoList entity)
        {
            _toDoListDal.Add(entity);
        }

        public void TDelete(ToDoList entity)
        {
            _toDoListDal.Delete(entity);
        }

        public List<ToDoList> TGetAll()
        {
            return _toDoListDal.GetAll();
        }

        public ToDoList TGetById(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public void TUpdate(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
