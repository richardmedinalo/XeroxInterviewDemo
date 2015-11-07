using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{

    /// <summary>
    /// This is the interview entity what we going to use for saving interview's informations
    /// We can define Restriction and it will be mapped to
    /// SQL Server database (in this case)
    /// and implements IEntity interface for using on BaseRepository class
    /// </summary>
    public class InterviewEntity : IEntity
    {
        public int Id { get; set; }

        [Required (AllowEmptyStrings = false)]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set;  }

        [Required]
        [StringLength(255)]
        public string Position { get; set;  }

        [Required]
        [StringLength (9182)]
        public string RequiredSkills { get; set; }

        [StringLength (8192)]
        public string Comments { get; set; }

        public virtual List<InterviewerEntity> Interviewers { get; set; }
    }
}
