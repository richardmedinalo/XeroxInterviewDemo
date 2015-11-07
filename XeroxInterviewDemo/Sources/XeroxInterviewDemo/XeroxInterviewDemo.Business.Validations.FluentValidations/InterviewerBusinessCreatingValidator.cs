using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewerBusinessCreatingValidator : FluentValidator<InterviewerBusiness>
    {
        public InterviewerBusinessCreatingValidator()
        {
            RuleFor(ib => ib.Email).NotEmpty().EmailAddress().WithMessage("Interviewer's Email is not valid");
            RuleFor(ib => ib.Fullname).NotNull().NotEmpty().WithMessage("Interviewer's Fullname is required");
        }
    }
}
