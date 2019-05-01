﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchRater.Models.ChurchRatingModels
{
    public class ChurchRatingEdit
    {
        public int ChurchID { get; set; }

        public int CommunityInvolvementRating { get; set; }

        public int FriendlyRating { get; set; }

        public int FacilityRating { get; set; }

        public int MusicRating { get; set; }

        public int MessageRating { get; set; }
    }
}
