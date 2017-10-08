using System;

namespace AAk.FarsiLibrary.Utils.Exceptions
{
    public class InvalidPersianDateFormatException : Exception
    {
        public InvalidPersianDateFormatException(string message)
            : base(message)
        {
        }

        public InvalidPersianDateFormatException() : base(string.Empty)
        { 
        }
    }
}
