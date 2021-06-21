using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Kod tekrarını önlemek için IResult implement ettim.
    // Mesaj ve succes ları oradan alıyorum.
    public interface IDataResult<T> : IResult
    {
        // Geri döndürmek istediği türü seçiyor.
        T Data { get; }
    }
}
