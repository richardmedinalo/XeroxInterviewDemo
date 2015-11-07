using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Data.Repository;
using XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository;
using XeroxInterviewDemo.Data.RepositoryAbstractFactory;

using XeroxInterviewDemo.Business.Validations;
using XeroxInterviewDemo.Business.Validations.FluentValidations;

namespace XeroxInterviewDemo.Business.Workbenchs
{
    public class DefaultWorkbench : Workbench
    {
        /// <summary>
        /// Default workbench define what I've implemented
        /// For database: EntityFramework
        /// For validation: FluentValidation  
        /// </summary>
        public DefaultWorkbench()
        {
            RepositoryFactory = new EntityFrameworkRepositoryFactory();

            InterviewBusinessCRUDValidator = new FluentInterviewBusinessCRUDValidator();
            InterviewerBusinessCRUDValidator = new FluentInterviewerBusinessCRUDValidator();
        }
    }
}
