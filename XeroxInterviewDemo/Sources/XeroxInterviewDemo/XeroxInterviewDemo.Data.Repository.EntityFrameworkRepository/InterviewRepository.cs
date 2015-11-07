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
    /// For this entity we are using InterviewEntity and its corresponding Model class InterviewData
    /// </summary>

    public class InterviewRepository : EntityFrameworkBaseRepository<InterviewEntity, InterviewData>, IInterviewRepository
    {
        internal InterviewRepository(EntityFrameworkContext context) : base (context)
        {
        }
        private InterviewRepository() : base (null)
        {
        }

        public IEnumerable<InterviewData> GetByReference(string reference)
        {
            Mapper.CreateMap<InterviewEntity, InterviewerData>();
            IEnumerable<InterviewData> interviewDataEnumerable = null;
            

            IEnumerable<InterviewEntity> interviewEntityEnumerable = Context.Interviews.Where(r => r.Title.ToLower ().Contains(reference.ToLower ())).ToList ();

            interviewDataEnumerable = Mapper.Map<IEnumerable<InterviewData>>(interviewDataEnumerable);

            return interviewDataEnumerable;
        }

        public IEnumerable<InterviewerData> GetInterviewers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InterviewerData> GetInterviewers(InterviewData interviewData)
        {
            Mapper.CreateMap<InterviewerEntity, InterviewerData>();

            InterviewEntity interviewEntity = Context.Interviews.FirstOrDefault(r => r.Id == interviewData.Id);

            IEnumerable<InterviewerEntity> interviewerEntityEnumerable = interviewEntity.Interviewers;

            return Mapper.Map<IEnumerable<InterviewerData>>(interviewerEntityEnumerable);

        }
    }



    /*
    public class InterviewRepository : IInterviewRepository
    {
        private EntityFrameworkContext _context;

        private InterviewRepository ()
        {
            
        }
        internal InterviewRepository(EntityFrameworkContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            InterviewEntity interview = _context.Interviews.FirstOrDefault(i => i.Id == id);
            _context.Interviews.Remove(interview);
        }

        public InterviewData Get(int id)
        {
            InterviewData interviewData = null;
            Mapper.CreateMap<InterviewData, InterviewEntity>();

            InterviewEntity interviewEntity =_context.Interviews.FirstOrDefault(e => e.Id == id);

            if (interviewEntity != null)
                interviewData = Mapper.Map<InterviewData>(interviewEntity);

            return interviewData;
        }

        public IEnumerable<InterviewData> GetAll()
        {
            return GetByReference(string.Empty);
        }

        public IEnumerable<InterviewData> GetByReference(string reference)
        {
            IEnumerable<InterviewData> interviewDataEnumerable = null;

            IEnumerable<InterviewEntity> interviewEntityEnumerable = null;
            if (reference == string.Empty)
                interviewEntityEnumerable = _context.Interviews.ToList();
            else
                interviewEntityEnumerable = _context.Interviews.Where(i => i.Title.Contains (reference));

            Mapper.CreateMap<InterviewEntity, InterviewData>();

            if (interviewEntityEnumerable != null)
                interviewDataEnumerable = Mapper.Map<IEnumerable<InterviewData>>(interviewEntityEnumerable);

            return interviewDataEnumerable;
        }

        public void Save(InterviewData t)
        {
            Mapper.CreateMap<InterviewData, InterviewEntity>();

            InterviewEntity interviewEntity = Mapper.Map<InterviewEntity>(t);

            _context.Interviews.Add(interviewEntity);
            _context.SaveChanges();
        }

        public void Update(InterviewData t)
        {
            Mapper.CreateMap<InterviewData, InterviewEntity>();

            //InterviewEntity interviewEntity = Mapper.Map<InterviewEntity>(t);
            InterviewEntity interviewEntity = _context.Interviews.FirstOrDefault(delegate (InterviewEntity ie) {
                return ie.Id == t.Id;
            });

            interviewEntity.Position = t.Position;
            interviewEntity.Title = t.Title;
            interviewEntity.RequiredSkills = t.RequiredSkills;
            interviewEntity.Date = t.Date;

            _context.SaveChanges();
        }
    }
    */
}
