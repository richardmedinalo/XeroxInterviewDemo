using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace XeroxInterviewDemo.Services.WCFContracts
{
    [DataContract]
    public class InterviewContract
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Title { get; set; }
        [DataMember]  public DateTime Date { get; set; }
        [DataMember] public string Position { get; set; }
        [DataMember] public string RequiredSkills { get; set; }
        [DataMember]  public string Status { get; set; }
    }
}
