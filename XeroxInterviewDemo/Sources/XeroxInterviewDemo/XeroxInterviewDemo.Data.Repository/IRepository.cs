using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data.Repository
{
    /// <summary>
    /// This is a generic repository that defines the CRUD operations
    /// </summary>
    /// <typeparam name="T">Must be a class that will be used to perform CRUD operations</typeparam>
    public interface IRepository<T> 
        where T : class
    {
        //IUnitOfWork UnitOfWork { get; }
        T Read(int id);
        IEnumerable<T> ReadAll();

        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
