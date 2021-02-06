using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyPost.Data
{
    public class Reply : Comment
    {
        public int CommentId { get; set; }
    }
}
