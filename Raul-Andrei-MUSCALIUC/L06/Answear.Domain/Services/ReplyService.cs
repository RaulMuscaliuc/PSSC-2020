using System;
using System.Collections.Generic;
using System.Text;
using static Reply.Domain.CreateReplyWorkflow.ValidationError;
using static Reply.Domain.CreateReplyWorkflow.Reply;

namespace Reply.Domain.Services
{
    public static class ReplyService
    {
        public static Either<ValidationError, ValidReply> CheckReply(UnvalitedReply UnvalitedReply)
        {
            if (UnvalitedReply.Reply.Length >= 10 && UnvalitedReply.Reply.Length <= 500)
            {
                return new ValidReply(UnvalitedReply.id, UnvalitedReply.Reply, UnvalitedReply.Name);
            }
            return ValidationError(UnvalitedReply.Reply);
        }
    }
}
