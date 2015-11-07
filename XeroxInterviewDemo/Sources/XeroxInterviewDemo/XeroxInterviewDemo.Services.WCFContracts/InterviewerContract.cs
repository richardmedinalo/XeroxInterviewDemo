using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace XeroxInterviewDemo.Services.WCFContracts
{
    public class InterviewerContract
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Fullname { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Website { get; set; }
        [DataMember] public string Skype { get; set; }
    }
}
