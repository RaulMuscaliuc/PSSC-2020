using System;
using System.Collections.Generic;
using System.Text;

namespace Answear.Domain.CreateReplyWorkflow
{
    [Serializable]
    public class ValidationError : Exception
    {
        public ValidationError()
        {
        }

        public ValidationError(string answear) : base($"The value \"{answear}\" is an invalid answear format.")
        {
        }
    }
}
