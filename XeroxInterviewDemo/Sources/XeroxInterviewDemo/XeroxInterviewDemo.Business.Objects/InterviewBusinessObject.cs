using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroxInterviewDemo.Data;
using XeroxInterviewDemo.Data.Repository;
using XeroxInterviewDemo.Business.Workbenchs;
using XeroxInterviewDemo.Business.Validations;

using AutoMapper;

namespace XeroxInterviewDemo.Business.Objects
{
    public class InterviewBusinessObject : IInterviewBusinessObject
    {
        private IWorkbench _workbench = null;

        

        public ICRUDValidator<InterviewBusiness> Validator
        {
            get { return _workbench.InterviewBusinessCRUDValidator; }
        }

        public InterviewBusinessObject(IWorkbench workbench)
        {
            _workbench = workbench;
        }


        public bool Create(InterviewBusiness interviewBusiness)
        {
            bool result = false;
            InterviewData interviewData = null;

            if (Validator != null)
            {
                if (Validator.CreatingValidator != null)
                {
                    Validator.CreatingValidator.PerformValidation(interviewBusiness);
                    if (Validator.CreatingValidator.ValidationMessages.Count() == 0)
                    {
                        Mapper.CreateMap<InterviewBusiness, InterviewData>();
                        interviewData = Mapper.Map<InterviewData>(interviewBusiness);

                        IRepositoryContext context = null;

                        try
                        {
                            using (context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                context.InterviewRepository.Create(interviewData);
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
                } else throw new NullReferenceException("Deleting Validator is not valid");
            } else throw new NullReferenceException("Validator is not a valid instance");
            return result;
        }

        public bool Delete(InterviewBusiness interviewBusiness)
        {
            bool result = false;

            if (Validator != null)
            {
                if (Validator.DeletingValidator != null)
                {
                    Validator.DeletingValidator.PerformValidation(interviewBusiness);
                    if (Validator.DeletingValidator.ValidationMessages.Count() == 0)
                        result = false;

                    try
                    {
                        using (IRepositoryContext context = _workbench.RepositoryFactory.CreateRepositoryContext())
                        {
                            context.InterviewRepository.Delete(interviewBusiness.Id);
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
                } else throw new NullReferenceException("Deleting Validator is invalid");
            } else throw new NullReferenceException("Validator is invalid");

            return result;
        }

        public InterviewBusiness Read(int id)
        {
            InterviewData interviewData = null;
            InterviewBusiness interviewBusiness = new InterviewBusiness();
            interviewBusiness.Id = id;

            if (Validator != null)
            {
                if (Validator.ReadingValidator != null)
                {
                    Validator.ReadingValidator.PerformValidation(interviewBusiness);
                    if (Validator.ReadingValidator.ValidationMessages.Count() == 0)
                    {
                        
                        IRepositoryContext context = null;

                        try
                        {
                            using (context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                interviewData = context.InterviewRepository.Read(interviewBusiness.Id);
                            }
                            interviewBusiness = null;
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {

                        }
                        if (interviewData != null)
                        {
                            Mapper.CreateMap<InterviewData, InterviewBusiness>();
                            interviewBusiness = Mapper.Map<InterviewBusiness>(interviewData);
                        }
                    }
                } else throw new NullReferenceException("Reading validator is invalid");
            } else throw new NullReferenceException("Validator is invalid");
            return interviewBusiness;
        }

        public IEnumerable<InterviewBusiness> ReadAll()
        {
            IEnumerable<InterviewBusiness> interviewBusinessEnumerable = null;
            IEnumerable<InterviewData> interviewDataEnumerable = null;

            try
            {
                using (IRepositoryContext context = _workbench.RepositoryFactory.CreateRepositoryContext())
                {
                    interviewDataEnumerable = context.InterviewRepository.ReadAll();
                }
            }
            catch (Exception)
            {
                throw;
            }

            Mapper.CreateMap<InterviewData, InterviewBusiness>();
            interviewBusinessEnumerable = Mapper.Map<IEnumerable<InterviewBusiness>>(interviewDataEnumerable);

            return interviewBusinessEnumerable;
        }

        public bool Update(InterviewBusiness interviewBusiness)
        {
            bool result = false;
            InterviewData interviewData = null;

            if (Validator != null)
            {
                if (Validator.UpdatingValidator != null)
                {
                    Validator.UpdatingValidator.PerformValidation(interviewBusiness);
                    if (Validator.UpdatingValidator.ValidationMessages.Count() == 0)
                    {
                        Mapper.CreateMap<InterviewBusiness, InterviewData>();
                        interviewData = Mapper.Map<InterviewData>(interviewBusiness);

                        InterviewBusiness interviewBusinessExists = Read(interviewBusiness.Id);

                        if (interviewBusinessExists == null)
                            throw new Exception("Interview is invalid");

                        try
                        {
                            using (IRepositoryContext context = _workbench.RepositoryFactory.CreateRepositoryContext())
                            {
                                context.InterviewRepository.Update(interviewData);
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
            } else throw new NullReferenceException("Validator is not valid");

            return result;
        }
    }
}
