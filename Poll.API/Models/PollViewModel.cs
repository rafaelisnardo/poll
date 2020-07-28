using Poll.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poll.API.Models
{
    public class PollViewModel
    {
        public int poll_id { get; set; }
        public string poll_description { get; set; }
        public List<PollOptionDTO> options { get; set; }

        public PollViewModel(PollDTO poll, IEnumerable<PollOptionDTO> options)
        {
            this.poll_id = poll.poll_id;
            this.poll_description = poll.poll_description;
            this.options = (List<PollOptionDTO>)options;
        }
    }
}
