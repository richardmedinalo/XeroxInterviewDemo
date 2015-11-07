using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Business;

namespace XeroxInterviewDemo.Business.Rules
{
    public class InterviewBusinessRules
    {
       
        public bool InterviewBusinessIsNotNull (InterviewBusiness interviewBusiness)
        {
            return false;
        }

        public bool InterviewBuisinessIsValidId (InterviewBusiness interviewBusiness)
        {
            bool ret = true;

            interviewBusiness.Status = string.Empty;

            if (interviewBusiness.Id < 1)
            {
                interviewBusiness.Status = "Interview's Id is invalid";
                ret = false;
            }

            return ret;
        }

        public bool InterviewBusinessIsValidForSearching (InterviewBusiness interviewBusiness)
        {
            interviewBusiness.Status = string.Empty;

            return InterviewBuisinessIsValidId(interviewBusiness);
        }

        public bool InterviewBusinessIsValidForSaving (InterviewBusiness interviewBusiness)
        {
            bool ret = true;

            interviewBusiness.Status = string.Empty;

            if (string.IsNullOrEmpty (interviewBusiness.Title) || interviewBusiness.Title.Trim ().Length == 0)
            {
                interviewBusiness.Status = "Interview's title is invalid";
                ret = false;
            }
            else if (string.IsNullOrEmpty (interviewBusiness.Position) || interviewBusiness.Position.Trim ().Length == 0)
            {
                interviewBusiness.Status = "Interview's position is invalid";
                ret = false;
            } else if (string.IsNullOrEmpty (interviewBusiness.RequiredSkills) || interviewBusiness.RequiredSkills.Trim ().Length == 0)
            {
                interviewBusiness.Status = "Interview's Required Skills is invalid";
                ret = false;
            }

            return ret;
        }


        public bool InterviewBusinessIsValidForUpdating (InterviewBusiness interviewBusiness)
        {
            interviewBusiness.Status = string.Empty;
            return InterviewBuisinessIsValidId (interviewBusiness) && InterviewBusinessIsValidForSaving (interviewBusiness);
        }

        public bool InterviewBusinessIsValidForDeleting (InterviewBusiness interviewBusiness)
        {
            interviewBusiness.Status = string.Empty;
            return InterviewBuisinessIsValidId(interviewBusiness);
        }

    }
}
