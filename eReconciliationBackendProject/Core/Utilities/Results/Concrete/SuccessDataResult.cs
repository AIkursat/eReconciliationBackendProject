using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        // We set this true because it is succcess one.
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult() : base(default, true) // It will only return us true, no data.
        {

        }
    }
}
