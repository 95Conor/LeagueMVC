﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Classes.Application.League
{
    public class User
    {
        public string Username { get; set; }
        public long UserID { get; set; }
        public DateTime LastLogin { get; set; }
        public TimeSpan TimeSinceLastLogin { get; set; }
    }
}
