﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyPost.Models
{
    public class PostListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Guid Author { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}
