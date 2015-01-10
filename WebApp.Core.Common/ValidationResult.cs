using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Common
{
    public class ValidationResult
    {
        public ValidationResult()
        { }

        public ValidationResult(string memberName, string message)
        {
            this.Message = message;
            this.MemberName = memberName;
        }

        public ValidationResult(string message)
        {
            this.Message = message;
        }

        public string MemberName { get; set; }

        public string Message { get; set; }
    }
}
