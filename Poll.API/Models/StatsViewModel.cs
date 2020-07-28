using System.Collections.Generic;

namespace Poll.API.Models
{
    public class StatsViewModel
    {
        public int views { get; set; }
        public List<VoteViewModel> votes { get; set; }
    }
}