using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewerBusinessReadingValidator : FluentValidator<InterviewerBusiness>
    {
        public InterviewerBusinessReadingValidator()
        {
            RuleFor(ib => ib.Id).GreaterThan(0).WithMessage("Interviewer's Id Required");
        }
    }
}
