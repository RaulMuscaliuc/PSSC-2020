using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;
using LanguageExt.Common;

namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class Tags
    {
        public interface ITags { }
        public class UnverifiedTags: ITags
        {
            public string[] Tags { get; private set; }
            private UnverifiedTags(string[] tags)
            {
                Tags = tags;
            }

            public static Result<UnverifiedTags> Create(string[] tags)
            {
                if(AreTagsValid(tags))
                {
                    return new UnverifiedTags(tags);
                } else
                {
                    return new Result<UnverifiedTags>(new InvalidTagsException(tags.Length));
                }
            }

            private static bool AreTagsValid(string[] tags)
            {
                if(tags.Length >= 1 && tags.Length <=3)
                {
                    return true;
                }

                return false;
            }
        }

        public class VerifiedTags : ITags
        {
            public string[] Tags { get; private set; }

            internal VerifiedTags(string[] tags)
            {
                Tags = tags;
            }
        }
    }
}
