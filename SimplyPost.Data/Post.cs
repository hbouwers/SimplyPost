using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyPost.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [ForeignKey(nameof(Comment))]
        public int CustomerId { get; set; }

        public virtual Comment Comments { get; set; }
        public Guid Author { get; set; }
    }
}
