using System;
using System.Collections.Generic;
using System.Text;

namespace eHyperStore.Utilities.Exceptions
{
    public class EHyperException : Exception
    {
        public EHyperException()
        {
        }

        public EHyperException(string message) : base(message)
        {
        }

        public EHyperException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}