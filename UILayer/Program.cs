using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILayer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            ProductManager productManager = new ProductManager(new EfProductDal());
            CommentManager commentManager = new CommentManager(new EfCommentDal());
            Console.Write("New Customer Name:");
            string customerName=Console.ReadLine();
            Console.Write("New Customer Surname:");
            string customerSurname = Console.ReadLine();
            Console.Write("New Customer Adress:");
            string customerAdress = Console.ReadLine();
            Console.Write("New Customer Mail:");
            string customerMail = Console.ReadLine();
            Console.Write("New Customer Password:");
            string customerPassword = Console.ReadLine();
            Customer customer = new Customer
            { 
                CustomerName= customerName,
                CustomerSurname = customerSurname,
                CustomerAdress = customerAdress,
                CustomerMail = customerMail,
                CustomerPassword = customerPassword
            };
            customerManager.TInsert(customer);
            Console.WriteLine("Customer Added");
            Console.WriteLine("--------------------");
            Console.WriteLine("Customer List");
            foreach (var item in customerManager.TList())
            {
                Console.WriteLine("Customer Name:" + item.CustomerName);
                Console.WriteLine("Customer Surname:" + item.CustomerSurname);
                Console.WriteLine("Customer Adress:" + item.CustomerAdress);
                Console.WriteLine("Customer Mail:" + item.CustomerMail);
                Console.WriteLine("Customer Password:" + item.CustomerPassword);
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();
        }
    }
}
