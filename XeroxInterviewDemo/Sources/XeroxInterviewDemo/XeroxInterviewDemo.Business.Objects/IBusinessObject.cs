using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Business.Validations;

namespace XeroxInterviewDemo.Business.Objects
{
    public interface IBusinessObject<T>
        where T : class
    {

        bool Create(T t);

        T Read(int id);
        IEnumerable<T> ReadAll();
        bool Update(T t);

        bool Delete(T t);

        ICRUDValidator<T> Validator { get; }
        
    }
}
