using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchRater.Models.LeaderModels
{
    public class LeaderDetail
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
