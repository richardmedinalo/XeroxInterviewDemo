using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{
    /// <summary>
    /// This is an UnitOfWork mixed with Repository design patterns Implementation
    /// UnitOfWork pattern: Usually we'll need to allow Transactions support
    /// Repository pattern: It's for CRUD implementation
    /// </summary>
    public class EntityFrameworkRepositoryContext : IRepositoryContext
    {
        private EntityFrameworkContext _context;

        private IInterviewRepository _interviewRepository;
        private IInterviewerRepository _interviewerRepository;

        public EntityFrameworkRepositoryContext()
        {
            _context = new EntityFrameworkContext();

            _interviewRepository = new InterviewRepository(_context);
            _interviewerRepository = new InterviewerRepository(_context);
        }
        public IInterviewerRepository InterviewerRepository
        {
            get
            {
                return _interviewerRepository;
            }
        }

        public IInterviewRepository InterviewRepository
        {
            get
            {
                return _interviewRepository;
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        internal EntityFrameworkContext Context
        {
            get { return _context; }
        }
    }
}
