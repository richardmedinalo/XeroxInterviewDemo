using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data;
using XeroxInterviewDemo.Data.Repository;
using AutoMapper;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{
    /// <summary>
    /// Repository design pattern implementation:
    /// Since EntityFrameworkBaseRepository use generic types
    /// we can to define repositories just by adding T and U concrete types
    /// and both types will be map each other
    /// For this entity we are using InterviewerEntity and its corresponding Model class InterviewData
    /// </summary>

    public class InterviewerRepository 
        : EntityFrameworkBaseRepository<InterviewerEntity, InterviewerData>,IInterviewerRepository
    {
        internal InterviewerRepository(EntityFrameworkContext context) : base (context)
        {
        }
        
        private InterviewerRepository () : base (null)
        {
        }

        public IEnumerable<InterviewData> GetInterviews()
        {
            throw new NotImplementedException();
        }
    }
}
