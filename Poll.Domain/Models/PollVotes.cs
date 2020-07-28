using System.ComponentModel.DataAnnotations;

namespace Poll.Domain.Models
{
    public class PollVotes
    {
        [Key]
        public int vote_id { get; set; }
        public int poll_id { get; set; }
        public int option_id { get; set; }
        public int qty { get; set; }
    }
}