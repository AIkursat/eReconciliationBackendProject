using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        // It will return us false, that's wyh we set it as false
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult() : base(default, false)
        {
        }
        // error with message
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
