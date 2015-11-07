using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace XeroxInterviewDemo.ViewModels
{
    /// <summary>
    /// I defined Interview Viewmodel with its restrictions
    /// This is very similar to Entities, but we can add more
    /// restrictions according asp mvc (for example, DataType in this case for defining how to edit this field)
    /// </summary>

    public class InterviewViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]

        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Position { get; set; }

        [Required]
        [StringLength(9182)]
        [DataType(DataType.MultilineText)]
        public string RequiredSkills { get; set; }

        [StringLength(8192)]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public virtual List<InterviewerViewModel> Interviewers { get; set; }
    }
}
