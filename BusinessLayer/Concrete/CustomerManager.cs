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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            _CustomerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
          return   _CustomerDal.GetById(id);
        }

        public void TInsert(Customer t)
        {
            _CustomerDal.Insert(t);
        }

        public List<Customer> TList()
        {
          return _CustomerDal.List();   
        }

        public void TUpdate(Customer t)
        {
            _CustomerDal.Update(t);
        }
    }
}
