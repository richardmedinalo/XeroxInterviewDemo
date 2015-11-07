using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data.Repository;
using XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository;

namespace XeroxInterviewDemo.Data.RepositoryLoader
{

    /// <summary>
    /// This is an EntityFramework Contrete Factory
    /// </summary>

    public class EntityFrameworkRepositoryFactory : IRepositoryFactory
    {

        public IRepositoryContext CreateRepositoryContext()
        {
            IRepositoryContext repositoryContext = new EntityFrameworkRepositoryContext();

            //if (repositoryName == "EntityFramework")
              //  repositoryContext = new EntityFrameworkRepositoryContext();
            /*
            else if (repositoryName == "FlatFile")
                repositoryContext = new FlatFileRepositoryContext();
            else if (repositoryName == "ExcelFile")
                repositoryContext = new ExcelFileRepositoryContext();
            else if (repositoryName == "AnotherDatabase")
                repositoryContext = new AnotherDatabaseRepositoryContext();
           */
           
            return repositoryContext;
        }
    }
}
