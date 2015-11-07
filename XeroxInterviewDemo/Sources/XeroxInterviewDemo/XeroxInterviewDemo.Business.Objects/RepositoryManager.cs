using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Data.Repository;

namespace XeroxInterviewDemo.Data.RepositoryAbstractFactory
{
    public class RepositoryManager
    {
        public IRepositoryFactory RepositoryLoader { get; set; }
        

        public RepositoryManager () : this(new EntityFrameworkRepositoryFactory())
        {

        }
        public RepositoryManager (IRepositoryFactory repositoryLoader)
        {
            RepositoryLoader = repositoryLoader;
        }
    }
}
