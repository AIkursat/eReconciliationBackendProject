using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    { 
        // It will return us true that's why we set as true.
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult (string message) : base(true, message)
        {
        }
    }
}
