using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message): base(success, message)
        {
            // success ve message değişkenlerine tekrar tekrar değer göndermemek için
            // Base classına direk yollayarak kısa yöntem ile çözdüm.
            Data = data;
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
