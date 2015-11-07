using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{
    /// <summary>
    /// IEntity interface is an interface allow querying on the Generic Repository by Id
    /// I've defined this interface since we don't know properties in a Generic Type
    /// </summary>
    public interface IEntity
    {
        int Id { get; set; }
    }
}
