﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using FoodyTekmerEntityLayer.Concreate;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepositori<Product>, IProductDal
    {
    }
}
