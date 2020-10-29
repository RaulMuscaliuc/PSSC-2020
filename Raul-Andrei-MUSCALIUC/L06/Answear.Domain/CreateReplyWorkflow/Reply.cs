using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;
using LanguageExt.Common;

namespace Answear.Domain.CreateReplyWorkflow
{
    [AsChoice]
    public static partial class Reply
    {

        public interface IReply { }

        public class UnvalitedReply : IReply
        {
            public Guid id { get; private set; }
            public string Reply { get; private set; }

            public string Name { get; private set; }

            private UnvalitedReply(Guid id,string Reply, string Name)
            {
                this.id = id;
                this.Reply = Reply;
                this.Name = Name;
            }

            public static Result<UnvalitedReply> Create(Guid id, string Reply, string Name)
            {
                if (IsReplyValid(Reply))
                {
                    return new UnvalitedReply(id,Reply, Name);
                }
                else
                {
                    return new Result<UnvalitedReply>(new ValidationError(Reply));
                }
            }

            private static bool IsReplyValid(string Reply)
            {

                if (Reply.Length>= 10 && Reply.Length <= 500)
                {
                    return true;
                }
                return false;
            }
        }

        public class ValidReply : IReply
        {
            public Guid id { get; private set; }
            public string Reply { get; private set; }

            public string Name { get; private set; }

            internal ValidReply(Guid id, string Reply, string Name)
            {
                this.id = id;
                this.Reply = Reply;
                this.Name = Name; ;
            }
        }

        public class QuestionOwnerAck : IReply
        {

        }

        public class PublishedReply: IReply
        {

        }
    }
}
