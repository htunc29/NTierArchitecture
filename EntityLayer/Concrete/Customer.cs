﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAdress { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerPassword { get; set; }


    }
}
