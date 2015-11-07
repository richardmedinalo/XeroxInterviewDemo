using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Data;
using XeroxInterviewDemo.Data.Repository;
using XeroxInterviewDemo.Business.Validations;

using XeroxInterviewDemo.Business.Workbenchs;

using AutoMapper;

namespace XeroxInterviewDemo.Business.Objects
{
    public class InterviewerBusinessObject : IInterviewerBusinessObject
    {
        private IWorkbench _workbench = null;
       
        public ICRUDValidator<InterviewerBusiness> Validator
        {
            get { return _workbench.InterviewerBusinessCRUDValidator; }
        }

        public InterviewerBusinessObject(IWorkbench workbench)
        {
            _workbench = workbench;
        }

        public bool Create(InterviewerBusiness interviewerBusiness)
        {
            bool result = false;
            InterviewerData interviewerData = null;

            if (Validator != null)
            {
                if (Validator.CreatingValidator != null)
                {
                    Validator.CreatingValidator.PerformValidation(interviewerBusiness);
                    if (Validator.CreatingValidator.ValidationMessages.Count() == 0)
                    {
                        Mapper.CreateMap<InterviewerBusiness, InterviewerData>();
                        interviewerData = Mapper.Map<InterviewerData>(interviewerBusiness);

                        IRepositoryContext context = null;

                        try
                        {
                            using (context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                context.InterviewerRepository.Create(interviewerData);
                            }
                            result = true;
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {

                        }
                    }
                }
                else throw new NullReferenceException("Deleting Validator is not valid");
            }
            else throw new NullReferenceException("Validator is not a valid instance");
            return result;
        }

        public bool Delete(InterviewerBusiness interviewerBusiness)
        {
            bool result = false;

            if (Validator != null)
            {
                if (Validator.DeletingValidator != null)
                {
                    Validator.DeletingValidator.PerformValidation(interviewerBusiness);
                    if (Validator.DeletingValidator.ValidationMessages.Count() == 0)
                        result = false;

                    try
                    {
                        using (IRepositoryContext context = _workbench.RepositoryFactory.CreateRepositoryContext())
                        {
                            context.InterviewerRepository.Delete(interviewerBusiness.Id);
                        }
                        result = true;
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        // web must ensure that database is closed
                    }
                }
                else throw new NullReferenceException("Deleting Validator is invalid");
            }
            else throw new NullReferenceException("Validator is invalid");

            return result;
        }

        public InterviewerBusiness Read(int id)
        {
            InterviewerData interviewerData = null;
            InterviewerBusiness interviewerBusiness = new InterviewerBusiness();
            interviewerBusiness.Id = id;

            if (Validator != null)
            {
                if (Validator.ReadingValidator != null)
                {
                    Validator.ReadingValidator.PerformValidation(interviewerBusiness);
                    if (Validator.ReadingValidator.ValidationMessages.Count() == 0)
                    {
                        
                        IRepositoryContext context = null;

                        try
                        {
                            using (context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                interviewerData = context.InterviewerRepository.Read(interviewerBusiness.Id);
                            }
                            interviewerBusiness = null;
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {

                        }
                        if (interviewerData != null)
                        {
                            Mapper.CreateMap<InterviewData, InterviewBusiness>();
                            interviewerBusiness = Mapper.Map<InterviewerBusiness>(interviewerData);
                        }
                    }
                }
                else throw new NullReferenceException("Reading validator is invalid");
            }
            else throw new NullReferenceException("Validator is invalid");
            return interviewerBusiness;
        }

        public IEnumerable<InterviewerBusiness> ReadAll()
        {
            IEnumerable<InterviewerData> interviewerDataEnumerable = null;
            IRepositoryContext context = null;

            try
            {
                using (context  = _workbench.RepositoryFactory.CreateRepositoryContext ())
                {
                    interviewerDataEnumerable = context.InterviewerRepository.ReadAll();
                }
            }
            catch
            {
                throw;
            } finally
            {

            }

            Mapper.CreateMap<InterviewerData, InterviewerBusiness>();
            return Mapper.Map<List<InterviewerBusiness>>(interviewerDataEnumerable);

        }

        public bool Update(InterviewerBusiness interviewerBusiness)
        {
            bool result = false;
            InterviewerData interviewerData = null;

            if (Validator != null)
            {
                if (Validator.UpdatingValidator != null)
                {
                    Validator.UpdatingValidator.PerformValidation(interviewerBusiness);
                    if (Validator.UpdatingValidator.ValidationMessages.Count() == 0)
                    {
                        Mapper.CreateMap<InterviewerBusiness, InterviewerData>();
                        interviewerData = Mapper.Map<InterviewerData>(interviewerBusiness);

                        InterviewerBusiness interviewerBusinessExists = Read(interviewerBusiness.Id);

                        if (interviewerBusinessExists == null)
                            throw new Exception("Interview is invalid");

                        try
                        {
                            using (IRepositoryContext context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                context.InterviewerRepository.Update(interviewerData);
                                result = true;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                else throw new NullReferenceException("Updating validator is not valid");
            }
            else throw new NullReferenceException("Validator is not valid");

            return result;
        }
    }
}
