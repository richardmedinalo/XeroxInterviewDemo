using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XeroxInterviewDemo.Services.WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //[ServiceContract]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [ServiceContract]
    public interface IInterviewService
    {
        [OperationContract]
        ICollection<string> Create(InterviewContract interview);
                
    }
}
