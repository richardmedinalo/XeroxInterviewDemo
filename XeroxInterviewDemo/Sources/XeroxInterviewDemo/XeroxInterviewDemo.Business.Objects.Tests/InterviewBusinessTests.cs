using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using XeroxInterviewDemo.Business;
using XeroxInterviewDemo.Business.Objects;
using XeroxInterviewDemo.Business.Workbenchs;



namespace XeroxInterviewDemo.Business.Objects.Tests
{
    [TestClass]
    public class InterviewBusinessTests
    {

        private IWorkbench workbench = new DefaultWorkbench ();
        [TestMethod]
        public void CreateTest()
        {
            InterviewBusiness interviewBusiness = new InterviewBusiness
            {
                Title = "InterviewTitle",
                Position = "InterviewPosition",
                Date = DateTime.Now.AddDays (2),
                RequiredSkills = "InterviewRequiredSkills"
            };

            IInterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(workbench);

            interviewBusinessObject.Create(interviewBusiness);

            

            Assert.AreEqual(0, interviewBusinessObject.Validator.CreatingValidator.ValidationMessages.Count);
        }

        [TestMethod]
        public void ReadTest ()
        {
            int id = 1;

            IInterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(workbench);

            InterviewBusiness interviewBusiness = interviewBusinessObject.Read(id);


            Assert.AreEqual (0, interviewBusinessObject.Validator.ReadingValidator.ValidationMessages.Count);
        }


        [TestMethod]
        public void UpdateTest ()
        {
            int id = 1;
            IInterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(workbench);

            InterviewBusiness interviewBusiness = interviewBusinessObject.Read(id);
            interviewBusiness.Title = "Updated from Test";

            interviewBusinessObject.Update(interviewBusiness);

            Assert.AreEqual(0, interviewBusinessObject.Validator.UpdatingValidator.ValidationMessages.Count);
        }

        [TestMethod]
        public void ReadAllTest ()
        {
            IEnumerable<InterviewBusiness> interviewBusinessEnumerable = null;

            IInterviewBusinessObject interviewBusinessObject = new InterviewBusinessObject(workbench);
            interviewBusinessEnumerable = interviewBusinessObject.ReadAll();
        }
    }
}
