using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exeptions
{
    public class AppExeptions : Exception
    {
        public AppExeptions()
        {

        }
        public AppExeptions(string message): base(message)
        {
            
        }

        public AppExeptions(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
