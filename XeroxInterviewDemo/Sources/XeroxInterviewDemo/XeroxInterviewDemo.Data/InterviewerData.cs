using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data
{
    /// <summary>
    /// This is our Interviewer Model class
    /// </summary>
    public class InterviewerData : IData
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Website { get; set;  }
        public string Skype { get; set;  }

        public IEnumerable<InterviewData> InterviewDataList;
    }
}
