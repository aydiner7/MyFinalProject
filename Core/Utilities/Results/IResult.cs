using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel void başlangıç kontrol.
    //void methodları kontrol altına alıyorum.
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}
