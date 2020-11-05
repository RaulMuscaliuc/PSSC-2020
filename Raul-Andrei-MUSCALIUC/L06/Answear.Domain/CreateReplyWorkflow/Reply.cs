using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;
using LanguageExt.Common;

namespace Reply.Domain.CreateReplyWorkflow
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
    }
}
