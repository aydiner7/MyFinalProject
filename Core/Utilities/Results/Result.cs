using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this(success): bu classın içerisine success yolla. Tek paremetre alan 2. class*
        // Kod tekrarını engelledim ve aynı anda 2 sini birden çalıştırdım.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        // Set engeli olmasına rağmen, constructor lar da set edilebilirler.
        // Bunun amacı, doğru kod yazmaya itiyorum.
        public bool Success { get; }

        public string Message { get; }
    }
}
