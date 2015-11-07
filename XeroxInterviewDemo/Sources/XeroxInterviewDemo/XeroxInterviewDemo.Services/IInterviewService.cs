using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Services
{
    public interface IInterviewService
    {
        bool Create();
        IInterview Read();
    }
}
