﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchRater.Data
{
  public  class Leadership
    {
        public int LeaderID { get; set; }

        public string LeaderName { get; set; }

        public Guid UserID { get; set; }

        public string SpeakingAbility { get; set; }

        public string Engaging { get; set; }

        public string Authentic { get; set; }

        public string Rapport { get; set; }
    }
}
