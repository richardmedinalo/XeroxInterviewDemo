using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Business;

namespace XeroxInterviewDemo.Business.Validations
{
    public interface IValidator<T>
        where T : class
    {
        ICollection<ValidationMessage> ValidationMessages { get; }
        ICollection<ValidationMessage> PerformValidation(T t);
    }
}
