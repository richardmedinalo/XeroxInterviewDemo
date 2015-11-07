using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using XeroxInterviewDemo.Business;
using XeroxInterviewDemo.Business.Objects;
using XeroxInterviewDemo.Business.Workbenchs;
using XeroxInterviewDemo.ViewModels;

using AutoMapper;

namespace XeroxInterviewDemo.Controllers
{
    public class InterviewController : Controller
    {
        private DefaultWorkbench _defaultWorkbench = new DefaultWorkbench ();
        
        // GET: Interview
        public ActionResult Index()
        {
            Mapper.CreateMap<InterviewBusiness, InterviewViewModel>();

            InterviewBusinessObject businessObject = new InterviewBusinessObject(_defaultWorkbench);

            IEnumerable<InterviewBusiness> list = businessObject.ReadAll();
            List<InterviewViewModel> interviewViewModelList = Mapper.Map<List<InterviewViewModel>>(list);

            IEnumerator<InterviewViewModel> enumerator = interviewViewModelList.GetEnumerator();


            return View(interviewViewModelList);
        }

        public ActionResult Create ()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Create (InterviewViewModel interviewViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Action");
            }

            return View(interviewViewModel);
        }


        public ActionResult Edit (InterviewViewModel interviewViewModel)
        {
            return View(interviewViewModel);
        }
    }
}