using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Services
{
    public interface IInterview
    {
        int Id { get; }
        string Title { get; }
        string Position { get; }
        string RequiredSkills { get; }

    }
}
