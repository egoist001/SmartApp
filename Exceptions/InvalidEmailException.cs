﻿using System;
using System.Runtime.Serialization;

namespace Log_Reg_Form
{
    [Serializable]
    internal class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException()
        {
        }

        public InvalidEmailException(string message) : base(message)
        {
        }

        public InvalidEmailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}