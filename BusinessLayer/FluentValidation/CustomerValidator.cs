using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Customer Name cannot be empty");
            RuleFor(x => x.CustomerSurname).NotEmpty().WithMessage("Customer Surname cannot be empty");
            RuleFor(x => x.CustomerAdress).NotEmpty().WithMessage("Customer Adress cannot be empty");
            RuleFor(x => x.CustomerMail).NotEmpty().WithMessage("Customer Mail cannot be empty");
            RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("Customer Password cannot be empty");
            RuleFor(x => x.CustomerMail).EmailAddress().WithMessage("Please enter a valid email address");

        }
    }
}
