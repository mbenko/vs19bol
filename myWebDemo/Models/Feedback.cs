﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebDemo.Models
{
    public class Feedback
    {
        public string Id { get; set; }

        public string Issue { get; set; }

        public string Session { get; set; }

        public bool Complete { get; set; }

        public DateTime CreatedAt { get; set; }

        public Feedback()
        {
            CreatedAt = DateTime.UtcNow;
            Id = Guid.NewGuid().ToString();
            Complete = false;
            Session = "vs19bolDG";
        }
    }
}
