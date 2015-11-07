using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business
{

    /// <summary>
    /// /// This is the class we are going to use for working with Interviewers
    /// on our bussines logic
    /// </summary>
    public class InterviewerBusiness
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Skype { get; set; }
    }
}
