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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutusDal;

        public AboutUsManager(IAboutUsDal aboutusDal)
        {
            _aboutusDal = aboutusDal;
        }

        public void TAdd(AboutUs entity)
        {
            _aboutusDal.Add(entity);
        }

        public void TDelete(AboutUs entity)
        {
           _aboutusDal.Delete(entity);
        }

        public List<AboutUs> TGetAll()
        {
            return _aboutusDal.GetAll();
        }

        public AboutUs TGetById(int id)
        {
            return _aboutusDal.GetById(id);
        }

        public void TUpdate(AboutUs entity)
        {
            _aboutusDal.Update(entity);
        }
    }
}
