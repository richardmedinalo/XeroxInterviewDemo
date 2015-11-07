using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Business;
using XeroxInterviewDemo.Business.Objects;
using XeroxInterviewDemo.Business.Validations;
using XeroxInterviewDemo.Business.Workflows;

using XeroxInterviewDemo.Business.Workbenchs;
using System.Activities.Expressions;
using System.Activities;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /*
            InterviewBusiness interviewBusiness = new InterviewBusiness
            {
                Title = "InterviewTitle",
                Position = "InterviewPosition",
                Date = DateTime.Now,
                RequiredSkills = "InterviewRequiredSkills"
            };

            InterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(new DefaultWorkbench ());

            if (!interviewBusinessObject.Create(interviewBusiness))
            {
                Console.WriteLine("I could not create the interview");
                Console.WriteLine("Error List:");
                foreach (ValidationMessage validationMessage in interviewBusinessObject.Validator.CreatingValidator.ValidationMessages)
                {
                    Console.WriteLine("\t{0}", validationMessage);
                }
            }
            

          */

            InterviewBusiness ib = new InterviewBusiness
            {
                Date = DateTime.Now.AddDays(2),
                Title = "Title From Workflow",
                Position = "Position From Workflow",
                RequiredSkills = "RequiredSkills"
            };

            CreateInterviewWorkflow activity = new CreateInterviewWorkflow
            {
                InterviewBusiness = new InArgument<InterviewBusiness>((co) => ib)
            };

            System.Activities.WorkflowInvoker invoker = new System.Activities.WorkflowInvoker(activity);
            invoker.Invoke();

            Console.Write("Press Enter to continue...");
            Console.ReadLine();

        }
    }
}
