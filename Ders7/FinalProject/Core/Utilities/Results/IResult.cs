using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlagıç
    public interface IResult
    {
        bool Success { get; } //sadece okunabilir "Readable"
        //set "writeable"

        string Message { get; }
    }
}
