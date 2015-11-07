using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{

    /// <summary>
    /// Interviewer is an entity that represents a person who going to participate
    /// in the interview and one of these guys will be able to post comments about the interview
    /// </summary>
    public class InterviewerEntity : IEntity
    {
        public int Id { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string Fullname { get; set; }

        [StringLength (100)]
        public string Email { get; set; }

        [StringLength (255)]
        public string Website { get; set; }

        [StringLength (100)]
        public string Skype { get; set; }


        public virtual List<InterviewEntity> Interviews { get; set; }
    }
}