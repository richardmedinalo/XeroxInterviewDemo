using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data.Repository;
using System.Data.Entity;
using AutoMapper;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{
    /// <summary>
    /// This is a base repository that allow us to create 
    /// all the different repositories including
    /// CRUD operations (Create/Read/Update/Delete)
    /// T and U generic types will map its values each other
    /// both of these types has a constrain (both must be classes)
    /// </summary>
    /// <typeparam name="T">T is the entity that will be mapped to Database (it must implements IEntity interface)</typeparam>
    /// <typeparam name="U">U is the corresponding class in the domain (it must implements IData interface)</typeparam>

    public class EntityFrameworkBaseRepository<T, U> 
        where T : class, IEntity
        where U : class, IData
    {
        private EntityFrameworkContext _context;
        private DbSet<T> _dbSet;



        internal EntityFrameworkBaseRepository(EntityFrameworkContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(int id)
        {
            T t = _dbSet.FirstOrDefault(r => r.Id == id);

            _dbSet.Remove(t);
        }

        public U Read(int id)
        {
            U u = null;
            Mapper.CreateMap<T, U>();

            T t = _dbSet.FirstOrDefault (r => r.Id == id);

            if (t != null)
                u = Mapper.Map<U>(t);

            return u;
        }

        public IEnumerable<U> ReadAll()
        {
            Mapper.CreateMap<T, U>();

            IEnumerable<T> tEnumerable = _dbSet.ToList();

            IEnumerable<U> uEnumerable = Mapper.Map<List<U>>(tEnumerable);

            return uEnumerable;
        }

        /*
        public IEnumerable<InterviewData> GetByReference(string reference)
        {
            IEnumerable<InterviewData> interviewDataEnumerable = null;

            IEnumerable<InterviewEntity> interviewEntityEnumerable = null;
            if (reference == string.Empty)
                interviewEntityEnumerable = _context.Interviews.ToList();
            else
                interviewEntityEnumerable = _context.Interviews.Where(i => i.Title.Contains(reference));

            Mapper.CreateMap<InterviewEntity, InterviewData>();

            if (interviewEntityEnumerable != null)
                interviewDataEnumerable = Mapper.Map<IEnumerable<InterviewData>>(interviewEntityEnumerable);

            return interviewDataEnumerable;
        }
        */

        public void Create(U u)
        {
            Mapper.CreateMap<U, T>();

            T t = Mapper.Map<T>(u);
            //t.Id = 0;
            _dbSet.Add(t);

            _context.SaveChanges();
            u.Id = t.Id;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        
        public void Update(U u)
        {
            Mapper.CreateMap<U, T>();
            

            T t = Mapper.Map<T>(u);
            _dbSet.Attach(t);

            _context.Entry(t).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// It's internal to allow database isolation
        /// </summary>
        internal EntityFrameworkContext Context
        {
            get { return _context;  }
        }
    }
}
