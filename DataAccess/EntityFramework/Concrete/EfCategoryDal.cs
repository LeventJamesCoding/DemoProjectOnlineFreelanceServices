using Core.DataAccess;
using DataAccess.EntityFramework.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Concrete
{
    public class EfCategoryDal : EfEntityRepository<FreeLancelotDbContext, Category>, ICategoryDal
    {

    }
}
