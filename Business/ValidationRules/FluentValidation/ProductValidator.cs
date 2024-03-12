using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(p=>p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA);
            RuleFor(p => p.CategoryId).Must(MaxTenProduct);

        }

        private bool MaxTenProduct(int arg)
        {
            if(arg >= 10)
            {
                throw new ArgumentException("En fazla 10 ürün olabilir");
            }
            return true;
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
