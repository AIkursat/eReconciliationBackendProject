using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success, message) // It will get us message, data and success info
        {
            Data = data;    
        }
        public DataResult(T data, bool success):base(success) // It will get us Data and success info
        {
            Data=data;
        }
        public T Data { get; }
    }
}
