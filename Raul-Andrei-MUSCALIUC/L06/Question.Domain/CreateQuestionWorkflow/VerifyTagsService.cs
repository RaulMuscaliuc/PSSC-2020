using CSharp.Choices;
using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.Tags;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class VerifyTagsService
    {
        public Result<VerifiedTags> VerifyTags(UnverifiedTags tags)
        {
            return new VerifiedTags(tags.Tags);
        }
    }
}
