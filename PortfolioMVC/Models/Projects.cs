﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioMVC.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
