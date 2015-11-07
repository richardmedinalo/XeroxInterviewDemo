using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;


using XeroxInterviewDemo.Data.Repository;

namespace XeroxInterviewDemo.Data.RepositoryLoader
{

    /// <summary>
    /// We can create a plugin as dll and load it to use another storing system.
    /// </summary>

    public class DllRepositoryLoader : IRepositoryFactory
    {
        private string _filename = string.Empty;
        private string _repositoryContextClassFullname = "";


         
        public DllRepositoryLoader (bool loadFromDefaultDll) : 
            this ("XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository.dll", 
                "XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository.EntityFrameworkContext")
        {
        }

        // We can Load any dll repository using its dll filename and its full type name
        // Filename; must be in "plugins" directory

        public DllRepositoryLoader(string filename, string repositoryContextFullname)
        {
            _filename = filename;
            _repositoryContextClassFullname = repositoryContextFullname;
        }


        public IRepositoryContext CreateRepositoryContext()
        {
            string location = Assembly.GetExecutingAssembly().Location;
            location = Path.GetDirectoryName(location);

            location = Path.Combine(location, "plugins");

            string dlllocaiton = Path.Combine(location, _filename);
            var DLL = Assembly.LoadFile(dlllocaiton);

            Type type = DLL.GetType();

            IRepositoryContext unitOfwork = (IRepositoryContext)Activator.CreateInstance(type);

            return unitOfwork;
            //IInterviewRepository i = unitOfwork.InterviewRepository;

            //i.Create(new InterviewData { Title = "From Activator", Position = ".NET Software Engineer", RequiredSkills = "all masters", Date = DateTime.Now });
        }
    }
}
