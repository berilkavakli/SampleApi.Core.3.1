using FluentValidation;
using FluentValidation.AspNetCore;
using SampleAPI.Core._3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Core._3._1.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(m => m.Code).NotEmpty();
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(x => x.PriceList).Must(x => x.Count >= 1)
                .WithMessage("There must be at least one price!")
                .When(x => x.PriceList != null);
            RuleForEach(x => x.PriceList)
                .SetValidator(new PriceValidator())
                .When(x => x.PriceList != null);
        }
    }
}
