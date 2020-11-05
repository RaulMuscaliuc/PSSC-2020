using System;
using System.Collections.Generic;
using System.Text;
using static Reply.Domain.CreateReplyWorkflow.Language;

namespace Reply.Domain.Services
{
    public static class LanguangeService
    {
        public static Either<ValidationError, VerifiedLangunage> CheckReply(UnverifiedLanguange UnverifiedLanguange)
        {
            if (UnverifiedLanguange.Reply.Contains('x') 
            {
                return new VerifiedLangunage(UnverifiedLanguange.Reply);
            }
            return ValidationError(UnverifiedLanguange.Reply);
        }
    }
}
