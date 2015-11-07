using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewBusinessReadingValidator : FluentValidator<InterviewBusiness>
    {
        public InterviewBusinessReadingValidator()
        {
            RuleFor(ib => ib.Id).GreaterThan(0).WithMessage("Interview's Id must be greater than zero");
        }
    }
}
