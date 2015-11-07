using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data.Repository;

namespace XeroxInterviewDemo.Data.Repository.EntityFrameworkRepository
{
    // Just for testing
    internal class MySharedClass
    {
        public void AddInterview(InterviewData interviewData)
        {
            InterviewEntity interviewEntity = new InterviewEntity
            {
                Id = 0,
                Date = interviewData.Date,
                Position = interviewData.Position,
                RequiredSkills = interviewData.RequiredSkills,
                Title = interviewData.Title,
               
            };

            InterviewerEntity interviewerEntity = new InterviewerEntity
            {
                Fullname = "First Interviewer",
                Email = "firstinterviewer@xerox.com",
                Skype = "firstinterviewer",
                Website = "http://firstinterviewer.xerox.com"
            };


            using (EntityFrameworkContext context = new EntityFrameworkContext())
            {
                context.Interviews.Add(interviewEntity);
                context.Interviewers.Add(interviewerEntity);

                context.SaveChanges();
            }

        }
    }
}
