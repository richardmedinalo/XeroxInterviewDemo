using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data.Repository;

namespace XeroxInterviewDemo.Data.RepositoryAbstractFactory
{ 
    /// <summary>
    /// This is an Abstract Factory (is redundant but I implemented to show how's it works)
    /// IRepository is the product that Abstract Factory create
    /// </summary>
public interface IRepositoryFactory
    {
        IRepositoryContext CreateRepositoryContext();
    }
}
