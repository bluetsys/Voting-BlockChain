﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Votin.Model.Entities
{
    public class Election
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> Candidates { get; set; } = new List<string>();
    }
}