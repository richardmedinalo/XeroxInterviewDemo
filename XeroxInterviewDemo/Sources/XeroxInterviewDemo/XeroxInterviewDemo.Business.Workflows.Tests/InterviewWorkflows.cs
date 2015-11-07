using System;
using System.Activities;
using System.Activities.XamlIntegration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using XeroxInterviewDemo.Business.Workflows;

namespace XeroxInterviewDemo.Business.Workflows.Tests
{
    [TestClass]
    public class InterviewWorkflows
    {
        [TestMethod]
        public void Create()
        {
            //CreateInterviewWorkflow2 ciw = new CreateInterviewWorkflow2();
            //ciw.Run();

            CreateInterviewWorkflow ciw = new CreateInterviewWorkflow();
            WorkflowInvoker wfi = new WorkflowInvoker(ciw);
            wfi.Invoke();
        }
    }
}
