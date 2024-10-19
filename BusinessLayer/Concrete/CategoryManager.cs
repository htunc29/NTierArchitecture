using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _CategoryDal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _CategoryDal.GetById(id);
        }

        public void TInsert(Category t)
        {
           _CategoryDal.Insert(t);
        }

        public List<Category> TList()
        {
           return _CategoryDal.List();
        }

        public void TUpdate(Category t)
        {
           _CategoryDal.Update(t);
        }
    }
}
