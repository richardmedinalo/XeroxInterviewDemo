using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroxInterviewDemo.Business.Validations
{
    public class ValidationMessage
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public override string ToString ()
        {
            return string.Format("{0}:{1}", Code, Message);
        }
    }
}
