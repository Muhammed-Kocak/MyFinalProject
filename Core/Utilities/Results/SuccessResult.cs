using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) // 2 parametreye de argüman gönderiyoruz.
        {

        }
        public SuccessResult():base(true) //Mesaj gönderilmemiş hali
        {

        }
    }
}
