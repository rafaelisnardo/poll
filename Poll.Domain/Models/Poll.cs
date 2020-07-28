using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Poll.Domain.Models
{
    public partial class Poll
    {
        [Key]
        public int poll_id { get; set; }
        public string poll_description { get; set; }
    }
}
