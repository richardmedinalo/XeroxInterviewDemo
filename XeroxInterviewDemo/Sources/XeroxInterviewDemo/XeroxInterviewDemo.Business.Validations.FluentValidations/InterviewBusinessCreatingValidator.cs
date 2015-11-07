using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Business;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class InterviewBusinessCreatingValidator : FluentValidator<InterviewBusiness>
    {
        public InterviewBusinessCreatingValidator()
        {
            RuleFor(ib => ib.Title).NotEmpty().WithMessage("Interview's title is required");
            RuleFor(ib => ib.Position).NotEmpty().WithMessage("Interview's Position is required");
            RuleFor(ib => ib.RequiredSkills).NotEmpty().WithMessage("Interview Required Skills is required");
            RuleFor(ib => ib.Date).NotNull().GreaterThan(DateTime.Now.AddDays (1)).WithMessage("Interview's Date can not be before tomorrow");
        }
    }
}
