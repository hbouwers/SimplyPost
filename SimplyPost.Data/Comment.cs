﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyPost.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid Author { get; set; }

        [ForeignKey(nameof(Reply))]
        public int ReplyId { get; set; }

        public virtual Reply Replies { get; set; }
    }

    public class Reply : Comment
    {
        [Key]
        public int CommentId { get; set; }
    }
}
