using System.Collections.Generic;

namespace Poll.Application.DTO.DTO
{
    public class NewPollDTO
    {
        public string poll_description { get; set; }
        public List<string> options { get; set; }
    }
}