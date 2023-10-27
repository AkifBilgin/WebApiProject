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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TAdd(MessageCategory entity)
        {
            _messageCategoryDal.Add(entity);
        }

        public void TDelete(MessageCategory entity)
        {
            _messageCategoryDal.Delete(entity);
        }

        public List<MessageCategory> TGetAll()
        {
            return _messageCategoryDal.GetAll();
        }

        public MessageCategory TGetById(int id)
        {
            return _messageCategoryDal.GetById(id);
        }

        public void TUpdate(MessageCategory entity)
        {
            _messageCategoryDal.Update(entity);
        }
    }
}
