﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchRater.Data
{
    public class Church
    {

        public int ChurchID { get; set; }

        public Guid UserID { get; set; }

        public string ChurchName { get; set; }

        public string ChurchLocation { get; set; }

        public string CommunityInvolvement { get; set; }

        public string Friendliness { get; set; }

        public string Facilities { get; set; }

        public string Music { get; set; }

        public string Message { get; set; }



    }
}
