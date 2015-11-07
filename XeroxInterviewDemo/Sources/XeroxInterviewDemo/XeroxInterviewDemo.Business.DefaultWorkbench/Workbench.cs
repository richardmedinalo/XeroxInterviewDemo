using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Business.Validations;
using XeroxInterviewDemo.Data.Repository;
using XeroxInterviewDemo.Data.RepositoryAbstractFactory;

namespace XeroxInterviewDemo.Business.DefaultWorkbench
{
    public class Workbench: IWorkbench
    {
        public IInterviewBusinessCRUDValidator InterviewBusinessCRUDValidator { get; protected set; }
        public IInterviewerBusinessCRUDValidator InterviewerBusinessCRUDValidator { get; protected set; }
        public IRepositoryFactory RepositoryFactory { get; protected set; }
    }
}
