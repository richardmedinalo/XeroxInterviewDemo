using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XeroxInterviewDemo.ViewModels
{
    /// <summary>
    /// ViewModel that defines how Interviewer must be managed
    /// </summary>
    public class InterviewerViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string Fullname { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Website { get; set; }

        [StringLength(100)]
        public string Skype { get; set; }


        public virtual List<InterviewViewModel> Interviews { get; set; }
    }
}
