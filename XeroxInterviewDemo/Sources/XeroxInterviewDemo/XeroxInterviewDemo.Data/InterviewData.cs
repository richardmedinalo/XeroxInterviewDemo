using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Data
{
    /// <summary>
    /// This is our Interview Model class
    /// </summary>
    public class InterviewData : IData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set;  }
        public string Position { get; set; }
        public string RequiredSkills { get; set; }

        public string Comments { get; set; }

        public IEnumerable<InterviewerData> InterviewerDataList;
    }
}
