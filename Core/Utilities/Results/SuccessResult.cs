using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true,message)  //base in iki parametreli olanını kullan
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
