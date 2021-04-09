using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cst => cst.CustomerId).NotEmpty();
            RuleFor(cst => cst.CompanyName).NotEmpty();
        }
    }
}
