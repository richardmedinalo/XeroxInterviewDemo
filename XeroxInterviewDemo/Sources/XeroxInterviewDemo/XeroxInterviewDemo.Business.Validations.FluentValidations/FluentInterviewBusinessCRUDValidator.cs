using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class FluentInterviewBusinessCRUDValidator : IInterviewBusinessCRUDValidator
    {
        private InterviewBusinessReadingValidator _readingValidator;
        private InterviewBusinessCreatingValidator _creatingValidator;
        private InterviewBusinessUpdatingValidator _updatingValidator;
        private InterviewBusinessDeletingValidator _deletingValidator;

        public FluentInterviewBusinessCRUDValidator()
        {
            _readingValidator = new InterviewBusinessReadingValidator();
            _creatingValidator = new InterviewBusinessCreatingValidator();
            _updatingValidator = new InterviewBusinessUpdatingValidator();
            _deletingValidator = new InterviewBusinessDeletingValidator();
        }


        public IValidator<InterviewBusiness> DeletingValidator
        {
            get
            {
                return _deletingValidator;
            }
        }

        public IValidator<InterviewBusiness> CreatingValidator
        {
            get
            {
                return _creatingValidator;
            }
        }

        public IValidator<InterviewBusiness> ReadingValidator
        {
            get
            {
                return _readingValidator;
            }
        }

        public IValidator<InterviewBusiness> UpdatingValidator
        {
            get
            {
                return _updatingValidator;
            }
        }
    }
}
