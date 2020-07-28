using System.ComponentModel.DataAnnotations;

namespace Poll.Domain.Models
{
    public class PollOption
    {
        [Key]
        public int option_id { get; set; }
        public int poll_id { get; set; }
        public string option_description { get; set; }
    }
}