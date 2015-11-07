using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business
{
    /// <summary>
    /// This is the class we are going to use for working with interviews
    /// on our bussines logic
    /// </summary>
    public class InterviewBusiness
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Position { get; set; }
        public string RequiredSkills { get; set; }
        public string Status { get; set; }
    }
}
