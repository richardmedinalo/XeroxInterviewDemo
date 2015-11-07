using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business.Validations
{
    public interface ICRUDValidator<T>
        where T : class 
    {
        IValidator<T> ReadingValidator { get; }
        IValidator<T> CreatingValidator { get; }
        IValidator<T> UpdatingValidator { get; }
        IValidator<T> DeletingValidator { get; }
    }
}
