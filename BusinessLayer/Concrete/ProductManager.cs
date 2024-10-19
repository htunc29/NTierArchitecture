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
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public Product TGetById(int id)
        {
          return   _ProductDal.GetById(id);
        }

        public void TInsert(Product t)
        {
           _ProductDal.Insert(t);
        }

        public List<Product> TList()
        {
           return _ProductDal.List();
        }

        public void TUpdate(Product t)
        {
           _ProductDal.Update(t);
        }
    }
}
