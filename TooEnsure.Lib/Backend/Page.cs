﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooEnsure.Lib.Backend
{
    public class Page
    {
        public int Id { get; set; }
        public string ImageUri { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
