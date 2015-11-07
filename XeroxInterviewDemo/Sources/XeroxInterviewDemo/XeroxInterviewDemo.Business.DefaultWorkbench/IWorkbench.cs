using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Business.Validations;
using XeroxInterviewDemo.Data.RepositoryAbstractFactory;

namespace XeroxInterviewDemo.Business.DefaultWorkbench
{
    public interface IWorkbench
    {
        IInterviewBusinessCRUDValidator InterviewBusinessCRUDValidator { get; }
        IInterviewerBusinessCRUDValidator InterviewerBusinessCRUDValidator { get; }
        IRepositoryFactory RepositoryFactory { get; }
    }
}
