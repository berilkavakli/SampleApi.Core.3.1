using FluentValidation;
using SampleAPI.Core._3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Core._3._1.Validators
{
    public class PriceValidator : AbstractValidator<Price>
    {
        public PriceValidator()
        {
            RuleFor(m => m.Type).NotEmpty();
            RuleFor(m => m.Value).NotEmpty();
        }
    }
}
