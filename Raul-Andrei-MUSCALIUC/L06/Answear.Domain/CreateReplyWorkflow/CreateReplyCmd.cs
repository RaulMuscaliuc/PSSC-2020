using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reply.Domain.CreateReplyWorkflow
{
    public struct CreateReplyCmd
    {
        [Required]
        public Guid ReplyId;
        [Required]
        public string Description { get; private set; }
        [Required]
        public string NumeleUtilizatorului { get; private set; }

        public CreateReplyCmd(Guid id ,string description, string numeleUtilizatorului)
        {
            this.ReplyId = id;
            this.Description = description;
            this.NumeleUtilizatorului = numeleUtilizatorului;
        }
    }
}
