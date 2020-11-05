using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.CreateReplyWorkflow
{
    public static class Language
    {
        public interface ILanguange { }

        public class UnverifiedLanguange
        {
            public string Reply { get; private set; }

            public UnverifiedLanguange(string Reply)
            {
                this.Reply = Reply;
            }
        }

        public class VerifiedLangunage
        {
            public string Reply { get; private set; }

            public VerifiedLangunage(string Reply)
            {
                this.Reply = Reply;
            }
        }
    }
}
