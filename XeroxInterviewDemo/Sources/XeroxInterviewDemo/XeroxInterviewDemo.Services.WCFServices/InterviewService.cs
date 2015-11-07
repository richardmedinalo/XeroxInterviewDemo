using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using XeroxInterviewDemo.Business;
using XeroxInterviewDemo.Business.Objects;
using XeroxInterviewDemo.Business.Validations;
using XeroxInterviewDemo.Business.Workbenchs;


using AutoMapper;

namespace XeroxInterviewDemo.Services.WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    
    public class InterviewService : IInterviewService
    {
        
        public ICollection<string> Create(InterviewContract interviewContract)
        {
            string [] result = new string [0];
            IWorkbench workbench = new DefaultWorkbench();
            InterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(workbench);

            Mapper.CreateMap<InterviewContract, InterviewBusiness>();

            InterviewBusiness interviewBusiness = Mapper.Map<InterviewBusiness>(interviewContract);

            bool businessResult = interviewBusinessObject.Create(interviewBusiness);

            if (!businessResult)
            {
                int messageCount = interviewBusinessObject.Validator.CreatingValidator.ValidationMessages.Count;
                result = new string[messageCount];

                for (int i = 0; i < messageCount; i ++)
                {
                    ValidationMessage vm = interviewBusinessObject.Validator.CreatingValidator.ValidationMessages.ElementAt (i);
                    result[i] = vm.ToString ();
                }
                    
            }

            //InterviewCreatingWork

            return result;
        }
    }
}
