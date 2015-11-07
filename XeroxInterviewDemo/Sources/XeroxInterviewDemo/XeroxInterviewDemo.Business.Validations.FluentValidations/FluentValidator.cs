using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class FluentValidator<T> : AbstractValidator<T>, IValidator<T>
        where T : class
    {

        public ICollection<ValidationMessage> ValidationMessages { get; protected set; }

        public FluentValidator ()
        {
            ValidationMessages = new List<ValidationMessage>();
        }


        public virtual ICollection<ValidationMessage> PerformValidation (T t)
        {
            ValidationMessages = new ValidationMessage[0];

            FluentValidation.Results.ValidationResult validationResults = Validate(t);

            if (!validationResults.IsValid)
            {
                List<ValidationMessage> validationMessageList = new List<ValidationMessage>();
                foreach (FluentValidation.Results.ValidationFailure error in validationResults.Errors)
                {
                    validationMessageList.Add(new ValidationMessage { Code = 0, Message = error.ErrorMessage});
                }

                ValidationMessages = validationMessageList;
            }

            return ValidationMessages;
        }
    }
}
