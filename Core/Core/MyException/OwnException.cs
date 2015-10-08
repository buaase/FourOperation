using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.MyException
{
    public class OwnException : Exception
    {
        public OwnException(string Message) :base(Message)
        {

        }
    }
}
