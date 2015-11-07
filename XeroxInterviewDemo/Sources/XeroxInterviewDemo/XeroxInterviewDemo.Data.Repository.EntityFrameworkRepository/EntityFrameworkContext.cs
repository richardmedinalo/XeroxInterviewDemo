using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{

    /// <summary>
    /// I used Entity Framework CodeFirst Approach because is more customizable
    /// Using CodeFirst approach we can create a blank SQLLocalDb database if it doesn't exists
    /// The other ones approachs are ModelFirst and DatabaseFirst
    /// Using ModelFirst approach VisualStudio provides a modeling tool where we can design the database
    /// and using DatabaseFirst approach we can use a pre-created database (VisualStudio provides a Wizard to import it)   
    /// 
    /// DbContext (base class) is used to perform the database connection
    /// </summary>
    /// 
    internal class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext () : base ("XeroxInterviewDemo")
        {
        }

        public DbSet<InterviewEntity> Interviews { get; set; }
        public DbSet<InterviewerEntity> Interviewers { get; set; }

    }
}
