using System;

namespace NewQueue
{
    public class FrontEmptyException : Exception
    {
        private readonly string _frontName;

        public FrontEmptyException(string frontName)
        {
            _frontName = frontName;
        }

        public override string Message
        {
            get
            {
                return $"Front with name {_frontName} is empty.";
            }
        }
    }
}