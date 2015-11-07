using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewerBusinessDeletingValidator : FluentValidator<InterviewerBusiness>
    {
        public InterviewerBusinessDeletingValidator()
        {
            RuleFor(ib => ib.Id).GreaterThan(0).WithMessage("Interviewer's Id Required");
        }
    }
}
