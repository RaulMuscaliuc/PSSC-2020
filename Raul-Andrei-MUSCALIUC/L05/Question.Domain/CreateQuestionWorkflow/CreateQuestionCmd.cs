using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    class CreateQuestionCmd
    {
        [Required]
        public string Title { get; private set; }
        [Required]
        public string Description { get; private set; }
        [Required]
        public string[] Tags { get; private set; }
        [Required]
        public int Votes { get; private set; }

        public CreateQuestionCmd(string Title, string Description, string Tags, int Votes)
        {
            this.Title = Title;
            this.Description = Description;
            this.Tags = Tags;
            this.Votes = Votes;
        }
    }
}
