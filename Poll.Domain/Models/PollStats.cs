using System.ComponentModel.DataAnnotations;

namespace Poll.Domain.Models
{
    public class PollStats
    {
        [Key]
        public int stat_id { get; set; }
        public int poll_id { get; set; }
        public int views { get; set; }
    }
}