﻿using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {

    }
}