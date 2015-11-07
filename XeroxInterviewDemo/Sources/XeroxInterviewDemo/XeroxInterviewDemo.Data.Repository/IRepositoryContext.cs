using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data.Repository
{

    /// <summary>
    /// Unit Of work interface definition
    /// We'll usually need to use transactions
    /// </summary>
    
    public interface IRepositoryContext : IDisposable
    {
        IInterviewRepository InterviewRepository { get; }
        IInterviewerRepository InterviewerRepository { get;  }
        void Commit();
        void Rollback();
    }
}
