using System;

namespace num2.Exceptions
{
    internal class OutOfDiapazonException : Exception
    {
        public  string Comment { get;}
        public OutOfDiapazonException(string comment="Some")
        {
            Comment = comment;
        }

        public OutOfDiapazonException(string message,string comment="Some comment") : base(message)
        {
        }
    }
}
