using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewerBusinessUpdatingValidator : InterviewerBusinessCreatingValidator
    {
        public InterviewerBusinessUpdatingValidator()
        {
            RuleFor(ib => ib.Id).GreaterThan(0).WithMessage("Interviewer's Id is Required");
        }
    }
}
