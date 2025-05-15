using Business.Abstract;
using Core.Results;
using DataAccess.EntityFramework.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }
        public IResult Add(Category category)
        {
            categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(categoryDal.Get(c => c.CategoryId == id));
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(categoryDal.GetAll());
        }

        public IResult Update(Category category)
        {
            categoryDal.Update(category);    
            return new SuccessResult();
        }
    }
}
