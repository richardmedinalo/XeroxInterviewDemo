using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data;

namespace XeroxInterviewDemo.Data.Repository
{

    /// <summary>
    /// this interface defines the members that this repository must have
    /// </summary>
    public interface IInterviewerRepository : IRepository<InterviewerData>
    {
        IEnumerable<InterviewData> GetInterviews ();
    }
}
