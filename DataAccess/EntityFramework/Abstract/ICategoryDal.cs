﻿using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
