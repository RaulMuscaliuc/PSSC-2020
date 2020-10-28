using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class InvalidTagsException : Exception
    {
        public InvalidTagsException(int numberOfTags) : base($"The value \"{numberOfTags}\" is an invalid tags number.")
        {
        }
    }
}
