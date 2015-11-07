using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business.Validations.FluentValidations
{
    public class FluentInterviewerBusinessCRUDValidator : IInterviewerBusinessCRUDValidator
    {
        private InterviewerBusinessReadingValidator _readingValidator;
        private InterviewerBusinessCreatingValidator _creatingValidator;
        private InterviewerBusinessUpdatingValidator _updatingValidator;
        private InterviewerBusinessDeletingValidator _deletingValidator;

        public FluentInterviewerBusinessCRUDValidator()
        {
            _readingValidator = new InterviewerBusinessReadingValidator();
            _creatingValidator = new InterviewerBusinessCreatingValidator();
            _updatingValidator = new InterviewerBusinessUpdatingValidator();
            _deletingValidator = new InterviewerBusinessDeletingValidator();
        }


        public IValidator<InterviewerBusiness> DeletingValidator
        {
            get
            {
                return _deletingValidator;
            }
        }

        public IValidator<InterviewerBusiness> CreatingValidator
        {
            get
            {
                return _creatingValidator;
            }
        }

        public IValidator<InterviewerBusiness> ReadingValidator
        {
            get
            {
                return _readingValidator;
            }
        }

        public IValidator<InterviewerBusiness> UpdatingValidator
        {
            get
            {
                return _updatingValidator;
            }
        }
    }
}
