using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyPost.Models
{
    public class CommentCreate
    {
        [MaxLength(4000)]
        public string Text { get; set; }
    }
}
