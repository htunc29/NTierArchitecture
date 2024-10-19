using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        { 
        RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Comment Content cannot be empty");
            RuleFor(x => x.CommentContent).MinimumLength(3).WithMessage("Comment Content must be at least 3 characters");
            RuleFor(x => x.CommentContent).MaximumLength(100).WithMessage("Comment Content must be at most 100 characters");
            RuleFor(x => x.CommentDate).NotEmpty().WithMessage("Comment Date cannot be empty");
            RuleFor(x=>x.ProductID).NotEmpty().WithMessage("Product ID cannot be empty");
            RuleFor(x=>x.CustomerID).NotEmpty().WithMessage("Customer ID cannot be empty");

        }
    }
}
