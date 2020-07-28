using System;
using System.Collections.Generic;
using System.Text;

namespace Poll.Application.DTO.DTO
{
    public class NewPollOptionDTO
    {
        public int poll_id { get; set; }
        public string option_description { get; set; }
    }
}
